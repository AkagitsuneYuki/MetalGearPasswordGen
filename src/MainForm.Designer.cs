using System;

namespace MGPG
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.EquipmentBox = new System.Windows.Forms.GroupBox();
            this.RationsCounterBox = new System.Windows.Forms.NumericUpDown();
            this.RationsCheckBox = new System.Windows.Forms.CheckBox();
            this.EquipmentCheckListC = new System.Windows.Forms.CheckedListBox();
            this.EquipmentCheckListB = new System.Windows.Forms.CheckedListBox();
            this.EquipmentCheckListA = new System.Windows.Forms.CheckedListBox();
            this.WeaponsBox = new System.Windows.Forms.GroupBox();
            this.AmmoCountLabel = new System.Windows.Forms.Label();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.RocketCountBox = new System.Windows.Forms.NumericUpDown();
            this.GrenadeCountBox = new System.Windows.Forms.NumericUpDown();
            this.MachineGunCountBox = new System.Windows.Forms.NumericUpDown();
            this.MissilesCountBox = new System.Windows.Forms.NumericUpDown();
            this.ExplosivesCountBox = new System.Windows.Forms.NumericUpDown();
            this.MinesCountBox = new System.Windows.Forms.NumericUpDown();
            this.SilencerBox = new System.Windows.Forms.CheckBox();
            this.RocketBox = new System.Windows.Forms.CheckBox();
            this.GrenadeBox = new System.Windows.Forms.CheckBox();
            this.MachineGunBox = new System.Windows.Forms.CheckBox();
            this.MissilesBox = new System.Windows.Forms.CheckBox();
            this.ExplosivesBox = new System.Windows.Forms.CheckBox();
            this.MinesBox = new System.Windows.Forms.CheckBox();
            this.HandGunRoundsBox = new System.Windows.Forms.NumericUpDown();
            this.HandGunBox = new System.Windows.Forms.CheckBox();
            this.RankBox = new System.Windows.Forms.GroupBox();
            this.Rank1Button = new System.Windows.Forms.RadioButton();
            this.Rank4Button = new System.Windows.Forms.RadioButton();
            this.Rank2Button = new System.Windows.Forms.RadioButton();
            this.Rank3Button = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataTabs.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            this.EquipmentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RationsCounterBox)).BeginInit();
            this.WeaponsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RocketCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrenadeCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineGunCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissilesCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosivesCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinesCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandGunRoundsBox)).BeginInit();
            this.RankBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTabs
            // 
            this.DataTabs.Controls.Add(this.ItemsTab);
            this.DataTabs.Controls.Add(this.tabPage2);
            this.DataTabs.Location = new System.Drawing.Point(0, 0);
            this.DataTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(499, 255);
            this.DataTabs.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.EquipmentBox);
            this.ItemsTab.Controls.Add(this.WeaponsBox);
            this.ItemsTab.Controls.Add(this.RankBox);
            this.ItemsTab.Location = new System.Drawing.Point(4, 22);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(2);
            this.ItemsTab.Size = new System.Drawing.Size(491, 229);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.Text = "Snake";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentBox
            // 
            this.EquipmentBox.Controls.Add(this.RationsCounterBox);
            this.EquipmentBox.Controls.Add(this.RationsCheckBox);
            this.EquipmentBox.Controls.Add(this.EquipmentCheckListC);
            this.EquipmentBox.Controls.Add(this.EquipmentCheckListB);
            this.EquipmentBox.Controls.Add(this.EquipmentCheckListA);
            this.EquipmentBox.Location = new System.Drawing.Point(234, 6);
            this.EquipmentBox.Name = "EquipmentBox";
            this.EquipmentBox.Size = new System.Drawing.Size(250, 162);
            this.EquipmentBox.TabIndex = 6;
            this.EquipmentBox.TabStop = false;
            this.EquipmentBox.Text = "Equipment";
            // 
            // RationsCounterBox
            // 
            this.RationsCounterBox.Enabled = false;
            this.RationsCounterBox.Location = new System.Drawing.Point(206, 112);
            this.RationsCounterBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RationsCounterBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RationsCounterBox.Name = "RationsCounterBox";
            this.RationsCounterBox.Size = new System.Drawing.Size(34, 20);
            this.RationsCounterBox.TabIndex = 4;
            this.RationsCounterBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // RationsCheckBox
            // 
            this.RationsCheckBox.AutoSize = true;
            this.RationsCheckBox.Location = new System.Drawing.Point(148, 113);
            this.RationsCheckBox.Name = "RationsCheckBox";
            this.RationsCheckBox.Size = new System.Drawing.Size(62, 17);
            this.RationsCheckBox.TabIndex = 3;
            this.RationsCheckBox.Text = "Rations";
            this.RationsCheckBox.UseVisualStyleBackColor = true;
            this.RationsCheckBox.CheckedChanged += new System.EventHandler(this.RationsCheckBox_CheckedChanged);
            // 
            // EquipmentCheckListC
            // 
            this.EquipmentCheckListC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquipmentCheckListC.CheckOnClick = true;
            this.EquipmentCheckListC.FormattingEnabled = true;
            this.EquipmentCheckListC.Items.AddRange(new object[] {
            "Antenna",
            "Antidote",
            "Light",
            "Compass",
            "Oxygen",
            "Transmitter"});
            this.EquipmentCheckListC.Location = new System.Drawing.Point(147, 14);
            this.EquipmentCheckListC.Name = "EquipmentCheckListC";
            this.EquipmentCheckListC.Size = new System.Drawing.Size(76, 105);
            this.EquipmentCheckListC.TabIndex = 2;
            this.EquipmentCheckListC.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EquipmentCheckListC_ItemCheck);
            // 
            // EquipmentCheckListB
            // 
            this.EquipmentCheckListB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquipmentCheckListB.CheckOnClick = true;
            this.EquipmentCheckListB.FormattingEnabled = true;
            this.EquipmentCheckListB.Items.AddRange(new object[] {
            "Gasmask",
            "Binoculars",
            "Cardboard",
            "B.B. Suit",
            "Uniform",
            "Goggles",
            "Glove",
            "Detector",
            "Armor"});
            this.EquipmentCheckListB.Location = new System.Drawing.Point(74, 14);
            this.EquipmentCheckListB.Name = "EquipmentCheckListB";
            this.EquipmentCheckListB.Size = new System.Drawing.Size(76, 135);
            this.EquipmentCheckListB.TabIndex = 1;
            this.EquipmentCheckListB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EquipmentCheckListB_ItemCheck);
            // 
            // EquipmentCheckListA
            // 
            this.EquipmentCheckListA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquipmentCheckListA.CheckOnClick = true;
            this.EquipmentCheckListA.FormattingEnabled = true;
            this.EquipmentCheckListA.Items.AddRange(new object[] {
            "Card1",
            "Card2",
            "Card3",
            "Card4",
            "Card5",
            "Card6",
            "Card7",
            "Card8",
            "Cigarettes"});
            this.EquipmentCheckListA.Location = new System.Drawing.Point(7, 14);
            this.EquipmentCheckListA.Name = "EquipmentCheckListA";
            this.EquipmentCheckListA.Size = new System.Drawing.Size(76, 135);
            this.EquipmentCheckListA.TabIndex = 0;
            this.EquipmentCheckListA.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EquipmentCheckListA_ItemCheck);
            // 
            // WeaponsBox
            // 
            this.WeaponsBox.Controls.Add(this.AmmoCountLabel);
            this.WeaponsBox.Controls.Add(this.WeaponLabel);
            this.WeaponsBox.Controls.Add(this.RocketCountBox);
            this.WeaponsBox.Controls.Add(this.GrenadeCountBox);
            this.WeaponsBox.Controls.Add(this.MachineGunCountBox);
            this.WeaponsBox.Controls.Add(this.MissilesCountBox);
            this.WeaponsBox.Controls.Add(this.ExplosivesCountBox);
            this.WeaponsBox.Controls.Add(this.MinesCountBox);
            this.WeaponsBox.Controls.Add(this.SilencerBox);
            this.WeaponsBox.Controls.Add(this.RocketBox);
            this.WeaponsBox.Controls.Add(this.GrenadeBox);
            this.WeaponsBox.Controls.Add(this.MachineGunBox);
            this.WeaponsBox.Controls.Add(this.MissilesBox);
            this.WeaponsBox.Controls.Add(this.ExplosivesBox);
            this.WeaponsBox.Controls.Add(this.MinesBox);
            this.WeaponsBox.Controls.Add(this.HandGunRoundsBox);
            this.WeaponsBox.Controls.Add(this.HandGunBox);
            this.WeaponsBox.Location = new System.Drawing.Point(62, 5);
            this.WeaponsBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeaponsBox.Name = "WeaponsBox";
            this.WeaponsBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeaponsBox.Size = new System.Drawing.Size(166, 215);
            this.WeaponsBox.TabIndex = 5;
            this.WeaponsBox.TabStop = false;
            this.WeaponsBox.Text = "Weapons";
            // 
            // AmmoCountLabel
            // 
            this.AmmoCountLabel.AutoSize = true;
            this.AmmoCountLabel.Location = new System.Drawing.Point(117, 15);
            this.AmmoCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AmmoCountLabel.Name = "AmmoCountLabel";
            this.AmmoCountLabel.Size = new System.Drawing.Size(36, 13);
            this.AmmoCountLabel.TabIndex = 19;
            this.AmmoCountLabel.Text = "Ammo";
            this.AmmoCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.AutoSize = true;
            this.WeaponLabel.Location = new System.Drawing.Point(21, 15);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(48, 13);
            this.WeaponLabel.TabIndex = 18;
            this.WeaponLabel.Text = "Weapon";
            this.WeaponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RocketCountBox
            // 
            this.RocketCountBox.Location = new System.Drawing.Point(115, 169);
            this.RocketCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.RocketCountBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RocketCountBox.Name = "RocketCountBox";
            this.RocketCountBox.Size = new System.Drawing.Size(40, 20);
            this.RocketCountBox.TabIndex = 17;
            this.RocketCountBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // GrenadeCountBox
            // 
            this.GrenadeCountBox.Location = new System.Drawing.Point(115, 145);
            this.GrenadeCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.GrenadeCountBox.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.GrenadeCountBox.Name = "GrenadeCountBox";
            this.GrenadeCountBox.Size = new System.Drawing.Size(40, 20);
            this.GrenadeCountBox.TabIndex = 16;
            this.GrenadeCountBox.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // MachineGunCountBox
            // 
            this.MachineGunCountBox.Location = new System.Drawing.Point(115, 123);
            this.MachineGunCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.MachineGunCountBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MachineGunCountBox.Name = "MachineGunCountBox";
            this.MachineGunCountBox.Size = new System.Drawing.Size(40, 20);
            this.MachineGunCountBox.TabIndex = 15;
            this.MachineGunCountBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // MissilesCountBox
            // 
            this.MissilesCountBox.Location = new System.Drawing.Point(115, 99);
            this.MissilesCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.MissilesCountBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MissilesCountBox.Name = "MissilesCountBox";
            this.MissilesCountBox.Size = new System.Drawing.Size(40, 20);
            this.MissilesCountBox.TabIndex = 14;
            this.MissilesCountBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ExplosivesCountBox
            // 
            this.ExplosivesCountBox.Location = new System.Drawing.Point(115, 77);
            this.ExplosivesCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExplosivesCountBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ExplosivesCountBox.Name = "ExplosivesCountBox";
            this.ExplosivesCountBox.Size = new System.Drawing.Size(40, 20);
            this.ExplosivesCountBox.TabIndex = 13;
            this.ExplosivesCountBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MinesCountBox
            // 
            this.MinesCountBox.Location = new System.Drawing.Point(115, 53);
            this.MinesCountBox.Margin = new System.Windows.Forms.Padding(2);
            this.MinesCountBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MinesCountBox.Name = "MinesCountBox";
            this.MinesCountBox.Size = new System.Drawing.Size(40, 20);
            this.MinesCountBox.TabIndex = 12;
            this.MinesCountBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // SilencerBox
            // 
            this.SilencerBox.AutoSize = true;
            this.SilencerBox.Location = new System.Drawing.Point(5, 192);
            this.SilencerBox.Name = "SilencerBox";
            this.SilencerBox.Size = new System.Drawing.Size(64, 17);
            this.SilencerBox.TabIndex = 11;
            this.SilencerBox.Text = "Silencer";
            this.SilencerBox.UseVisualStyleBackColor = true;
            // 
            // RocketBox
            // 
            this.RocketBox.AutoSize = true;
            this.RocketBox.Location = new System.Drawing.Point(5, 169);
            this.RocketBox.Name = "RocketBox";
            this.RocketBox.Size = new System.Drawing.Size(109, 17);
            this.RocketBox.TabIndex = 10;
            this.RocketBox.Text = "Rocket Launcher";
            this.RocketBox.UseVisualStyleBackColor = true;
            // 
            // GrenadeBox
            // 
            this.GrenadeBox.AutoSize = true;
            this.GrenadeBox.Location = new System.Drawing.Point(5, 146);
            this.GrenadeBox.Name = "GrenadeBox";
            this.GrenadeBox.Size = new System.Drawing.Size(115, 17);
            this.GrenadeBox.TabIndex = 9;
            this.GrenadeBox.Text = "Grenade Launcher";
            this.GrenadeBox.UseVisualStyleBackColor = true;
            // 
            // MachineGunBox
            // 
            this.MachineGunBox.AutoSize = true;
            this.MachineGunBox.Location = new System.Drawing.Point(5, 123);
            this.MachineGunBox.Name = "MachineGunBox";
            this.MachineGunBox.Size = new System.Drawing.Size(90, 17);
            this.MachineGunBox.TabIndex = 8;
            this.MachineGunBox.Text = "Machine Gun";
            this.MachineGunBox.UseVisualStyleBackColor = true;
            // 
            // MissilesBox
            // 
            this.MissilesBox.AutoSize = true;
            this.MissilesBox.Location = new System.Drawing.Point(5, 100);
            this.MissilesBox.Name = "MissilesBox";
            this.MissilesBox.Size = new System.Drawing.Size(62, 17);
            this.MissilesBox.TabIndex = 7;
            this.MissilesBox.Text = "Missiles";
            this.MissilesBox.UseVisualStyleBackColor = true;
            // 
            // ExplosivesBox
            // 
            this.ExplosivesBox.AutoSize = true;
            this.ExplosivesBox.Location = new System.Drawing.Point(5, 77);
            this.ExplosivesBox.Name = "ExplosivesBox";
            this.ExplosivesBox.Size = new System.Drawing.Size(76, 17);
            this.ExplosivesBox.TabIndex = 6;
            this.ExplosivesBox.Text = "Explosives";
            this.ExplosivesBox.UseVisualStyleBackColor = true;
            // 
            // MinesBox
            // 
            this.MinesBox.AutoSize = true;
            this.MinesBox.Location = new System.Drawing.Point(5, 54);
            this.MinesBox.Name = "MinesBox";
            this.MinesBox.Size = new System.Drawing.Size(54, 17);
            this.MinesBox.TabIndex = 5;
            this.MinesBox.Text = "Mines";
            this.MinesBox.UseVisualStyleBackColor = true;
            // 
            // HandGunRoundsBox
            // 
            this.HandGunRoundsBox.Location = new System.Drawing.Point(115, 30);
            this.HandGunRoundsBox.Margin = new System.Windows.Forms.Padding(2);
            this.HandGunRoundsBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HandGunRoundsBox.Name = "HandGunRoundsBox";
            this.HandGunRoundsBox.Size = new System.Drawing.Size(40, 20);
            this.HandGunRoundsBox.TabIndex = 4;
            this.HandGunRoundsBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // HandGunBox
            // 
            this.HandGunBox.AutoSize = true;
            this.HandGunBox.Location = new System.Drawing.Point(5, 31);
            this.HandGunBox.Name = "HandGunBox";
            this.HandGunBox.Size = new System.Drawing.Size(75, 17);
            this.HandGunBox.TabIndex = 3;
            this.HandGunBox.Text = "Hand Gun";
            this.HandGunBox.UseVisualStyleBackColor = true;
            // 
            // RankBox
            // 
            this.RankBox.Controls.Add(this.Rank1Button);
            this.RankBox.Controls.Add(this.Rank4Button);
            this.RankBox.Controls.Add(this.Rank2Button);
            this.RankBox.Controls.Add(this.Rank3Button);
            this.RankBox.Location = new System.Drawing.Point(6, 5);
            this.RankBox.Margin = new System.Windows.Forms.Padding(2);
            this.RankBox.Name = "RankBox";
            this.RankBox.Padding = new System.Windows.Forms.Padding(2);
            this.RankBox.Size = new System.Drawing.Size(52, 107);
            this.RankBox.TabIndex = 4;
            this.RankBox.TabStop = false;
            this.RankBox.Text = "Rank";
            // 
            // Rank1Button
            // 
            this.Rank1Button.AutoSize = true;
            this.Rank1Button.Checked = true;
            this.Rank1Button.Location = new System.Drawing.Point(4, 17);
            this.Rank1Button.Margin = new System.Windows.Forms.Padding(2);
            this.Rank1Button.Name = "Rank1Button";
            this.Rank1Button.Size = new System.Drawing.Size(29, 17);
            this.Rank1Button.TabIndex = 0;
            this.Rank1Button.TabStop = true;
            this.Rank1Button.Text = "*";
            this.Rank1Button.UseVisualStyleBackColor = true;
            this.Rank1Button.Click += new System.EventHandler(this.Rank1ButtonClicked);
            // 
            // Rank4Button
            // 
            this.Rank4Button.AutoSize = true;
            this.Rank4Button.Location = new System.Drawing.Point(4, 83);
            this.Rank4Button.Margin = new System.Windows.Forms.Padding(2);
            this.Rank4Button.Name = "Rank4Button";
            this.Rank4Button.Size = new System.Drawing.Size(41, 17);
            this.Rank4Button.TabIndex = 3;
            this.Rank4Button.Text = "****";
            this.Rank4Button.UseVisualStyleBackColor = true;
            this.Rank4Button.Click += new System.EventHandler(this.Rank4ButtonClicked);
            // 
            // Rank2Button
            // 
            this.Rank2Button.AutoSize = true;
            this.Rank2Button.Location = new System.Drawing.Point(4, 39);
            this.Rank2Button.Margin = new System.Windows.Forms.Padding(2);
            this.Rank2Button.Name = "Rank2Button";
            this.Rank2Button.Size = new System.Drawing.Size(33, 17);
            this.Rank2Button.TabIndex = 1;
            this.Rank2Button.Text = "**";
            this.Rank2Button.UseVisualStyleBackColor = true;
            this.Rank2Button.Click += new System.EventHandler(this.Rank2ButtonClicked);
            // 
            // Rank3Button
            // 
            this.Rank3Button.AutoSize = true;
            this.Rank3Button.Location = new System.Drawing.Point(4, 61);
            this.Rank3Button.Margin = new System.Windows.Forms.Padding(2);
            this.Rank3Button.Name = "Rank3Button";
            this.Rank3Button.Size = new System.Drawing.Size(37, 17);
            this.Rank3Button.TabIndex = 2;
            this.Rank3Button.Text = "***";
            this.Rank3Button.UseVisualStyleBackColor = true;
            this.Rank3Button.Click += new System.EventHandler(this.Rank3ButtonClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(583, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.DataTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this.DataTabs.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            this.EquipmentBox.ResumeLayout(false);
            this.EquipmentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RationsCounterBox)).EndInit();
            this.WeaponsBox.ResumeLayout(false);
            this.WeaponsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RocketCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrenadeCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineGunCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MissilesCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosivesCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinesCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandGunRoundsBox)).EndInit();
            this.RankBox.ResumeLayout(false);
            this.RankBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton Rank4Button;
        private System.Windows.Forms.RadioButton Rank3Button;
        private System.Windows.Forms.RadioButton Rank2Button;
        private System.Windows.Forms.RadioButton Rank1Button;
        private System.Windows.Forms.GroupBox RankBox;
        private System.Windows.Forms.GroupBox WeaponsBox;
        private System.Windows.Forms.NumericUpDown HandGunRoundsBox;
        private System.Windows.Forms.CheckBox HandGunBox;
        private System.Windows.Forms.Label AmmoCountLabel;
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.NumericUpDown RocketCountBox;
        private System.Windows.Forms.NumericUpDown GrenadeCountBox;
        private System.Windows.Forms.NumericUpDown MachineGunCountBox;
        private System.Windows.Forms.NumericUpDown MissilesCountBox;
        private System.Windows.Forms.NumericUpDown ExplosivesCountBox;
        private System.Windows.Forms.NumericUpDown MinesCountBox;
        private System.Windows.Forms.CheckBox SilencerBox;
        private System.Windows.Forms.CheckBox RocketBox;
        private System.Windows.Forms.CheckBox GrenadeBox;
        private System.Windows.Forms.CheckBox MachineGunBox;
        private System.Windows.Forms.CheckBox MissilesBox;
        private System.Windows.Forms.CheckBox ExplosivesBox;
        private System.Windows.Forms.CheckBox MinesBox;
        private System.Windows.Forms.GroupBox EquipmentBox;
        private System.Windows.Forms.CheckedListBox EquipmentCheckListB;
        private System.Windows.Forms.CheckedListBox EquipmentCheckListA;
        private System.Windows.Forms.NumericUpDown RationsCounterBox;
        private System.Windows.Forms.CheckBox RationsCheckBox;
        private System.Windows.Forms.CheckedListBox EquipmentCheckListC;
    }
}

