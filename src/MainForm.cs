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
            //thinking of setting to true in the future
            autoGenerate = false;
            //set cigarettes to true
            EquipmentCheckListA.SetItemChecked(8, true);
            SetPasswordText();
        }

        /// <summary>
        /// Sets the text in the password box to a new generated password.
        /// </summary>
        private void SetPasswordText()
        {
            PasswordTextBox.Text = password.GeneratePassword();
        }

        #region Rank
        private void Rank1ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(1);
            AutoGenerate();
        }

        private void Rank2ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(2);
            AutoGenerate();
        }

        private void Rank3ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(3);
            AutoGenerate();
        }
        private void Rank4ButtonClicked(object sender, EventArgs e)
        {
            password.SetRank(4);
            AutoGenerate();
        }
        #endregion

        #region Equipment
        private void RationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RationsCounterBox.Enabled = RationsCheckBox.Checked;
            password.equipment.ration = RationsCheckBox.Checked;
            password.equipment.rations = RationsCheckBox.Checked ? (int)RationsCounterBox.Value : 0;
            AutoGenerate();
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
            AutoGenerate();
        }

        private void EquipmentCheckListA_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListA.ClearSelected();
            AutoGenerate();
        }

        private void EquipmentCheckListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListB.ClearSelected();
            AutoGenerate();
        }

        private void EquipmentCheckListC_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckListC.ClearSelected();
            AutoGenerate();
        }

        //Dummy Rations
        private void word2letter5bit1_CheckedChanged(object sender, EventArgs e)
        {
            password.equipment.dummyRations = word2letter5bit1.Checked;
            AutoGenerate();
        }
        #endregion

        #region Weapons
        private void HandGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.HandGun, HandGunBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.HandGun, HandGunBox.Checked ? (int)HandGunRoundsBox.Value : 0);
            HandGunRoundsBox.Enabled = HandGunBox.Checked;
            AutoGenerate();
        }

        private void MinesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Mines, MinesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Mines, MinesBox.Checked ? (int)MinesCountBox.Value : 0);
            MinesCountBox.Enabled = MinesBox.Checked;
            AutoGenerate();
        }

        private void ExplosivesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Explosives, ExplosivesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Explosives, ExplosivesBox.Checked ? (int)ExplosivesCountBox.Value : 0);
            ExplosivesCountBox.Enabled = ExplosivesBox.Checked;
            AutoGenerate();
        }

        private void MissilesBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Missiles, MissilesBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Missiles, MissilesBox.Checked ? (int)MissilesCountBox.Value : 0);
            MissilesCountBox.Enabled = MissilesBox.Checked;
            AutoGenerate();
        }

        private void MachineGunBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.MachineGun, MachineGunBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.MachineGun, MachineGunBox.Checked ? (int)MachineGunCountBox.Value : 0);
            MachineGunCountBox.Enabled = MachineGunBox.Checked;
            AutoGenerate();
        }

        private void GrenadeBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Grenades, GrenadeBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Grenades, GrenadeBox.Checked ? (int)GrenadeCountBox.Value : 0);
            GrenadeCountBox.Enabled = GrenadeBox.Checked;
            AutoGenerate();
        }

        private void RocketBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Rockets, RocketBox.Checked);
            password.SetWeaponAmmoCount((int)Password.WeaponID.Rockets, RocketBox.Checked ? (int)RocketCountBox.Value : 0);
            RocketCountBox.Enabled = RocketBox.Checked;
            AutoGenerate();
        }

        private void SilencerBox_CheckedChanged(object sender, EventArgs e)
        {
            password.SetWeaponObtained((int)Password.WeaponID.Silencer, SilencerBox.Checked);
            AutoGenerate();
        }

        private void HandGunRoundsBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.HandGun, (int)HandGunRoundsBox.Value);
            AutoGenerate();
        }

        private void MinesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Mines, (int)MinesCountBox.Value);
            AutoGenerate();
        }

        private void ExplosivesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Explosives, (int)ExplosivesCountBox.Value);
            AutoGenerate();
        }

        private void MissilesCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Missiles, (int)MissilesCountBox.Value);
            AutoGenerate();
        }

        private void MachineGunCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.MachineGun, (int)MachineGunCountBox.Value);
            AutoGenerate();
        }

        private void GrenadeCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Grenades, (int)GrenadeCountBox.Value);
            AutoGenerate();
        }

        private void RocketCountBox_ValueChanged(object sender, EventArgs e)
        {
            password.SetWeaponAmmoCount((int)Password.WeaponID.Rockets, (int)RocketCountBox.Value);
            AutoGenerate();
        }
        #endregion

        #region Prisoners
        private void PrisonerCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrisonerCheckList.ClearSelected();
            AutoGenerate();
        }

        private void PrisonerCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            password.prisoners[PrisonerCheckList.SelectedIndex] = e.NewValue == CheckState.Checked;
        }

        //Fake Pettrovich
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.fakePettrovich = word2letter1bit5.Checked;
            AutoGenerate();
        }

        //Unknown Prisoner
        private void word5letter1bit3_CheckedChanged(object sender, EventArgs e)
        {
            password.unknownPrisoner = word5letter1bit3.Checked;
            AutoGenerate();
        }
        #endregion

        #region Bosses
        private void BossCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BossCheckList.ClearSelected();
            AutoGenerate();
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
            AutoGenerate();
        }

        private void RecoverGearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            password.events.recovered = RecoverGearCheckBox.Checked;
            AutoGenerate();
        }

        //Poisoned
        private void unk_DrainHP_CheckedChanged(object sender, EventArgs e)
        {
            password.events.poisoned = unk_DrainHP.Checked;
            AutoGenerate();
        }
        #endregion

        #region Generation
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SetPasswordText();
        }

        private void AutogenButton_CheckedChanged(object sender, EventArgs e)
        {
            autoGenerate = AutogenButton.Checked;
            GenerateButton.Enabled = !autoGenerate;
            AutoGenerate();
        }

        /// <summary>
        /// Generates a new password if the autoGenerate variable is true.
        /// </summary>
        private void AutoGenerate()
        {
            if (autoGenerate)
            {
                SetPasswordText();
            }
        }
        #endregion
    }
}
