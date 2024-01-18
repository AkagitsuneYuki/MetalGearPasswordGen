using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGPG
{
    public partial class MainForm : Form
    {

        Password password;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            password = new Password();
        }

        private void Rank1ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(1);
        }

        private void Rank2ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(2);
        }

        private void Rank3ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(3);
        }
        private void Rank4ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(4);
        }

        private void RationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RationsCounterBox.Enabled = RationsCheckBox.Checked;
        }
    }
}
