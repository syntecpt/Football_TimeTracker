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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void NewGameButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.NewGamePopup();
        }

        private void LoadGameButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.HistoryShow();
        }

        private void StartForm_Load( object sender, EventArgs e )
        {

        }
    }
}
