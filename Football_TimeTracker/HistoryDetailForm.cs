using Newtonsoft.Json;
using Octokit;
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
        List<Segment> originalSegments, falcaturaSegments, SelectedSegments;

        public HistoryDetailForm(string gamePath, string location)
        {
            InitializeComponent();
            this.FormClosing += HistoryForm_FormClosing;

            if (location == "Internet")
            {
                GitHubClient github = new GitHubClient( new ProductHeaderValue( Constants.ProjectName ) );
                try
                {
                    var result = github.Repository.Content.GetAllContents( Constants.GitHubUserName, Constants.ProjectName, gamePath ).Result;
                    IEnumerable<Segment> deserialized = JsonConvert.DeserializeObject<IEnumerable<Segment>>( result.SingleOrDefault().Content );
                    originalSegments = deserialized.ToList();
                    falcaturaSegments = DoFalcatrua();
                    SelectedSegments = new List<Segment>();
                    string[] info;
                    info = gamePath.Split( '/' );
                    info = info[ 1 ].Split( '.' );
                    info = info[ 0 ].Split( '_' );
                    GameNameLabel.Text = info[ 0 ];
                    CompetitionLabel.Text = info[ 1 ];
                    DateLabel.Text = info[ 2 ];

                    this.Text = info[ 0 ] + "_" + info[ 1 ] + "_" + info[ 2 ];
                }
                catch
                {
                    string message = "Sem ligação à internet. Usando apenas ficheiros locais.";
                    string title = "Sem Internet";
                    MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    originalSegments = new List<Segment>();
                    falcaturaSegments = DoFalcatrua();
                    SelectedSegments = new List<Segment>();

                    GameNameLabel.Text = "";
                    CompetitionLabel.Text = "";
                    DateLabel.Text = "";

                    this.Text = "Sem ligação internet";
                }
            }
            else
            {
                originalSegments = JsonSerialization.ReadFromJsonFile<List<Segment>>( gamePath );
                falcaturaSegments = DoFalcatrua();
                SelectedSegments = new List<Segment>();
                string[] info;
                info = gamePath.Split( '\\' );
                info = info[ 1 ].Split( '.' );
                info = info[ 0 ].Split( '_' );
                GameNameLabel.Text = info[ 0 ];
                CompetitionLabel.Text = info[ 1 ];
                DateLabel.Text = info[ 2 ];

                this.Text = info[ 0 ] + "_" + info[ 1 ] + "_" + info[ 2 ];
            }
            
            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";

            GetSelectedSegments();

            InterceptKeys.ResizeForm( this ); //resize form
            CenterToScreen(); // then center
        }

        private void HistoryForm_FormClosing( Object sender, FormClosingEventArgs e )
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.CloseHistoryDetail();
        }

        private List<Segment> DoFalcatrua()
        {
            List<Segment> falcatruaList = new List<Segment>();

            List<Segment> regularSegment = new List<Segment>();
            List<Segment> addedSegment = new List<Segment>();
            int offset = 0;
            //first half
            if ( originalSegments.Where( x => x.half == 0 ).Sum( x => x.elapsedSeconds ) > Constants.minute45 )
            {
                regularSegment = originalSegments.Where( x => x.half == 0 && x.startingSeconds < Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                addedSegment = originalSegments.Where( x => x.half == 0 && x.startingSeconds >= Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                offset = ( regularSegment.LastOrDefault().startingSeconds + regularSegment.LastOrDefault().elapsedSeconds ) - Constants.minute45;
                Segment falcatruaSegment = new Segment()
                {
                    half = regularSegment.LastOrDefault().half,
                    segmentType = regularSegment.LastOrDefault().segmentType,
                    startingSeconds = regularSegment.LastOrDefault().startingSeconds,
                    elapsedSeconds = regularSegment.LastOrDefault().elapsedSeconds - offset
                };
                Segment falcatruaSegment2 = new Segment()
                {
                    half = regularSegment.LastOrDefault().half,
                    segmentType = regularSegment.LastOrDefault().segmentType,
                    startingSeconds = Constants.minute45,
                    elapsedSeconds = offset
                };
                falcatruaList.AddRange( regularSegment );
                falcatruaList.AddRange( addedSegment );
                falcatruaList.Remove( regularSegment.LastOrDefault() );
                falcatruaList.Add( falcatruaSegment );
                falcatruaList.Add( falcatruaSegment2 );
            }
            else
            {
                regularSegment = originalSegments.Where( x => x.half == 0 && x.startingSeconds < Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                falcatruaList.AddRange( regularSegment );
            }
            //second half
            if ( originalSegments.Where( x => x.half == 1 ).Sum( x => x.elapsedSeconds ) > Constants.minute45 )
            {
                regularSegment = originalSegments.Where( x => x.half == 1 && x.startingSeconds < Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                addedSegment = originalSegments.Where( x => x.half == 1 && x.startingSeconds >= Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                offset = ( regularSegment.LastOrDefault().startingSeconds + regularSegment.LastOrDefault().elapsedSeconds ) - Constants.minute45;
                Segment falcatruaSegment = new Segment()
                {
                    half = regularSegment.LastOrDefault().half,
                    segmentType = regularSegment.LastOrDefault().segmentType,
                    startingSeconds = regularSegment.LastOrDefault().startingSeconds,
                    elapsedSeconds = regularSegment.LastOrDefault().elapsedSeconds - offset
                };
                Segment falcatruaSegment2 = new Segment()
                {
                    half = regularSegment.LastOrDefault().half,
                    segmentType = regularSegment.LastOrDefault().segmentType,
                    startingSeconds = Constants.minute45,
                    elapsedSeconds = offset
                };
                falcatruaList.AddRange( regularSegment );
                falcatruaList.AddRange( addedSegment );
                falcatruaList.Remove( regularSegment.LastOrDefault() );
                falcatruaList.Add( falcatruaSegment );
                falcatruaList.Add( falcatruaSegment2 );
            }
            else
            {
                regularSegment = originalSegments.Where( x => x.half == 1 && x.startingSeconds < Constants.minute45 ).OrderBy( x => x.startingSeconds ).ToList();
                falcatruaList.AddRange( regularSegment );
            }

            return falcatruaList;
        }

        private void CreateSegments()
        {
            foreach ( Segment segment in originalSegments )
            {
                if ( segment.image != null )
                {
                    Controls.Remove( segment.image );
                }
            }
            foreach (Segment segment in falcaturaSegments)
            {
                if ( segment.image != null )
                {
                    Controls.Remove( segment.image );
                }
            }

            foreach(Segment segment in SelectedSegments)
            {
                var picture = new PictureBox
                {
                    Size = new Size( 1, Constants.SegmentHeigth ),
                    Location = new Point( GetXPosition( segment.startingSeconds, segment.half ), GetYPosition( segment.half ) ),
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

        private int GetXPosition(int startingSeconds, int half)
        {
            if ( half == 0 )
            {
                return placeholder_label.Location.X + GetMinX(startingSeconds);
            }
            else
            {
                return placeholder_label.Location.X + GetMinX( startingSeconds );
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
            segment.image.Width = GetMinX(segment.elapsedSeconds);
        }

        private void UpdateTotals()
        {
            #region Text Stats
            int elapsedMinutesActive = 0;
            int elapsedMinutesOutofBounds = 0;
            int elapsedMinutesRefBlow = 0;
            int elapsedMinutesGoal = 0;

            int elapsedSecondsActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsOutofBounds = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsRefBlow = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsGoal = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

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

            int TotalMinutes = 0;
            int TotalSeconds = SelectedSegments.Sum( x => x.elapsedSeconds );
            while ( TotalSeconds >= 60 )
            {
                TotalSeconds -= 60;
                TotalMinutes++;
            }
            TotalGameTimeLabel.Text = TotalMinutes.ToString( "D2" ) + ":" + TotalSeconds.ToString( "D2" );
            #endregion

            #region Pie Chart
            elapsedMinutesActive = 0;
            elapsedMinutesOutofBounds = 0;
            elapsedMinutesRefBlow = 0;
            elapsedMinutesGoal = 0;

            elapsedSecondsActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

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
            elapsedSecondsActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            double BarMinutesActive = (double)elapsedSecondsActive / 60;
            double BarMinutesOutOfBounds = (double)elapsedSecondsOutofBounds / 60;
            double BarMinutesRefBlow = (double)elapsedSecondsRefBlow / 60;
            double BarMinutesGoal = (double)elapsedSecondsGoal / 60;

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
            totalSegmentsResult.Text = SelectedSegments.Count.ToString();
            int formattedMinutes, formattedSeconds;

            Segment biggestActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestActive != null )
            {
                formattedMinutes = 0;
                formattedSeconds = biggestActive.elapsedSeconds;
                while ( formattedSeconds >= 60 )
                {
                    formattedSeconds -= 60;
                    formattedMinutes++;
                }
                biggestActiveSegmentResult.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            Segment biggestStopped = SelectedSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestStopped != null )
            {
                formattedMinutes = 0;
                formattedSeconds = biggestStopped.elapsedSeconds;
                while ( formattedSeconds >= 60 )
                {
                    formattedSeconds -= 60;
                    formattedMinutes++;
                }
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
                biggestStoppedSegmentResult.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            else
            {
                biggestStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.Text = "00:00";
            }

            int CountSecondsActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Count();
            if ( CountSecondsActive > 0 )
            {
                int TotalSecondsActive = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
                int AverageActiveSeconds = TotalSecondsActive / CountSecondsActive;
                int AverageActiveMinutes = 0;
                while ( AverageActiveSeconds >= 60 )
                {
                    AverageActiveSeconds -= 60;
                    AverageActiveMinutes++;
                }

                averageActiveSegmentResult.Text = AverageActiveMinutes.ToString( "D2" ) + ":" + AverageActiveSeconds.ToString( "D2" );
            }

            int CountSecondsStopped = SelectedSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Count();
            if ( CountSecondsStopped > 0 )
            {
                int TotalSecondsStopped = SelectedSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
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

            int CountSecondsGoal = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Count();
            if ( CountSecondsGoal > 0 )
            {
                int TotalSecondsGoal = SelectedSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );
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

        private void GetSelectedSegments()
        {
            if(allTimeRadio.Checked)
            {
                SelectedSegments = originalSegments;
            }
            else
            {
                SelectedSegments = falcaturaSegments;
                if(regularTimeRadio.Checked)
                {
                    SelectedSegments = SelectedSegments.Where( x => x.startingSeconds < Constants.minute45 ).ToList();
                }
                else if (addedTimeRadio.Checked)
                {
                    SelectedSegments = SelectedSegments.Where( x => x.startingSeconds >= Constants.minute45 ).ToList();
                }
            }

            if ( firstHalfRadio.Checked )
            {
                SelectedSegments = SelectedSegments.Where( x => x.half == 0).ToList();
            }
            else if ( secondHalfRadio.Checked )
            {
                SelectedSegments = SelectedSegments.Where( x => x.half == 1 ).ToList();
            }

            CreateSegments();

            UpdateTotals();
        }

        private void bothHalfsRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }

        private void firstHalfRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }

        private void secondHalfRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }

        private void allTimeRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }

        private void regularTimeRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }

        private void addedTimeRadio_CheckedChanged( object sender, EventArgs e )
        {
            RadioButton rb = sender as RadioButton;
            if ( rb != null )
            {
                if ( rb.Checked )
                {
                    GetSelectedSegments();
                }
            }
        }
    }
}
