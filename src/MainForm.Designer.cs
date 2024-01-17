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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rank1Button = new System.Windows.Forms.RadioButton();
            this.Rank2Button = new System.Windows.Forms.RadioButton();
            this.Rank3Button = new System.Windows.Forms.RadioButton();
            this.Rank4Button = new System.Windows.Forms.RadioButton();
            this.RankBox = new System.Windows.Forms.GroupBox();
            this.DataTabs.SuspendLayout();
            this.ItemsTab.SuspendLayout();
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
            this.DataTabs.Size = new System.Drawing.Size(420, 420);
            this.DataTabs.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.RankBox);
            this.ItemsTab.Location = new System.Drawing.Point(4, 25);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTab.Size = new System.Drawing.Size(412, 391);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.Text = "Snake";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rank1Button
            // 
            this.Rank1Button.AutoSize = true;
            this.Rank1Button.Checked = true;
            this.Rank1Button.Location = new System.Drawing.Point(6, 21);
            this.Rank1Button.Name = "Rank1Button";
            this.Rank1Button.Size = new System.Drawing.Size(33, 20);
            this.Rank1Button.TabIndex = 0;
            this.Rank1Button.TabStop = true;
            this.Rank1Button.Text = "*";
            this.Rank1Button.UseVisualStyleBackColor = true;
            // 
            // Rank2Button
            // 
            this.Rank2Button.AutoSize = true;
            this.Rank2Button.Location = new System.Drawing.Point(6, 48);
            this.Rank2Button.Name = "Rank2Button";
            this.Rank2Button.Size = new System.Drawing.Size(38, 20);
            this.Rank2Button.TabIndex = 1;
            this.Rank2Button.Text = "**";
            this.Rank2Button.UseVisualStyleBackColor = true;
            // 
            // Rank3Button
            // 
            this.Rank3Button.AutoSize = true;
            this.Rank3Button.Location = new System.Drawing.Point(6, 75);
            this.Rank3Button.Name = "Rank3Button";
            this.Rank3Button.Size = new System.Drawing.Size(43, 20);
            this.Rank3Button.TabIndex = 2;
            this.Rank3Button.Text = "***";
            this.Rank3Button.UseVisualStyleBackColor = true;
            // 
            // Rank4Button
            // 
            this.Rank4Button.AutoSize = true;
            this.Rank4Button.Location = new System.Drawing.Point(6, 102);
            this.Rank4Button.Name = "Rank4Button";
            this.Rank4Button.Size = new System.Drawing.Size(48, 20);
            this.Rank4Button.TabIndex = 3;
            this.Rank4Button.Text = "****";
            this.Rank4Button.UseVisualStyleBackColor = true;
            // 
            // RankBox
            // 
            this.RankBox.Controls.Add(this.Rank1Button);
            this.RankBox.Controls.Add(this.Rank4Button);
            this.RankBox.Controls.Add(this.Rank2Button);
            this.RankBox.Controls.Add(this.Rank3Button);
            this.RankBox.Location = new System.Drawing.Point(8, 6);
            this.RankBox.Name = "RankBox";
            this.RankBox.Size = new System.Drawing.Size(70, 132);
            this.RankBox.TabIndex = 4;
            this.RankBox.TabStop = false;
            this.RankBox.Text = "Rank";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataTabs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this.DataTabs.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
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
    }
}

