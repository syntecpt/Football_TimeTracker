using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Football_TimeTracker
{
    public partial class GameForm : Form
    {
        Timer timerPrincipal;
        Timer timerAdicional;
        int minutes, seconds, aditionalMinutes, aditionalSeconds, half, currentSegmentType;
        List<Segment> segments;
        bool ticking;

        public GameForm()
        {
            InitializeComponent();
            timerPrincipal = new Timer();
            timerAdicional = new Timer();
            half = 0;
            timerPrincipal.Interval = 1000;
            timerPrincipal.Tick += new EventHandler( TimerSecondPassed );
            timerAdicional.Interval = 1000;
            timerAdicional.Tick += new EventHandler( AditionalTimerSecondPassed );
            segments = new List<Segment>();
            currentSegmentType = 0;
            ticking = false;
        }

        private void endButton_Click( object sender, EventArgs e )
        {
            if ( endButton.Enabled )
            {
                if ( half == 0 )
                {
                    timerPrincipal.Stop();
                    timerAdicional.Stop();
                    endButton.Enabled = false;
                    startButton.Enabled = true;
                    startButton.Text = "Iniciar 2ª parte";
                    endButton.Text = "Terminar 2ª parte";
                    half++;
                }
                else
                {
                    timerPrincipal.Stop();
                    timerAdicional.Stop();
                    endButton.Enabled = false;
                    startButton.Enabled = false;
                }
                ticking = false;
                /*else if (half==1)
                {
                    timerPrincipal.Stop();
                    timerAdicional.Stop();
                    endButton.Enabled = false;
                    startButton.Enabled = true;
                    startButton.Text = "Iniciar 1ª parte do prolongamento";
                    endButton.Text = "Terminar 1ª parte do prolongamento";
                    half++;
                }
                else if ( half == 2 )
                {
                    timerPrincipal.Stop();
                    timerAdicional.Stop();
                    endButton.Enabled = false;
                    startButton.Enabled = true;
                    startButton.Text = "Iniciar 2ª parte do prolongamento";
                    endButton.Text = "Terminar 2ª parte do prolongamento";
                    half++;
                }*/
            }
        }

        private void startButton_Click( object sender, EventArgs e )
        {
            if ( startButton.Enabled )
            {
                minutes = 0;
                seconds = 0;
                aditionalMinutes = 0;
                aditionalSeconds = 0;
                timerPrincipal.Start();
                startButton.Enabled = false;
                endButton.Enabled = true;
                tempoTotalLabel.Text = "00:00";
                tempoAdicionalLabel.Visible = false;
                tempoAdicionalLabel.Text = "+ 00:00";
                ticking = true;
                tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                AddSegment();
            }
        }

        public void ClickRightStartStopMethod()
        {
            if ( !ticking )
            {
                startButton_Click( null, null );
            }
            else
            {
                endButton_Click( null, null );
            }
        }

        public void SegmentActiveButton_Click( object sender, EventArgs e )
        {
            if ( currentSegmentType == Constants.segmentTypeActive )
            {
                //do nothing
            }
            else
            {
                currentSegmentType = Constants.segmentTypeActive;
                tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                AddSegment();
            }
        }

        public void SegmentOutofBoundsButton_Click( object sender, EventArgs e )
        {
            if ( currentSegmentType == Constants.segmentTypeOutofBounds )
            {
                //do nothing
            }
            else
            {
                currentSegmentType = Constants.segmentTypeOutofBounds;
                AddSegment();
                tempoTotalLabel.BackColor = Constants.colorSegmentOutofBounds;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentOutofBounds;
            }
        }

        public void SegmentRefBlowButton_Click( object sender, EventArgs e )
        {
            if ( currentSegmentType == Constants.segmentTypeRefBlow )
            {
                //do nothing
            }
            else
            {
                currentSegmentType = Constants.segmentTypeRefBlow;
                AddSegment();
                tempoTotalLabel.BackColor = Constants.colorSegmentRefBlow;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentRefBlow;
            }
        }

        public void SegmentGoalButton_Click( object sender, EventArgs e )
        {
            if ( currentSegmentType == Constants.segmentTypeGoal )
            {
                //do nothing
            }
            else
            {
                currentSegmentType = Constants.segmentTypeGoal;
                AddSegment();
                tempoTotalLabel.BackColor = Constants.colorSegmentGoal;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentGoal;
            }
        }

        private void AddSegment()
        {
            var picture = new PictureBox
            {
                Size = new Size( 1, Constants.SegmentHeigth ),
                Location = new Point( GetXPosition(), GetYPosition() ),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add( picture );

            picture.BringToFront();

            Segment segment = new Segment();

            segment.image = picture;
            segment.segmentType = currentSegmentType;

            switch ( segment.segmentType )
            {
                case 0:
                    segment.image.BackColor = Constants.colorSegmentActive;
                    break;
                case 1:
                    segment.image.BackColor = Constants.colorSegmentOutofBounds;
                    break;
                case 2:
                    segment.image.BackColor = Constants.colorSegmentRefBlow;
                    break;
                case 3:
                    segment.image.BackColor = Constants.colorSegmentGoal;
                    break;
            }

            segments.Add( segment );
        }

        private int GetXPosition()
        {
            int result = 0;
            result = ( minutes * Constants.minuteWidth ) + ( aditionalMinutes * Constants.minuteWidth ) + GetMinX();
            return Constants.startingX + result;
        }

        private int GetMinX()
        {
            int result = (int)( seconds * Constants.secondWidth ) + (int)( aditionalSeconds * Constants.secondWidth );
            if ( result == 0 )
                return 1;
            else return result;
        }

        private int GetYPosition()
        {
            if ( half == 0 )
                return Constants.firsthalfY;
            else
                return Constants.secondhalfY;
        }

        private void TimerSecondPassed( Object myObject,
                                            EventArgs myEventArgs )
        {
            seconds++;
            if ( seconds == 60 )
            {
                seconds = 0;
                minutes++;
            }
            if ( minutes == 45 && ( half == 0 || half == 1 ) )
            {
                timerPrincipal.Stop();
                timerAdicional.Start();
                tempoAdicionalLabel.Visible = true;
            }
            if ( minutes == 15 && ( half == 2 || half == 3 ) )
            {
                timerPrincipal.Stop();
                timerAdicional.Start();
                tempoAdicionalLabel.Visible = true;
            }
            tempoTotalLabel.Text = minutes.ToString( "D2" ) + ":" + seconds.ToString( "D2" );

            segments.LastOrDefault().addSeconds();

            UpdateTotals();
        }

        private void AditionalTimerSecondPassed( Object myObject,
                                            EventArgs myEventArgs )
        {
            aditionalSeconds++;
            if ( aditionalSeconds == 60 )
            {
                aditionalSeconds = 0;
                aditionalMinutes++;
            }
            tempoAdicionalLabel.Text = "+ " + aditionalMinutes.ToString( "D2" ) + ":" + aditionalSeconds.ToString( "D2" );

            segments.LastOrDefault().addSeconds();

            UpdateTotals();
        }

        private void UpdateTotals()
        {
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
        }
    }

    static class Constants
    {
        public const int startingX = 104;
        public const int firsthalfY = 130;
        public const int secondhalfY = 355;
        public const int SegmentHeigth = 20;
        public const int minuteWidth = 15;
        public const double secondWidth = 0.25;

        public const int segmentTypeActive = 0;
        public const int segmentTypeOutofBounds = 1;
        public const int segmentTypeRefBlow = 2;
        public const int segmentTypeGoal = 3;

        public static Color colorSegmentActive = Color.SpringGreen;
        public static Color colorSegmentOutofBounds = Color.Yellow;
        public static Color colorSegmentRefBlow = Color.Salmon;
        public static Color colorSegmentGoal = Color.LightSkyBlue;
    }

    public class Segment
    {
        public PictureBox image;
        public int elapsedSeconds, elapsedMinutes;
        public int segmentType;

        public Segment()
        {
            elapsedSeconds = 0;
            elapsedMinutes = 0;
        }

        public void addSeconds()
        {
            elapsedSeconds++;
            if (elapsedSeconds == 60)
            {
                elapsedSeconds = 0;
                elapsedMinutes++;
            }
            SetWidth();
        }

        public void SetWidth()
        {
            this.image.Width = (elapsedMinutes * Constants.minuteWidth) + GetMinX();
        }

        private int GetMinX()
        {
            int result = (int)( elapsedSeconds * Constants.secondWidth );
            if ( result == 0 )
                return 1;
            else return result;
        }
    }


}
