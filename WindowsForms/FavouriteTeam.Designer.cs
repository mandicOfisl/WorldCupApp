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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouriteTeam));
				this.cbTeamList = new System.Windows.Forms.ComboBox();
				this.btnSaveFavouriteRep = new System.Windows.Forms.Button();
				this.BtnChangeCompetition = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// cbTeamList
				// 
				this.cbTeamList.FormattingEnabled = true;
				resources.ApplyResources(this.cbTeamList, "cbTeamList");
				this.cbTeamList.Name = "cbTeamList";
				// 
				// btnSaveFavouriteRep
				// 
				this.btnSaveFavouriteRep.BackgroundImage = global::WindowsForms.Properties.Resources.Programming_Save_icon;
				resources.ApplyResources(this.btnSaveFavouriteRep, "btnSaveFavouriteRep");
				this.btnSaveFavouriteRep.Name = "btnSaveFavouriteRep";
				this.btnSaveFavouriteRep.UseVisualStyleBackColor = true;
				this.btnSaveFavouriteRep.Click += new System.EventHandler(this.BtnSaveFavouriteRep_Click);
				// 
				// BtnChangeCompetition
				// 
				this.BtnChangeCompetition.BackgroundImage = global::WindowsForms.Properties.Resources.gear_icon;
				resources.ApplyResources(this.BtnChangeCompetition, "BtnChangeCompetition");
				this.BtnChangeCompetition.Name = "BtnChangeCompetition";
				this.BtnChangeCompetition.UseVisualStyleBackColor = true;
				this.BtnChangeCompetition.Click += new System.EventHandler(this.BtnChangeCompetition_Click);
				// 
				// FavouriteTeam
				// 
				resources.ApplyResources(this, "$this");
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.Controls.Add(this.BtnChangeCompetition);
				this.Controls.Add(this.btnSaveFavouriteRep);
				this.Controls.Add(this.cbTeamList);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "FavouriteTeam";
				this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavouriteTeam_FormClosing);
				this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FavouriteTeam_FormClosed);
				this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeamList;
        private System.Windows.Forms.Button btnSaveFavouriteRep;
		  private System.Windows.Forms.Button BtnChangeCompetition;
	 }
}