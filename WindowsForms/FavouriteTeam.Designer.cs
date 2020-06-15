namespace WindowsForms
{
    partial class FavouriteTeam
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
            this.cbTeamList = new System.Windows.Forms.ComboBox();
            this.btnSaveFavouriteRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTeamList
            // 
            this.cbTeamList.FormattingEnabled = true;
            this.cbTeamList.Location = new System.Drawing.Point(24, 20);
            this.cbTeamList.MaxDropDownItems = 32;
            this.cbTeamList.Name = "cbTeamList";
            this.cbTeamList.Size = new System.Drawing.Size(304, 21);
            this.cbTeamList.TabIndex = 0;
            // 
            // btnSaveFavouriteRep
            // 
            this.btnSaveFavouriteRep.BackgroundImage = global::WindowsForms.Properties.Resources.Programming_Save_icon;
            this.btnSaveFavouriteRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFavouriteRep.Location = new System.Drawing.Point(386, 12);
            this.btnSaveFavouriteRep.Name = "btnSaveFavouriteRep";
            this.btnSaveFavouriteRep.Size = new System.Drawing.Size(35, 35);
            this.btnSaveFavouriteRep.TabIndex = 1;
            this.btnSaveFavouriteRep.UseVisualStyleBackColor = true;
            this.btnSaveFavouriteRep.Click += new System.EventHandler(this.btnSaveFavouriteRep_Click);
            // 
            // FavouriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 60);
            this.Controls.Add(this.btnSaveFavouriteRep);
            this.Controls.Add(this.cbTeamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavouriteTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick your favourite team!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeamList;
        private System.Windows.Forms.Button btnSaveFavouriteRep;
    }
}