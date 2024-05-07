using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_TimeTracker
{
    public partial class OptionsForm : Form
    {
        private KeybindingForm _keybindingForm;
        public bool settingKey;
        private bool settingActive;
        private bool settingOutOfBounds;
        private bool settingRefBlow;
        private bool settingGoal;
        private bool settingUndo;
        private bool settingStartStop;

        private Options _options;

        public OptionsForm()
        {
            InitializeComponent();
            _keybindingForm = new KeybindingForm();
            settingActive = false;
            settingOutOfBounds = false;
            settingRefBlow = false;
            settingGoal = false;
            settingUndo = false;
            settingStartStop = false;
            _options = InterceptKeys.GetOptions();

            if (Size.Width >= Screen.FromControl( this ).Bounds.Width)
            {
                Size = new Size( Screen.FromControl( this ).Bounds.Width - 20, Size.Height ); //leave 20 pixels whynot
                CenterToScreen(); // then center
            }
        }

        private void leaveButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.CloseOptions();
        }

        private void DimScreenAndShowPopup()
        {
            this.Opacity = 0.8;
            label1.Focus();
            _keybindingForm.Show();
            _keybindingForm.Focus();
            settingKey = true;
            ActiveKey.Enabled = false;
            OutOfBoundsKey.Enabled = false;
            RefBlowKey.Enabled = false;
            GoalKey.Enabled = false;
            UndoKey.Enabled = false;
            StartStopKey.Enabled = false;
        }

        public void CloseKeybindForm(int KeyCode)
        {
            this.Opacity = 1;
            _keybindingForm.Hide();
            this.Show();
            this.Focus();
            label1.Focus();
            ActiveKey.Enabled = true;
            OutOfBoundsKey.Enabled = true;
            RefBlowKey.Enabled = true;
            GoalKey.Enabled = true;
            UndoKey.Enabled = true;
            StartStopKey.Enabled = true;

            if(settingActive)
            {
                //unbind other keys
                if (_options.currentOutOfBoundsKey == KeyCode)
                    _options.currentOutOfBoundsKey = 0;
                if(_options.currentRefBlowKey == KeyCode)
                    _options.currentRefBlowKey = 0;
                if (_options.currentGoalKey == KeyCode)
                    _options.currentGoalKey = 0;
                if (_options.currentUndoKey == KeyCode)
                    _options.currentUndoKey = 0;
                if (_options.currentStartStopKey == KeyCode)
                    _options.currentStartStopKey = 0;
                
                settingActive = false;
                _options.currentActiveKey = KeyCode;
                
            }
            else if (settingOutOfBounds)
            {
                //unbind other keys
                if (_options.currentActiveKey == KeyCode)
                    _options.currentActiveKey= 0;
                if (_options.currentRefBlowKey == KeyCode)
                    _options.currentRefBlowKey = 0;
                if (_options.currentGoalKey == KeyCode)
                    _options.currentGoalKey = 0;
                if (_options.currentUndoKey == KeyCode)
                    _options.currentUndoKey = 0;
                if (_options.currentStartStopKey == KeyCode)
                    _options.currentStartStopKey = 0;

                settingOutOfBounds = false;
                _options.currentOutOfBoundsKey = KeyCode;
                
            }
            else if (settingRefBlow)
            {
                //unbind other keys
                if (_options.currentActiveKey == KeyCode)
                    _options.currentActiveKey = 0;
                if (_options.currentOutOfBoundsKey == KeyCode)
                    _options.currentOutOfBoundsKey = 0;
                if (_options.currentGoalKey == KeyCode)
                    _options.currentGoalKey = 0;
                if (_options.currentUndoKey == KeyCode)
                    _options.currentUndoKey = 0;
                if (_options.currentStartStopKey == KeyCode)
                    _options.currentStartStopKey = 0;

                settingRefBlow = false;
                _options.currentRefBlowKey = KeyCode;
                
            }
            else if (settingGoal)
            {
                //unbind other keys
                if (_options.currentActiveKey == KeyCode)
                    _options.currentActiveKey = 0;
                if (_options.currentOutOfBoundsKey == KeyCode)
                    _options.currentOutOfBoundsKey = 0;
                if (_options.currentRefBlowKey == KeyCode)
                    _options.currentRefBlowKey = 0;
                if (_options.currentUndoKey == KeyCode)
                    _options.currentUndoKey = 0;
                if (_options.currentStartStopKey == KeyCode)
                    _options.currentStartStopKey = 0;

                settingGoal = false;
                _options.currentGoalKey = KeyCode;
                
            }
            else if (settingUndo)
            {
                //unbind other keys
                if (_options.currentActiveKey == KeyCode)
                    _options.currentActiveKey = 0;
                if (_options.currentOutOfBoundsKey == KeyCode)
                    _options.currentOutOfBoundsKey = 0;
                if (_options.currentRefBlowKey == KeyCode)
                    _options.currentRefBlowKey = 0;
                if (_options.currentGoalKey == KeyCode)
                    _options.currentGoalKey = 0;
                if (_options.currentStartStopKey == KeyCode)
                    _options.currentStartStopKey = 0;

                settingUndo = false;
                _options.currentUndoKey = KeyCode;
                
            }
            else if (settingStartStop)
            {
                //unbind other keys
                if (_options.currentActiveKey == KeyCode)
                    _options.currentActiveKey = 0;
                if (_options.currentOutOfBoundsKey == KeyCode)
                    _options.currentOutOfBoundsKey = 0;
                if (_options.currentRefBlowKey == KeyCode)
                    _options.currentRefBlowKey = 0;
                if (_options.currentGoalKey == KeyCode)
                    _options.currentGoalKey = 0;
                if (_options.currentUndoKey == KeyCode)
                    _options.currentUndoKey = 0;

                settingStartStop = false;
                _options.currentStartStopKey = KeyCode;
                
            }

            settingKey = false;
            ResetKeyDescriptions();
            SaveKeys();
            //Console.WriteLine( "keycode " + KeyCode + " equals key: " + InterceptKeys.GetKeyDescription( KeyCode ) );
        }

        private void ResetKeyDescriptions()
        {
            ActiveKey.Text = InterceptKeys.GetKeyDescription( _options.currentActiveKey );
            OutOfBoundsKey.Text = InterceptKeys.GetKeyDescription( _options.currentOutOfBoundsKey );
            RefBlowKey.Text = InterceptKeys.GetKeyDescription( _options.currentRefBlowKey );
            GoalKey.Text = InterceptKeys.GetKeyDescription( _options.currentGoalKey );
            UndoKey.Text = InterceptKeys.GetKeyDescription( _options.currentUndoKey );
            StartStopKey.Text = InterceptKeys.GetKeyDescription( _options.currentStartStopKey );
        }

        private void SaveKeys()
        {
            var path = System.IO.Directory.GetCurrentDirectory();
            string fullpath = path + "\\options.txt";
            JsonSerialization.WriteToJsonFile( fullpath, _options );
        }

        private void ActiveKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingActive = true;
        }

        private void OutOfBoundsKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingOutOfBounds = true;
        }

        private void RefBlowKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingRefBlow = true;
        }

        private void GoalKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingGoal = true;
        }

        private void UndoKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingUndo = true;
        }

        private void StartStopKey_Click( object sender, EventArgs e )
        {
            DimScreenAndShowPopup();
            settingStartStop = true;
        }

        private void OptionsForm_Load( object sender, EventArgs e )
        {
            toolTip1.SetToolTip( label1, GetTooltipText() );
            toolTip1.SetToolTip( label8, GetTooltipText() );
            ResetKeyDescriptions();
        }

        private string GetTooltipText()
        {
            return "Evitar usar teclas de comandos. Se a tecla ficar Indefinida por favor, usar outra tecla.";
        }
    }
}
