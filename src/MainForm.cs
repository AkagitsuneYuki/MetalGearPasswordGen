﻿using System;
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
        bool autoGenerate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            password = new Password();
            autoGenerate = false;
            //set cigarettes to true
            EquipmentCheckListA.SetItemChecked(8, true);
            SetPasswordText();
        }

        private void SetPasswordText()
        {
            PasswordTextBox.Text = password.GeneratePassword();
        }

        #region Rank
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
        #endregion

        #region Equipment
        private void RationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RationsCounterBox.Enabled = RationsCheckBox.Checked;
            password.equipment.ration = RationsCheckBox.Checked;
            password.equipment.rations = RationsCheckBox.Checked ? (int)RationsCounterBox.Value : 0;
        }

        private void EquipmentCheckListA_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListA.SelectedIndex)
            {
                case 0:
                    password.equipment.card1 = e.NewValue == CheckState.Checked;
                    return;
                case 1:
                    password.equipment.card2 = e.NewValue == CheckState.Checked;
                    return;
                case 2:
                    password.equipment.card3 = e.NewValue == CheckState.Checked;
                    return;
                case 3:
                    password.equipment.card4 = e.NewValue == CheckState.Checked;
                    return;
                case 4:
                    password.equipment.card5 = e.NewValue == CheckState.Checked;
                    return;
                case 5:
                    password.equipment.card6 = e.NewValue == CheckState.Checked;
                    return;
                case 6:
                    password.equipment.card7 = e.NewValue == CheckState.Checked;
                    return;
                case 7:
                    password.equipment.card8 = e.NewValue == CheckState.Checked;
                    return;
                case 8:
                    password.equipment.cigarettes = e.NewValue == CheckState.Checked;
                    return;
            }
        }

        private void EquipmentCheckListB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListB.SelectedIndex)
            {
                case 0:
                    password.equipment.gasmask = e.NewValue == CheckState.Checked;
                    return;
                case 1:
                    password.equipment.binoculars = e.NewValue == CheckState.Checked;
                    return;
                case 2:
                    password.equipment.cardboard = e.NewValue == CheckState.Checked;
                    return;
                case 3:
                    password.equipment.bbSuit = e.NewValue == CheckState.Checked;
                    return;
                case 4:
                    password.equipment.uniform = e.NewValue == CheckState.Checked;
                    return;
                case 5:
                    password.equipment.googles = e.NewValue == CheckState.Checked;
                    return;
                case 6:
                    password.equipment.glove = e.NewValue == CheckState.Checked;
                    return;
                case 7:
                    password.equipment.detector = e.NewValue == CheckState.Checked;
                    return;
                case 8:
                    password.equipment.armor = e.NewValue == CheckState.Checked;
                    return;
            }
        }

        private void EquipmentCheckListC_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (EquipmentCheckListC.SelectedIndex)
            {
                case 0:
                    password.equipment.antenna = e.NewValue == CheckState.Checked;
                    return;
                case 1:
                    password.equipment.antidote = e.NewValue == CheckState.Checked;
                    return;
                case 2:
                    password.equipment.light = e.NewValue == CheckState.Checked;
                    return;
                case 3:
                    password.equipment.compass = e.NewValue == CheckState.Checked;
                    return;
                case 4:
                    password.equipment.oxygen = e.NewValue == CheckState.Checked;
                    return;
                case 5:
                    password.equipment.transmitter = e.NewValue == CheckState.Checked;
                    return;
            }
        }

        private void RationsCounterBox_ValueChanged(object sender, EventArgs e)
        {
            password.equipment.rations = (int)RationsCounterBox.Value;
        }

        private void EquipmentCheckListA_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListA.ClearSelected();
        }

        private void EquipmentCheckListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListB.ClearSelected();
        }

        private void EquipmentCheckListC_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListC.ClearSelected();
        }
        #endregion

        #region Weapons
        private void HandGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.HandGun, HandGunBox.Checked);
        }

        private void MinesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Mines, MinesBox.Checked);
        }

        private void ExplosivesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Explosives, ExplosivesBox.Checked);
        }

        private void MissilesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Missiles, MissilesBox.Checked);
        }

        private void MachineGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.MachineGun, MachineGunBox.Checked);
        }

        private void GrenadeBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Grenades, GrenadeBox.Checked);
        }

        private void RocketBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Rockets, RocketBox.Checked);
        }

        private void SilencerBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Silencer, SilencerBox.Checked);
        }

        private void HandGunRoundsBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.HandGun, (int)HandGunRoundsBox.Value);
        }

        private void MinesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Mines, (int)MinesCountBox.Value);
        }

        private void ExplosivesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Explosives, (int)ExplosivesCountBox.Value);
        }

        private void MissilesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Missiles, (int)MissilesCountBox.Value);
        }

        private void MachineGunCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.MachineGun, (int)MachineGunCountBox.Value);
        }

        private void GrenadeCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Grenades, (int)GrenadeCountBox.Value);
        }

        private void RocketCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Rockets, (int)RocketCountBox.Value);
        }
        #endregion

        #region Prisoners
        private void PrisonerCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrisonerCheckList.ClearSelected();
        }

        private void PrisonerCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            password.prisoners[PrisonerCheckList.SelectedIndex] = e.NewValue == CheckState.Checked;
        }
        #endregion

        #region Bosses

        private void BossCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BossCheckList.ClearSelected();
        }

        private void BossCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            password.bosses[BossCheckList.SelectedIndex] = e.NewValue == CheckState.Checked;
        }

        #endregion

        #region Events
        private void CapturedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            password.events.captured = CapturedCheckBox.Checked;
        }

        private void RecoverGearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            password.events.recovered = RecoverGearCheckBox.Checked;
        }
        #endregion

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SetPasswordText();
        }
    }
}
