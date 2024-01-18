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
                case 0:
                    password.equipment.card1 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 1:
                    password.equipment.card2 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 2:
                    password.equipment.card3 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 3:
                    password.equipment.card4 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 4:
                    password.equipment.card5 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 5:
                    password.equipment.card6 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 6:
                    password.equipment.card7 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 7:
                    password.equipment.card8 = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 8:
                    password.equipment.cigarettes = e.NewValue == CheckState.Checked ? true : false;
                    return;
            }
        }

        private void EquipmentCheckListB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListB.SelectedIndex)
            {
                case 0:
                    password.equipment.gasmask = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 1:
                    password.equipment.binoculars = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 2:
                    password.equipment.cardboard = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 3:
                    password.equipment.bbSuit = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 4:
                    password.equipment.uniform = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 5:
                    password.equipment.googles = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 6:
                    password.equipment.glove = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 7:
                    password.equipment.detector = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 8:
                    password.equipment.armor = e.NewValue == CheckState.Checked ? true : false;
                    return;
            }
        }

        private void EquipmentCheckListC_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListC.SelectedIndex)
            {
                case 0:
                    password.equipment.antenna = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 1:
                    password.equipment.antidote = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 2:
                    password.equipment.light = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 3:
                    password.equipment.compass = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 4:
                    password.equipment.oxygen = e.NewValue == CheckState.Checked ? true : false;
                    return;
                case 5:
                    password.equipment.transmitter = e.NewValue == CheckState.Checked ? true : false;
                    return;
            }
        }

        private void RationsCounterBox_ValueChanged(object sender, EventArgs e)
        {
            password.equipment.rations = (int)RationsCounterBox.Value;
        }
    }
}
