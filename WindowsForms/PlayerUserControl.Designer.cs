namespace WindowsForms
{
    partial class PlayerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNameAndNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pbFavourite = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameAndNumber
            // 
            this.lblNameAndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndNumber.Location = new System.Drawing.Point(0, 126);
            this.lblNameAndNumber.Name = "lblNameAndNumber";
            this.lblNameAndNumber.Size = new System.Drawing.Size(250, 68);
            this.lblNameAndNumber.TabIndex = 1;
            this.lblNameAndNumber.Text = "#10 name surname";
            this.lblNameAndNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(0, 203);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(250, 20);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "pozicija";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptain
            // 
            this.lblCaptain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptain.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCaptain.Location = new System.Drawing.Point(38, 23);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(30, 30);
            this.lblCaptain.TabIndex = 3;
            this.lblCaptain.Text = "C";
            this.lblCaptain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaptain.Visible = false;
            // 
            // pbFavourite
            // 
            this.pbFavourite.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbFavourite.Image = global::WindowsForms.Properties.Resources.star_icon;
            this.pbFavourite.InitialImage = null;
            this.pbFavourite.Location = new System.Drawing.Point(182, 23);
            this.pbFavourite.Name = "pbFavourite";
            this.pbFavourite.Size = new System.Drawing.Size(30, 30);
            this.pbFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavourite.TabIndex = 4;
            this.pbFavourite.TabStop = false;
            this.pbFavourite.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage.Image = global::WindowsForms.Properties.Resources.no_image;
            this.pbImage.Location = new System.Drawing.Point(75, 23);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 100);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStripMenuItem,
            this.removeFromFavouritesToolStripMenuItem,
            this.loadPictureToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(202, 92);
            // 
            // addToFavouritesToolStripMenuItem
            // 
            this.addToFavouritesToolStripMenuItem.Name = "addToFavouritesToolStripMenuItem";
            this.addToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addToFavouritesToolStripMenuItem.Text = "Add to favourites";
            this.addToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavouritesToolStripMenuItem_Click);
            // 
            // removeFromFavouritesToolStripMenuItem
            // 
            this.removeFromFavouritesToolStripMenuItem.Enabled = false;
            this.removeFromFavouritesToolStripMenuItem.Name = "removeFromFavouritesToolStripMenuItem";
            this.removeFromFavouritesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.removeFromFavouritesToolStripMenuItem.Text = "Remove from favourites";
            // 
            // loadPictureToolStripMenuItem
            // 
            this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.loadPictureToolStripMenuItem.Text = "Load picture...";
            // 
            // PlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.pbFavourite);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNameAndNumber);
            this.Controls.Add(this.pbImage);
            this.Name = "PlayerUserControl";
            this.Size = new System.Drawing.Size(246, 246);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUserControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblNameAndNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pbFavourite;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
    }
}
