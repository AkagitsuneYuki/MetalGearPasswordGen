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
            password.equipment.ration = RationsCheckBox.Checked;
        }

        private void EquipmentCheckListA_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListA.SelectedIndex)
            {
                //card1
                case 0:
                    password.equipment.card1 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card2
                case 1:
                    password.equipment.card2 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card3
                case 2:
                    password.equipment.card3 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card4
                case 3:
                    password.equipment.card4 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card5
                case 4:
                    password.equipment.card5 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card6
                case 5:
                    password.equipment.card6 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card7
                case 6:
                    password.equipment.card7 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //card8
                case 7:
                    password.equipment.card8 = (e.NewValue == CheckState.Checked ? true : false);
                    return;
                //cigarettes
                case 8:
                    password.equipment.cigarettes = (e.NewValue == CheckState.Checked ? true : false);
                    return;
            }
        }
    }
}
