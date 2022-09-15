namespace Listenansicht
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LView = new System.Windows.Forms.ListView();
            this.RBtnDetails = new System.Windows.Forms.RadioButton();
            this.RBtnLargeIcon = new System.Windows.Forms.RadioButton();
            this.RBtnList = new System.Windows.Forms.RadioButton();
            this.RBtnSmallIcon = new System.Windows.Forms.RadioButton();
            this.RBtnTile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LView
            // 
            this.LView.Location = new System.Drawing.Point(12, 12);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(349, 119);
            this.LView.TabIndex = 0;
            this.LView.UseCompatibleStateImageBehavior = false;
            // 
            // RBtnDetails
            // 
            this.RBtnDetails.AutoSize = true;
            this.RBtnDetails.Location = new System.Drawing.Point(381, 12);
            this.RBtnDetails.Name = "RBtnDetails";
            this.RBtnDetails.Size = new System.Drawing.Size(60, 19);
            this.RBtnDetails.TabIndex = 1;
            this.RBtnDetails.TabStop = true;
            this.RBtnDetails.Text = "Details";
            this.RBtnDetails.UseVisualStyleBackColor = true;
            this.RBtnDetails.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RBtnLargeIcon
            // 
            this.RBtnLargeIcon.AutoSize = true;
            this.RBtnLargeIcon.Location = new System.Drawing.Point(381, 37);
            this.RBtnLargeIcon.Name = "RBtnLargeIcon";
            this.RBtnLargeIcon.Size = new System.Drawing.Size(77, 19);
            this.RBtnLargeIcon.TabIndex = 1;
            this.RBtnLargeIcon.TabStop = true;
            this.RBtnLargeIcon.Text = "LargeIcon";
            this.RBtnLargeIcon.UseVisualStyleBackColor = true;
            this.RBtnLargeIcon.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RBtnList
            // 
            this.RBtnList.AutoSize = true;
            this.RBtnList.Location = new System.Drawing.Point(381, 62);
            this.RBtnList.Name = "RBtnList";
            this.RBtnList.Size = new System.Drawing.Size(43, 19);
            this.RBtnList.TabIndex = 1;
            this.RBtnList.TabStop = true;
            this.RBtnList.Text = "List";
            this.RBtnList.UseVisualStyleBackColor = true;
            this.RBtnList.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RBtnSmallIcon
            // 
            this.RBtnSmallIcon.AutoSize = true;
            this.RBtnSmallIcon.Location = new System.Drawing.Point(381, 87);
            this.RBtnSmallIcon.Name = "RBtnSmallIcon";
            this.RBtnSmallIcon.Size = new System.Drawing.Size(77, 19);
            this.RBtnSmallIcon.TabIndex = 1;
            this.RBtnSmallIcon.TabStop = true;
            this.RBtnSmallIcon.Text = "SmallIcon";
            this.RBtnSmallIcon.UseVisualStyleBackColor = true;
            this.RBtnSmallIcon.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RBtnTile
            // 
            this.RBtnTile.AutoSize = true;
            this.RBtnTile.Location = new System.Drawing.Point(381, 112);
            this.RBtnTile.Name = "RBtnTile";
            this.RBtnTile.Size = new System.Drawing.Size(43, 19);
            this.RBtnTile.TabIndex = 1;
            this.RBtnTile.TabStop = true;
            this.RBtnTile.Text = "Tile";
            this.RBtnTile.UseVisualStyleBackColor = true;
            this.RBtnTile.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 138);
            this.Controls.Add(this.RBtnTile);
            this.Controls.Add(this.RBtnSmallIcon);
            this.Controls.Add(this.RBtnList);
            this.Controls.Add(this.RBtnLargeIcon);
            this.Controls.Add(this.RBtnDetails);
            this.Controls.Add(this.LView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView LView;
        private RadioButton RBtnDetails;
        private RadioButton RBtnLargeIcon;
        private RadioButton RBtnList;
        private RadioButton RBtnSmallIcon;
        private RadioButton RBtnTile;
    }
}