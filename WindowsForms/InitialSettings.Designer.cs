namespace WindowsForms
{
    partial class InitialSettings
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
				this.rbMale = new System.Windows.Forms.RadioButton();
				this.rbFemale = new System.Windows.Forms.RadioButton();
				this.groupBox = new System.Windows.Forms.GroupBox();
				this.rbEng = new System.Windows.Forms.RadioButton();
				this.rbHrv = new System.Windows.Forms.RadioButton();
				this.btnSaveInitSettings = new System.Windows.Forms.Button();
				this.lblLanguage = new System.Windows.Forms.Label();
				this.lblComp = new System.Windows.Forms.Label();
				this.groupBox.SuspendLayout();
				this.SuspendLayout();
				// 
				// rbMale
				// 
				this.rbMale.Appearance = System.Windows.Forms.Appearance.Button;
				this.rbMale.BackColor = System.Drawing.Color.SkyBlue;
				this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.rbMale.Location = new System.Drawing.Point(66, 163);
				this.rbMale.Name = "rbMale";
				this.rbMale.Size = new System.Drawing.Size(120, 120);
				this.rbMale.TabIndex = 1;
				this.rbMale.TabStop = true;
				this.rbMale.Text = "♂";
				this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.rbMale.UseVisualStyleBackColor = false;
				// 
				// rbFemale
				// 
				this.rbFemale.Appearance = System.Windows.Forms.Appearance.Button;
				this.rbFemale.BackColor = System.Drawing.Color.Pink;
				this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.rbFemale.Location = new System.Drawing.Point(295, 163);
				this.rbFemale.Name = "rbFemale";
				this.rbFemale.Size = new System.Drawing.Size(120, 120);
				this.rbFemale.TabIndex = 2;
				this.rbFemale.TabStop = true;
				this.rbFemale.Text = "♀";
				this.rbFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.rbFemale.UseVisualStyleBackColor = false;
				// 
				// groupBox
				// 
				this.groupBox.Controls.Add(this.rbEng);
				this.groupBox.Controls.Add(this.rbHrv);
				this.groupBox.Location = new System.Drawing.Point(94, 40);
				this.groupBox.Name = "groupBox";
				this.groupBox.Size = new System.Drawing.Size(288, 61);
				this.groupBox.TabIndex = 3;
				this.groupBox.TabStop = false;
				// 
				// rbEng
				// 
				this.rbEng.Appearance = System.Windows.Forms.Appearance.Button;
				this.rbEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.rbEng.Location = new System.Drawing.Point(193, 14);
				this.rbEng.Name = "rbEng";
				this.rbEng.Size = new System.Drawing.Size(72, 41);
				this.rbEng.TabIndex = 1;
				this.rbEng.Text = "ENG";
				this.rbEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.rbEng.UseVisualStyleBackColor = true;
				// 
				// rbHrv
				// 
				this.rbHrv.Appearance = System.Windows.Forms.Appearance.Button;
				this.rbHrv.Checked = true;
				this.rbHrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.rbHrv.Location = new System.Drawing.Point(25, 14);
				this.rbHrv.Name = "rbHrv";
				this.rbHrv.Size = new System.Drawing.Size(72, 41);
				this.rbHrv.TabIndex = 0;
				this.rbHrv.TabStop = true;
				this.rbHrv.Text = "HRV";
				this.rbHrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				this.rbHrv.UseVisualStyleBackColor = true;
				// 
				// btnSaveInitSettings
				// 
				this.btnSaveInitSettings.BackgroundImage = global::WindowsForms.Properties.Resources.Programming_Save_icon;
				this.btnSaveInitSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
				this.btnSaveInitSettings.Location = new System.Drawing.Point(218, 329);
				this.btnSaveInitSettings.Name = "btnSaveInitSettings";
				this.btnSaveInitSettings.Size = new System.Drawing.Size(50, 50);
				this.btnSaveInitSettings.TabIndex = 4;
				this.btnSaveInitSettings.UseVisualStyleBackColor = true;
				this.btnSaveInitSettings.Click += new System.EventHandler(this.BtnSaveInitSettings_Click);
				// 
				// lblLanguage
				// 
				this.lblLanguage.AutoSize = true;
				this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lblLanguage.Location = new System.Drawing.Point(182, 17);
				this.lblLanguage.Name = "lblLanguage";
				this.lblLanguage.Size = new System.Drawing.Size(113, 20);
				this.lblLanguage.TabIndex = 5;
				this.lblLanguage.Text = "Odaberi jezik";
				// 
				// lblComp
				// 
				this.lblComp.AutoSize = true;
				this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lblComp.Location = new System.Drawing.Point(157, 131);
				this.lblComp.Name = "lblComp";
				this.lblComp.Size = new System.Drawing.Size(160, 20);
				this.lblComp.TabIndex = 6;
				this.lblComp.Text = "Odaberi natjecanje";
				// 
				// InitialSettings
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(492, 407);
				this.Controls.Add(this.lblComp);
				this.Controls.Add(this.lblLanguage);
				this.Controls.Add(this.btnSaveInitSettings);
				this.Controls.Add(this.groupBox);
				this.Controls.Add(this.rbFemale);
				this.Controls.Add(this.rbMale);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "InitialSettings";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Početne postavke";
				this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitialSettings_FormClosing);
				this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitialSettings_FormClosed);
				this.groupBox.ResumeLayout(false);
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbHrv;
        private System.Windows.Forms.Button btnSaveInitSettings;
		  private System.Windows.Forms.Label lblLanguage;
		  private System.Windows.Forms.Label lblComp;
	 }
}