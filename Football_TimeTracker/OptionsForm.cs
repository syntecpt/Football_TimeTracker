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
                settingActive = false;
                _options.currentActiveKey = KeyCode;
                ActiveKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }
            else if (settingOutOfBounds)
            {
                settingOutOfBounds = false;
                _options.currentOutOfBoundsKey = KeyCode;
                OutOfBoundsKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }
            else if (settingRefBlow)
            {
                settingRefBlow = false;
                _options.currentRefBlowKey = KeyCode;
                RefBlowKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }
            else if (settingGoal)
            {
                settingGoal = false;
                _options.currentGoalKey = KeyCode;
                GoalKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }
            else if (settingUndo)
            {
                settingUndo = false;
                _options.currentUndoKey = KeyCode;
                UndoKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }
            else if (settingStartStop)
            {
                settingStartStop = false;
                _options.currentStartStopKey = KeyCode;
                StartStopKey.Text = InterceptKeys.GetKeyDescription( KeyCode );
            }

            settingKey = false;
            SaveKeys();
            //Console.WriteLine( "keycode " + KeyCode + " equals key: " + InterceptKeys.GetKeyDescription( KeyCode ) );
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
            ActiveKey.Text = InterceptKeys.GetKeyDescription( _options.currentActiveKey );
            OutOfBoundsKey.Text = InterceptKeys.GetKeyDescription( _options.currentOutOfBoundsKey );
            RefBlowKey.Text = InterceptKeys.GetKeyDescription( _options.currentRefBlowKey );
            GoalKey.Text = InterceptKeys.GetKeyDescription( _options.currentGoalKey );
            UndoKey.Text = InterceptKeys.GetKeyDescription( _options.currentUndoKey );
            StartStopKey.Text = InterceptKeys.GetKeyDescription( _options.currentStartStopKey );
        }

        private string GetTooltipText()
        {
            return "Evitar usar teclas de comandos. Se a tecla ficar Indefinida por favor, usar outra tecla.";
        }
    }
}
