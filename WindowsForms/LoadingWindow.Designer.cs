﻿
namespace WindowsForms
{
	 partial class LoadingWindow
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
				this.label = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// label
				// 
				this.label.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				this.label.Dock = System.Windows.Forms.DockStyle.Fill;
				this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label.Location = new System.Drawing.Point(0, 0);
				this.label.Name = "label";
				this.label.Size = new System.Drawing.Size(250, 150);
				this.label.TabIndex = 0;
				this.label.Text = "Loading...";
				this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				// LoadingWindow
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(250, 150);
				this.Controls.Add(this.label);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "LoadingWindow";
				this.ShowIcon = false;
				this.ShowInTaskbar = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Loading";
				this.TopMost = true;
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.Label label;
	 }
}