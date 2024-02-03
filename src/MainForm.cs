using System;
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
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void Rank2ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(2);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void Rank3ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(3);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        private void Rank4ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(4);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        #endregion

        #region Equipment
        private void RationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RationsCounterBox.Enabled = RationsCheckBox.Checked;
            password.equipment.ration = RationsCheckBox.Checked;
            password.equipment.rations = RationsCheckBox.Checked ? (int)RationsCounterBox.Value : 0;
            if (autoGenerate)
            {
                SetPasswordText();
            }
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
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void EquipmentCheckListA_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListA.ClearSelected();
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void EquipmentCheckListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListB.ClearSelected();
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void EquipmentCheckListC_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListC.ClearSelected();
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        #endregion

        #region Weapons
        private void HandGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.HandGun, HandGunBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.HandGun, HandGunBox.Checked ? (int)HandGunRoundsBox.Value : 0);
            HandGunRoundsBox.Enabled = HandGunBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MinesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Mines, MinesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Mines, MinesBox.Checked ? (int)MinesCountBox.Value : 0);
            MinesCountBox.Enabled = MinesBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void ExplosivesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Explosives, ExplosivesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Explosives, ExplosivesBox.Checked ? (int)ExplosivesCountBox.Value : 0);
            ExplosivesCountBox.Enabled = ExplosivesBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MissilesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Missiles, MissilesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Missiles, MissilesBox.Checked ? (int)MissilesCountBox.Value : 0);
            MissilesCountBox.Enabled = MissilesBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MachineGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.MachineGun, MachineGunBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.MachineGun, MachineGunBox.Checked ? (int)MachineGunCountBox.Value : 0);
            MachineGunCountBox.Enabled = MachineGunBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void GrenadeBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Grenades, GrenadeBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Grenades, GrenadeBox.Checked ? (int)GrenadeCountBox.Value : 0);
            GrenadeCountBox.Enabled = GrenadeBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void RocketBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Rockets, RocketBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Rockets, RocketBox.Checked ? (int)RocketCountBox.Value : 0);
            RocketCountBox.Enabled = RocketBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void SilencerBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Silencer, SilencerBox.Checked);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void HandGunRoundsBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.HandGun, (int)HandGunRoundsBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MinesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Mines, (int)MinesCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void ExplosivesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Explosives, (int)ExplosivesCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MissilesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Missiles, (int)MissilesCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void MachineGunCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.MachineGun, (int)MachineGunCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void GrenadeCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Grenades, (int)GrenadeCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void RocketCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Rockets, (int)RocketCountBox.Value);
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        #endregion

        #region Prisoners
        private void PrisonerCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrisonerCheckList.ClearSelected();
            if (autoGenerate)
            {
                SetPasswordText();
            }
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
            if (autoGenerate)
            {
                SetPasswordText();
            }
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
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void RecoverGearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            password.events.recovered = RecoverGearCheckBox.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        #endregion

        #region Unknowns

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.unknowns.word2letter1bit5 = word2letter1bit5.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void word2letter5bit1_CheckedChanged(object sender, EventArgs e)
        {
            password.unknowns.word2letter5bit1 = word2letter5bit1.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void unk_DrainHP_CheckedChanged(object sender, EventArgs e)
        {
            password.unknowns.unk_DrainHP = unk_DrainHP.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        private void word5letter1bit3_CheckedChanged(object sender, EventArgs e)
        {
            password.unknowns.word5letter1bit3 = word5letter1bit3.Checked;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

        #endregion

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SetPasswordText();
        }

        private void AutogenButton_CheckedChanged(object sender, EventArgs e)
        {
            autoGenerate = AutogenButton.Checked;
            GenerateButton.Enabled = !autoGenerate;
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }

    }
}
