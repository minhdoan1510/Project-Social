namespace fLogin
{
    partial class UCProfile_InfoBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFriend_Count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFriend_Count);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 174);
            this.panel1.TabIndex = 0;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(15, 14);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(100, 100);
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(121, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(86, 31);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbFriend_Count
            // 
            this.lbFriend_Count.AutoSize = true;
            this.lbFriend_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriend_Count.Location = new System.Drawing.Point(124, 97);
            this.lbFriend_Count.Name = "lbFriend_Count";
            this.lbFriend_Count.Size = new System.Drawing.Size(68, 17);
            this.lbFriend_Count.TabIndex = 2;
            this.lbFriend_Count.Text = "1000 bạn";
            // 
            // UCProfile_InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCProfile_InfoBox";
            this.Size = new System.Drawing.Size(329, 174);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lbFriend_Count;
        private System.Windows.Forms.Label lbName;
    }
}
