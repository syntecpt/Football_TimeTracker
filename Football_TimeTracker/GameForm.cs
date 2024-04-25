using Newtonsoft.Json;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Football_TimeTracker
{
    public partial class GameForm : Form
    {
        Timer timerPrincipal;
        int seconds, half, currentSegmentType;
        List<Segment> segments;
        bool ticking;
        private Options _options;

        public GameForm()
        {
            InitializeComponent();
            timerPrincipal = new Timer();
            half = 0;
            timerPrincipal.Interval = 1000;
            timerPrincipal.Tick += new EventHandler( TimerSecondPassed );
            segments = new List<Segment>();
            currentSegmentType = 0;
            ticking = false;
            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";
            this.FormClosing += GameForm_FormClosing;
        }

        public GameForm(string gameName)
        {
            InitializeComponent();
            timerPrincipal = new Timer();
            half = 0;
            timerPrincipal.Interval = 1000;
            timerPrincipal.Tick += new EventHandler( TimerSecondPassed );
            segments = new List<Segment>();
            currentSegmentType = 0;
            ticking = false;
            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";
            this.Text = gameName;
            this.FormClosing += GameForm_FormClosing;
            _options = InterceptKeys.GetOptions();
            KeybindActive.Text = InterceptKeys.GetKeyDescription( _options.currentActiveKey );
            KeybindOutofBounds.Text = InterceptKeys.GetKeyDescription( _options.currentOutOfBoundsKey );
            KeybindRefBlow.Text = InterceptKeys.GetKeyDescription( _options.currentRefBlowKey );
            KeybindGoal.Text = InterceptKeys.GetKeyDescription( _options.currentGoalKey );
            KeybindUndo.Text = InterceptKeys.GetKeyDescription( _options.currentUndoKey );
            KeybindStartStop.Text = InterceptKeys.GetKeyDescription( _options.currentStartStopKey );
            saveButton.BackColor = Constants.colorDisabledButton;
            RemoveSegmentButton.Enabled = false;
            RemoveSegmentButton.BackColor = Constants.colorDisabledButton;
        }

        private void endButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.BackToMainForm();
        }

        public void startButton_Click( object sender, EventArgs e )
        {
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if ( !ticking && half == 0 )
            {
                seconds = 0;
                timerPrincipal.Start();
                tempoTotalLabel.Text = "00:00";
                tempoAdicionalLabel.Visible = false;
                tempoAdicionalLabel.Text = "+ 00:00";
                ticking = true;
                tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                currentSegmentType = Constants.segmentTypeActive;
                currentStatusLabel.ForeColor = Color.Lime;
                currentStatusLabel.Text = "1ª parte a decorrer";
                startstopButton.Text = "Terminar 1ª parte";
                resetButton.Enabled = false;
                resetButton.BackColor = Constants.colorDisabledButton;
                RemoveSegmentButton.Enabled = true;
                RemoveSegmentButton.BackColor = Constants.colorEnabledButton;
                AddSegment();
            }
            else if(ticking && half == 0)
            {
                timerPrincipal.Stop();
                half++;
                currentStatusLabel.ForeColor = Color.Khaki;
                currentStatusLabel.Text = "intervalo";
                ticking = false;
                resetButton.Enabled = true;
                resetButton.BackColor = Constants.colorEnabledButton;
                RemoveSegmentButton.Enabled = false;
                RemoveSegmentButton.BackColor = Constants.colorDisabledButton;
                startstopButton.Text = "Iniciar 2ª parte";
            }
            else if ( !ticking && half == 1 )
            {
                seconds = 0;
                timerPrincipal.Start();
                tempoTotalLabel.Text = "00:00";
                tempoAdicionalLabel.Visible = false;
                tempoAdicionalLabel.Text = "+ 00:00";
                ticking = true;
                tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                currentSegmentType = Constants.segmentTypeActive;
                currentStatusLabel.ForeColor = Color.Lime;
                currentStatusLabel.Text = "2ª parte a decorrer";
                startstopButton.Text = "Terminar 2ª parte";
                resetButton.Enabled = false;
                resetButton.BackColor = Constants.colorDisabledButton;
                RemoveSegmentButton.Enabled = true;
                RemoveSegmentButton.BackColor = Constants.colorEnabledButton;
                AddSegment();
            }
            else if ( ticking && half == 1 )
            {
                timerPrincipal.Stop();
                half++;
                currentStatusLabel.ForeColor = Color.Red;
                currentStatusLabel.Text = "jogo terminado";
                ticking = false;
                resetButton.Enabled = true;
                resetButton.BackColor = Constants.colorEnabledButton;
                startstopButton.Enabled = false;
                startstopButton.BackColor = Constants.colorDisabledButton;
                RemoveSegmentButton.Enabled = false;
                RemoveSegmentButton.BackColor = Constants.colorDisabledButton;
                saveButton.Enabled = true;
                saveButton.BackColor = Constants.colorEnabledButton;
            }
        }

        public void SegmentActiveButton_Click( object sender, EventArgs e )
        {
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if ( !ticking )
                return;

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
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if ( !ticking )
                return;

            if ( currentSegmentType == Constants.segmentTypeOutofBounds )
            {
                //do nothing
            }
            else
            {
                if ( currentSegmentType != Constants.segmentTypeActive )
                {
                    ReplaceLastSegment(Constants.segmentTypeOutofBounds);
                }
                else
                {
                    currentSegmentType = Constants.segmentTypeOutofBounds;
                    AddSegment();
                    tempoTotalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentOutofBounds;
                }
            }
        }

        public void SegmentRefBlowButton_Click( object sender, EventArgs e )
        {
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if ( !ticking )
                return;

            if ( currentSegmentType == Constants.segmentTypeRefBlow )
            {
                //do nothing
            }
            else
            {
                if ( currentSegmentType != Constants.segmentTypeActive )
                {
                    ReplaceLastSegment(Constants.segmentTypeRefBlow );
                }
                else
                {
                    currentSegmentType = Constants.segmentTypeRefBlow;
                    AddSegment();
                    tempoTotalLabel.BackColor = Constants.colorSegmentRefBlow;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentRefBlow;
                }
            }
        }

        public void SegmentGoalButton_Click( object sender, EventArgs e )
        {
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if ( !ticking )
                return;

            if ( currentSegmentType == Constants.segmentTypeGoal )
            {
                //do nothing
            }
            else
            {
                if ( currentSegmentType != Constants.segmentTypeActive )
                {
                    ReplaceLastSegment(Constants.segmentTypeGoal );
                }
                else
                {
                    currentSegmentType = Constants.segmentTypeGoal;
                    AddSegment();
                    tempoTotalLabel.BackColor = Constants.colorSegmentGoal;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentGoal;
                }
            }
        }

        public void RemoveSegmentButton_Click( object sender, EventArgs e )
        {
            currentStatusLabel.Focus(); //focus hack to prevent space/enter from triggerring buttons
            if ( sender == null && e == null && BlockKeybindingsSwitch.Checked )
            { return; }

            if(!ticking)
            { return; }

            if ( segments.Count > 1 && half==0)
            {
                RemoveSegment();
            }
            else
            {
                if ( segments.Where( x => x.half == 1 ).Count() > 1)
                {
                    RemoveSegment();
                }
            }
        }

        private void RemoveSegment()
        {
            Segment lastsegment = segments.Last();
            segments.Remove( lastsegment );
            this.Controls.Remove( lastsegment.image );
            Segment prelastsegment = segments.Last();
            prelastsegment.elapsedSeconds += lastsegment.elapsedSeconds;
            currentSegmentType = prelastsegment.segmentType;
            switch ( currentSegmentType )
            {
                case Constants.segmentTypeActive:
                    tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                    break;
                case Constants.segmentTypeOutofBounds:
                    tempoTotalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    break;
                case Constants.segmentTypeRefBlow:
                    tempoTotalLabel.BackColor = Constants.colorSegmentRefBlow;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentRefBlow;
                    break;
                case Constants.segmentTypeGoal:
                    tempoTotalLabel.BackColor = Constants.colorSegmentGoal;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentGoal;
                    break;
            }
        }

        private void ReplaceLastSegment( int segmentType)
        {
            segments.Last().segmentType = segmentType;
            currentSegmentType = segmentType;
            switch ( currentSegmentType )
            {
                case Constants.segmentTypeActive:
                    tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                    segments.Last().image.BackColor = Constants.colorSegmentActive;
                    break;
                case Constants.segmentTypeOutofBounds:
                    tempoTotalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    segments.Last().image.BackColor = Constants.colorSegmentOutofBounds;
                    break;
                case Constants.segmentTypeRefBlow:
                    tempoTotalLabel.BackColor = Constants.colorSegmentRefBlow;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentRefBlow;
                    segments.Last().image.BackColor = Constants.colorSegmentRefBlow;
                    break;
                case Constants.segmentTypeGoal:
                    tempoTotalLabel.BackColor = Constants.colorSegmentGoal;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentGoal;
                    segments.Last().image.BackColor = Constants.colorSegmentGoal;
                    break;
            }
        }

        private void AddSegment()
        {
            if (GarbageCollected())
            {
                if ( currentSegmentType == segments.Last().segmentType )
                {
                    return;
                }                
            }

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
            segment.half = half;
            segment.startingSeconds = seconds;

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

            segments.Add( segment );
        }

        private bool GarbageCollected()
        {
            if ( segments.Count > 1 )
            {
                Segment lastSegment = segments.Last();
                if (lastSegment.elapsedSeconds == 0)
                {
                    this.Controls.Remove( lastSegment.image );
                    segments.Remove( lastSegment );

                    return true;
                }
            }
            return false;
        }

        private int GetXPosition()
        {
            int result = 0;
            result = GetMinX();
            return placeholder_label.Location.X + result;
        }

        private void saveButton_Click( object sender, EventArgs e )
        {
            var path = System.IO.Directory.CreateDirectory( "saved_games" );
            string fullpath = path.Name + "\\" + this.Text + ".txt";
            JsonSerialization.WriteToJsonFile( fullpath, segments );
            saveButton.Text = "Gravado!";
            saveButton.BackColor = Color.FromArgb(64,112,69);
            saveButton.Enabled = false;
            MessageBox.Show( "Jogo Gravado", "Sucesso" );
        }

        private int GetMinX()
        {
            int result = (int)( seconds * Constants.secondWidth );
            if ( result == 0 )
                return 1;
            else return result;
        }

        private int GetYPosition()
        {
            if ( half == 0 )
                return placeholder_label.Location.Y;
            else
                return placeholder_label_bottom.Location.Y;
        }

        private void TimerSecondPassed( Object myObject,
                                            EventArgs myEventArgs )
        {
            seconds++;
            int formattedMinutes, formattedSeconds;
            formattedSeconds = seconds;
            formattedMinutes = 0;
            while ( formattedSeconds >= 60 )
            {
                formattedSeconds -= 60;
                formattedMinutes++;
            }
            if ( seconds >= Constants.minute45 ) //45 mins
            {
                tempoTotalLabel.Text = "45:00";
                formattedMinutes -= 45;
                tempoAdicionalLabel.Visible = true;
                tempoAdicionalLabel.Text = "+ " + formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            else
            {
                tempoTotalLabel.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
                tempoAdicionalLabel.Visible = false;
            }

            segments.LastOrDefault().addSeconds();

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            switch ( currentSegmentType )
            {
                case Constants.segmentTypeActive:
                    tempoTotalLabel.BackColor = Constants.colorSegmentActive;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentActive;
                    break;
                case Constants.segmentTypeOutofBounds:
                    tempoTotalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentOutofBounds;
                    break;
                case Constants.segmentTypeRefBlow:
                    tempoTotalLabel.BackColor = Constants.colorSegmentRefBlow;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentRefBlow;
                    break;
                case Constants.segmentTypeGoal:
                    tempoTotalLabel.BackColor = Constants.colorSegmentGoal;
                    tempoAdicionalLabel.BackColor = Constants.colorSegmentGoal;
                    break;
            }

            #region Text Stats
            int elapsedMinutesActive = 0;
            int elapsedMinutesOutofBounds = 0;
            int elapsedMinutesRefBlow = 0;
            int elapsedMinutesGoal = 0;

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

            int TotalMinutes = 0;
            int TotalSeconds = segments.Sum( x => x.elapsedSeconds );
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
                PieChart.Series[ 0 ].Points[ 0 ].Label = ( ( (decimal)elapsedSecondsActive / (decimal)totalSecondsElapsed ) * 100).ToString( "0.##" ) + "%";
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
            elapsedSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = segments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = segments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            double BarMinutesActive = (double)elapsedSecondsActive / 60;
            double BarMinutesOutOfBounds = (double)elapsedSecondsOutofBounds / 60;
            double BarMinutesRefBlow = (double)elapsedSecondsRefBlow / 60;
            double BarMinutesGoal = (double)elapsedSecondsGoal / 60;

            if ( BarMinutesActive > 0 )
            {
                BarChart.Series[ 0 ].Points[ 0 ].Label = BarMinutesActive.ToString("0.##");
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
            BarChart.ChartAreas[0].AxisY.Maximum = MaxYValue;
            #endregion

            #region Other Text Stats
            totalSegmentsResult.Text = segments.Count.ToString();
            int formattedMinutes, formattedSeconds;

            Segment biggestActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestActive != null )
            {
                formattedMinutes = 0;
                formattedSeconds = biggestActive.elapsedSeconds;
                while (formattedSeconds >= 60)
                {
                    formattedSeconds -= 60;
                    formattedMinutes++;
                }
                biggestActiveSegmentResult.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            Segment biggestStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
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
            
            int CountSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Count();
            if ( CountSecondsActive > 0 )
            {
                int TotalSecondsActive = segments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
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
                int TotalSecondsStopped = segments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
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
                int TotalSecondsGoal = segments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );
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

        private void GameForm_FormClosing( Object sender, FormClosingEventArgs e )
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    static class Constants
    {
        public const int SegmentHeigth = 20;
        public const double secondWidth = 0.251;

        public const int segmentTypeActive = 0;
        public const int segmentTypeOutofBounds = 1;
        public const int segmentTypeRefBlow = 2;
        public const int segmentTypeGoal = 3;

        public const int minute45 = 2700;

        public static Color colorSegmentActive = Color.SpringGreen;
        public static Color colorSegmentOutofBounds = Color.Yellow;
        public static Color colorSegmentRefBlow = Color.Salmon;
        public static Color colorSegmentGoal = Color.LightSkyBlue;

        public static Color colorBackgroundGray = Color.DimGray;
        public static Color colorDisabledButton = SystemColors.ControlDark;
        public static Color colorEnabledButton = SystemColors.Control;
    }

    public class Segment
    {
        [JsonIgnore]
        public PictureBox image;
        public int elapsedSeconds;
        public int startingSeconds;
        public int segmentType;
        public int half;

        public Segment()
        {
            elapsedSeconds = 0;
        }

        public void addSeconds()
        {
            elapsedSeconds++;
            SetWidth();
        }

        public void SetWidth()
        {
            this.image.Width = GetMinX();
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
