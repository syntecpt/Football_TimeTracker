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
    public partial class HistoryDetailForm : Form
    {
        List<Segment> segments;
        int offsetX,offsetX2;
        public HistoryDetailForm()
        {
            InitializeComponent();
            this.FormClosing += HistoryForm_FormClosing;
        }

        public HistoryDetailForm(string gamePath)
        {
            InitializeComponent();
            this.FormClosing += HistoryForm_FormClosing;
            segments = JsonSerialization.ReadFromJsonFile<List<Segment>>( gamePath );

            string[] info;
            info = gamePath.Split( '\\' );
            info = info[ 1 ].Split( '.' );
            info = info[ 0 ].Split( '_' );
            GameNameLabel.Text = info[ 0 ];
            CompetitionLabel.Text = info[ 1 ];
            DateLabel.Text = info[ 2 ];

            this.Text = info[ 0 ] + "_" + info[1] + "_" + info[2];

            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";

            CreateSegments();
            UpdateTotals();
        }

        private void HistoryForm_FormClosing( Object sender, FormClosingEventArgs e )
        {
            Application.Exit();
        }

        private void backButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.CloseHistoryDetail();
        }

        private void CreateSegments()
        {
            offsetX = 0;
            offsetX2 = 0;
            foreach (Segment segment in segments)
            {
                var picture = new PictureBox
                {
                    Size = new Size( 1, Constants.SegmentHeigth ),
                    Location = new Point( GetXPosition(segment.elapsedMinutes, segment.elapsedSeconds, segment.half), GetYPosition(segment.half) ),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                this.Controls.Add( picture );

                segment.image = picture;
                SetWidth( segment );

                picture.BringToFront();

                switch ( segment.segmentType )
                {
                    case Constants.segmentTypeActive:
                        segment.image.BackColor = Constants.colorSegmentActive;
                        break;
                    case Constants.segmentTypeOutofBounds:
                        segment.image.BackColor = Constants.colorSegmentOutofBounds;
                        break;
                    case Constants.segmentTypeRefBlow:
                        segment.image.BackColor = Constants.colorSegmentRefBlow;
                        break;
                    case Constants.segmentTypeGoal:
                        segment.image.BackColor = Constants.colorSegmentGoal;
                        break;
                }
            }
        }

        private int GetXPosition(int elapsedMinutes, int elapsedSeconds, int half)
        {
            int result;
            if ( half == 0 )
            {
                result = ( elapsedMinutes * Constants.minuteWidth ) + GetMinX( elapsedSeconds ) + offsetX;
                return placeholder_label.Location.X + offsetX;
            }
            else
            {
                result = ( elapsedMinutes * Constants.minuteWidth ) + GetMinX( elapsedSeconds ) + offsetX2;
                return placeholder_label.Location.X + offsetX2;
            }
            
        }

        private int GetMinX(int elapsedSeconds)
        {
            int result = (int)( elapsedSeconds * Constants.secondWidth );
            if ( result == 0 )
                return 1;
            else return result;
        }

        private int GetYPosition(int half)
        {
            if ( half == 0 )
                return placeholder_label.Location.Y;
            else
                return placeholder_label_bottom.Location.Y;
        }

        public void SetWidth(Segment segment)
        {
            segment.image.Width = ( segment.elapsedMinutes * Constants.minuteWidth ) + GetMinX(segment.elapsedSeconds);
            if ( segment.half == 0 )
                offsetX += segment.image.Width;
            else
                offsetX2 += segment.image.Width;
        }

        private void UpdateTotals()
        {
            #region Text Stats
            int elapsedMinutesActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            int elapsedMinutesGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            int elapsedSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

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

            int TotalMinutes = segments.Sum( x => x.elapsedMinutes );
            int TotalSeconds = segments.Sum( x => x.elapsedSeconds );
            while ( TotalSeconds >= 60 )
            {
                TotalSeconds -= 60;
                TotalMinutes++;
            }
            TotalGameTimeLabel.Text = TotalMinutes.ToString( "D2" ) + ":" + TotalSeconds.ToString( "D2" );
            #endregion

            #region Pie Chart
            elapsedMinutesActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            elapsedMinutesOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            elapsedMinutesRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            elapsedMinutesGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            elapsedSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

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
            elapsedMinutesActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
            elapsedMinutesOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedMinutes );
            elapsedMinutesRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedMinutes );
            elapsedMinutesGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );

            elapsedSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

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

            MaxYValue = Math.Ceiling( MaxYValue );
            BarChart.ChartAreas[ 0 ].AxisY.Maximum = MaxYValue;
            #endregion

            #region Other Text Stats
            totalSegmentsResult.Text = segments.Count.ToString();

            Segment biggestActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedMinutes ).ThenByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestActive != null )
            {
                biggestActiveSegmentResult.Text = biggestActive.elapsedMinutes.ToString( "D2" ) + ":" + biggestActive.elapsedSeconds.ToString( "D2" );
            }
            Segment biggestStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedMinutes ).ThenByDescending( x => x.elapsedSeconds ).FirstOrDefault();
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

            int CountSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Count();
            if ( CountSecondsActive > 0 )
            {
                int TotalMinutesActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
                int TotalSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
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

            int CountSecondsStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).Count();
            if ( CountSecondsStopped > 0 )
            {
                int TotalMinutesStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedMinutes );
                int TotalSecondsStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
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

            int CountSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Count();
            if ( CountSecondsGoal > 0 )
            {
                int TotalMinutesGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedMinutes );
                int TotalSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );
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

        private void HistoryDetailForm_Load( object sender, EventArgs e )
        {

        }
    }
}
