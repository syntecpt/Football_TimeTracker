using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_TimeTracker
{
    public partial class HistoryForm : Form
    {
        List<Segment> totalSegments;

        public HistoryForm()
        {
            InitializeComponent();
            this.FormClosing += HistoryForm_FormClosing;
            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";
        }

        private void HistoryForm_Load( object sender, EventArgs e )
        {
            DataGridViewButtonColumn SelectButton = new DataGridViewButtonColumn();
            SelectButton.Name = "Ver Detalhe";
            SelectButton.Text = "Detalhe";
            SelectButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert( 5, SelectButton );

            var path = Directory.CreateDirectory( "saved_games" );
            string[] files = Directory.GetFiles( path.Name, "*.txt" );
            string[] info;
            foreach ( string file in files )
            {
                if ( !file.Contains( '\\' ) )
                    continue;
                if ( !file.Contains( '.' ) )
                    continue;

                info = file.Split( '\\' );
                info = info[ 1 ].Split( '.' );
                info = info[ 0 ].Split( '_' );

                if ( info.Length != 3 )
                    continue;
                dataGridView1.Rows.Add( file, false, info[ 0 ], info[ 1 ], info[ 2 ] );
            }
        }

        private void BackButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.CloseHistory();
        }

        private void HistoryForm_FormClosing( Object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            var senderGrid = (DataGridView)sender;

            if ( senderGrid.Columns[ e.ColumnIndex ] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 )
            {
                var path = senderGrid.Rows[ e.RowIndex ].Cells[0].Value;
                InterceptKeys.ShowHistoryDetail(path.ToString());
            }

            if ( senderGrid.Columns[ e.ColumnIndex ] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0 )
            {
                senderGrid.CommitEdit( DataGridViewDataErrorContexts.Commit );
                
                LoadSelectedGames( senderGrid );
            }
        }

        private void LoadSelectedGames( DataGridView sender)
        {
            totalSegments = new List<Segment>();
            List<Segment> currSegments = new List<Segment>();
            foreach ( DataGridViewRow row in sender.Rows )
            {
                bool isSelected = Convert.ToBoolean( row.Cells[ "SelectedCheckbox" ].Value );
                if ( isSelected )
                {
                    string path = row.Cells[ 0 ].Value.ToString();
                    List<Segment> thisSegment = JsonSerialization.ReadFromJsonFile<List<Segment>>( path );
                    totalSegments.AddRange( thisSegment );
                }
            }

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            #region Text Stats
            int elapsedMinutesActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            int elapsedSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            while ( elapsedSecondsActive >= 60 )
            {
                elapsedSecondsActive -= 60;
                elapsedMinutesActive++;
            }
            while ( elapsedSecondsOutofBounds >= 60 )
            {
                elapsedSecondsOutofBounds -= 60;
                elapsedMinutesOutofBounds++;
            }
            while ( elapsedSecondsRefBlow >= 60 )
            {
                elapsedSecondsRefBlow -= 60;
                elapsedMinutesRefBlow++;
            }
            while ( elapsedSecondsGoal >= 60 )
            {
                elapsedSecondsGoal -= 60;
                elapsedMinutesGoal++;
            }


            StateActiveTimer.Text = elapsedMinutesActive.ToString( "D2" ) + ":" + elapsedSecondsActive.ToString( "D2" );
            StateOutofBoundsTimer.Text = elapsedMinutesOutofBounds.ToString( "D2" ) + ":" + elapsedSecondsOutofBounds.ToString( "D2" );
            StateRefBlowTimer.Text = elapsedMinutesRefBlow.ToString( "D2" ) + ":" + elapsedSecondsRefBlow.ToString( "D2" );
            StateGoalTimer.Text = elapsedMinutesGoal.ToString( "D2" ) + ":" + elapsedSecondsGoal.ToString( "D2" );

            int TotalMinutes = totalSegments.Sum( x => x.elapsedMinutes );
            int TotalSeconds = totalSegments.Sum( x => x.elapsedSeconds );
            while ( TotalSeconds >= 60 )
            {
                TotalSeconds -= 60;
                TotalMinutes++;
            }
            TotalGameTimeLabel.Text = TotalMinutes.ToString( "D2" ) + ":" + TotalSeconds.ToString( "D2" );
            #endregion

            #region Pie Chart
            elapsedMinutesActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            elapsedMinutesOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            elapsedMinutesRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            elapsedMinutesGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            elapsedSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            while ( elapsedMinutesActive > 0 )
            {
                elapsedSecondsActive += 60;
                elapsedMinutesActive--;
            }
            while ( elapsedMinutesOutofBounds > 0 )
            {
                elapsedSecondsOutofBounds += 60;
                elapsedMinutesOutofBounds--;
            }
            while ( elapsedMinutesRefBlow > 0 )
            {
                elapsedSecondsRefBlow += 60;
                elapsedMinutesRefBlow--;
            }
            while ( elapsedMinutesGoal > 0 )
            {
                elapsedSecondsGoal += 60;
                elapsedMinutesGoal--;
            }

            int totalSecondsElapsed = elapsedSecondsActive + elapsedSecondsOutofBounds + elapsedSecondsRefBlow + elapsedSecondsGoal;

            if ( elapsedSecondsActive > 0 )
            {
                PieChart.Series[ 0 ].Points[ 0 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 0 ].Label = ( ( (decimal)elapsedSecondsActive / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 0 ].Label = "";
            }
            if ( elapsedSecondsOutofBounds > 0 )
            {
                PieChart.Series[ 0 ].Points[ 1 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 1 ].Label = ( ( (decimal)elapsedSecondsOutofBounds / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 1 ].Label = "";
            }
            if ( elapsedSecondsRefBlow > 0 )
            {
                PieChart.Series[ 0 ].Points[ 2 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 2 ].Label = ( ( (decimal)elapsedSecondsRefBlow / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 2 ].Label = "";
            }
            if ( elapsedSecondsGoal > 0 )
            {
                PieChart.Series[ 0 ].Points[ 3 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 3 ].Label = ( ( (decimal)elapsedSecondsGoal / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 3 ].Label = "";
            }

            PieChart.Series[ 0 ].Points[ 0 ].SetValueY( elapsedSecondsActive );
            PieChart.Series[ 0 ].Points[ 1 ].SetValueY( elapsedSecondsOutofBounds );
            PieChart.Series[ 0 ].Points[ 2 ].SetValueY( elapsedSecondsRefBlow );
            PieChart.Series[ 0 ].Points[ 3 ].SetValueY( elapsedSecondsGoal );
            #endregion

            #region Bar Chart
            elapsedMinutesActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            elapsedMinutesOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            elapsedMinutesRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            elapsedMinutesGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            elapsedSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            double BarMinutesActive = elapsedMinutesActive + ( (double)elapsedSecondsActive / 60 );
            double BarMinutesOutOfBounds = elapsedMinutesOutofBounds + ( (double)elapsedSecondsOutofBounds / 60 );
            double BarMinutesRefBlow = elapsedMinutesRefBlow + ( (double)elapsedSecondsRefBlow / 60 );
            double BarMinutesGoal = elapsedMinutesGoal + ( (double)elapsedSecondsGoal / 60 );

            if ( BarMinutesActive > 0 )
            {
                BarChart.Series[ 0 ].Points[ 0 ].Label = BarMinutesActive.ToString( "0.##" );
                BarChart.Series[ 0 ].Points[ 0 ].IsEmpty = false;
                BarChart.Series[ 0 ].Points[ 0 ].SetValueY( BarMinutesActive );
            }
            else
            {
                BarChart.Series[ 0 ].Points[ 0 ].Label = "";
                BarChart.Series[ 0 ].Points[ 0 ].IsEmpty = true;
                BarChart.Series[ 0 ].Points[ 0 ].SetValueY( BarMinutesActive );
            }
            if ( BarMinutesOutOfBounds > 0 )
            {
                BarChart.Series[ 0 ].Points[ 1 ].Label = BarMinutesOutOfBounds.ToString( "0.##" );
                BarChart.Series[ 0 ].Points[ 1 ].IsEmpty = false;
                BarChart.Series[ 0 ].Points[ 1 ].SetValueY( BarMinutesOutOfBounds );
            }
            else
            {
                BarChart.Series[ 0 ].Points[ 1 ].Label = "";
                BarChart.Series[ 0 ].Points[ 1 ].IsEmpty = true;
                BarChart.Series[ 0 ].Points[ 1 ].SetValueY( BarMinutesOutOfBounds );
            }
            if ( BarMinutesRefBlow > 0 )
            {
                BarChart.Series[ 0 ].Points[ 2 ].Label = BarMinutesRefBlow.ToString( "0.##" );
                BarChart.Series[ 0 ].Points[ 2 ].IsEmpty = false;
                BarChart.Series[ 0 ].Points[ 2 ].SetValueY( BarMinutesRefBlow );
            }
            else
            {
                BarChart.Series[ 0 ].Points[ 2 ].Label = "";
                BarChart.Series[ 0 ].Points[ 2 ].IsEmpty = true;
                BarChart.Series[ 0 ].Points[ 2 ].SetValueY( BarMinutesRefBlow );
            }
            if ( BarMinutesGoal > 0 )
            {
                BarChart.Series[ 0 ].Points[ 3 ].Label = BarMinutesGoal.ToString( "0.##" );
                BarChart.Series[ 0 ].Points[ 3 ].IsEmpty = false;
                BarChart.Series[ 0 ].Points[ 3 ].SetValueY( BarMinutesGoal );
            }
            else
            {
                BarChart.Series[ 0 ].Points[ 3 ].Label = "";
                BarChart.Series[ 0 ].Points[ 3 ].IsEmpty = true;
                BarChart.Series[ 0 ].Points[ 3 ].SetValueY( BarMinutesGoal );
            }

            double MaxYValue;
            MaxYValue = BarMinutesActive;
            if ( BarMinutesOutOfBounds > MaxYValue )
                MaxYValue = BarMinutesOutOfBounds;
            if ( BarMinutesRefBlow > MaxYValue )
                MaxYValue = BarMinutesRefBlow;
            if ( BarMinutesGoal > MaxYValue )
                MaxYValue = BarMinutesGoal;

            if (MaxYValue < 1)
                MaxYValue = 1;

            MaxYValue = Math.Ceiling( MaxYValue );
            BarChart.ChartAreas[ 0 ].AxisY.Maximum = MaxYValue;
            #endregion

            #region Other Text Stats
            totalSegmentsResult.Text = totalSegments.Count.ToString();

            Segment biggestActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedMinutes ).ThenByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestActive != null )
            {
                biggestActiveSegmentResult.Text = biggestActive.elapsedMinutes.ToString( "D2" ) + ":" + biggestActive.elapsedSeconds.ToString( "D2" );
            }
            Segment biggestStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedMinutes ).ThenByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestStopped != null )
            {
                switch ( biggestStopped.segmentType )
                {
                    case Constants.segmentTypeOutofBounds:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentOutofBounds;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentOutofBounds;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentOutofBounds;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentOutofBounds;
                        break;
                    case Constants.segmentTypeRefBlow:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentRefBlow;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentRefBlow;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentRefBlow;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentRefBlow;
                        break;
                    case Constants.segmentTypeGoal:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentGoal;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentGoal;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentGoal;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentGoal;
                        break;
                }
                biggestStoppedSegmentResult.Text = biggestStopped.elapsedMinutes.ToString( "D2" ) + ":" + biggestStopped.elapsedSeconds.ToString( "D2" );
            }
            else
            {
                biggestStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.Text = "00:00";
            }

            int CountSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Count();
            if ( CountSecondsActive > 0 )
            {
                int TotalMinutesActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
                int TotalSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
                while ( TotalMinutesActive > 0 )
                {
                    TotalSecondsActive += 60;
                    TotalMinutesActive--;
                }
                int AverageActiveSeconds = TotalSecondsActive / CountSecondsActive;
                int AverageActiveMinutes = 0;
                while ( AverageActiveSeconds >= 60 )
                {
                    AverageActiveSeconds -= 60;
                    AverageActiveMinutes++;
                }

                averageActiveSegmentResult.Text = AverageActiveMinutes.ToString( "D2" ) + ":" + AverageActiveSeconds.ToString( "D2" );
            }

            int CountSecondsStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Count();
            if ( CountSecondsStopped > 0 )
            {
                int TotalMinutesStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
                int TotalSecondsStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
                while ( TotalMinutesStopped > 0 )
                {
                    TotalSecondsStopped += 60;
                    TotalMinutesStopped--;
                }
                int AverageStoppedSeconds = TotalSecondsStopped / CountSecondsStopped;
                int AverageStoppedMinutes = 0;
                while ( AverageStoppedSeconds >= 60 )
                {
                    AverageStoppedSeconds -= 60;
                    AverageStoppedMinutes++;
                }

                averageStoppedSegmentResult.Text = AverageStoppedMinutes.ToString( "D2" ) + ":" + AverageStoppedSeconds.ToString( "D2" );
            }
            else
            {
                averageStoppedSegmentResult.Text = "00:00";
            }

            int CountSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Count();
            if ( CountSecondsGoal > 0 )
            {
                int TotalMinutesGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );
                int TotalSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );
                while ( TotalMinutesGoal > 0 )
                {
                    TotalSecondsGoal += 60;
                    TotalMinutesGoal--;
                }
                int AverageGoalSeconds = TotalSecondsGoal / CountSecondsGoal;
                int AverageGoalMinutes = 0;
                while ( AverageGoalSeconds >= 60 )
                {
                    AverageGoalSeconds -= 60;
                    AverageGoalMinutes++;
                }

                averageGoalSegmentResult.Text = AverageGoalMinutes.ToString( "D2" ) + ":" + AverageGoalSeconds.ToString( "D2" );
            }
            else
            {
                averageGoalSegmentResult.Text = "00:00";
            }
            #endregion
        }
    }
}
