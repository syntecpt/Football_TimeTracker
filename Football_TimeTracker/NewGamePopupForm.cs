using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_TimeTracker
{
    public partial class NewGamePopupForm : Form
    {
        public NewGamePopupForm()
        {
            InitializeComponent();
        }

        private void NewGameForm_Load( object sender, EventArgs e )
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            InterceptKeys.NewGameWindow( GameNameTextbox.Text.Trim(), CompetitionTextbox.Text.Trim(), dateTimePicker1.Value );
            this.Close();
        }

        private void GameNameTextbox_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );
            KeyPressEventArgs eargs = (KeyPressEventArgs)e;

            if( eargs.KeyChar == '\b' )
            {
                //allow backspace
            }
            else if ( regex.IsMatch( eargs.KeyChar.ToString() ) )
            {
                eargs.Handled = true;
            }
        }

        public void SetFocus()
        {
            if (GameNameTextbox.Text.Length == 0)
                GameNameTextbox.Focus();
            else if (CompetitionTextbox.Text.Length == 0)
                CompetitionTextbox.Focus();
            else button1.Focus();
        }
    }
}
