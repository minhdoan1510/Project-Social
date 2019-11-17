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
            this.btnMessenger = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.lbFriend_Count = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMessenger);
            this.panel1.Controls.Add(this.btnAddFriend);
            this.panel1.Controls.Add(this.lbFriend_Count);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 174);
            this.panel1.TabIndex = 0;
            // 
            // btnMessenger
            // 
            this.btnMessenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMessenger.FlatAppearance.BorderSize = 0;
            this.btnMessenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMessenger.Location = new System.Drawing.Point(158, 130);
            this.btnMessenger.Name = "btnMessenger";
            this.btnMessenger.Size = new System.Drawing.Size(159, 34);
            this.btnMessenger.TabIndex = 3;
            this.btnMessenger.Text = "Nhắn tin";
            this.btnMessenger.UseVisualStyleBackColor = false;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddFriend.FlatAppearance.BorderSize = 0;
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddFriend.Location = new System.Drawing.Point(15, 130);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(125, 34);
            this.btnAddFriend.TabIndex = 3;
            this.btnAddFriend.Text = "Kết Bạn";
            this.btnAddFriend.UseVisualStyleBackColor = false;
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
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(15, 14);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(100, 100);
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
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
        private System.Windows.Forms.Button btnMessenger;
        private System.Windows.Forms.Button btnAddFriend;
    }
}
