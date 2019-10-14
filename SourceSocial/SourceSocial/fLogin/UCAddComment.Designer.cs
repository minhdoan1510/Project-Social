namespace fLogin
{
    partial class UCAddComment
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
            this.txbContentComment = new System.Windows.Forms.TextBox();
            this.ptbSendComment = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSendComment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.ptbSendComment);
            this.panel1.Controls.Add(this.txbContentComment);
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 40);
            this.panel1.TabIndex = 1;
            // 
            // txbContentComment
            // 
            this.txbContentComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContentComment.Location = new System.Drawing.Point(3, 3);
            this.txbContentComment.Multiline = true;
            this.txbContentComment.Name = "txbContentComment";
            this.txbContentComment.Size = new System.Drawing.Size(578, 34);
            this.txbContentComment.TabIndex = 0;
            // 
            // ptbSendComment
            // 
            this.ptbSendComment.Location = new System.Drawing.Point(587, 3);
            this.ptbSendComment.Name = "ptbSendComment";
            this.ptbSendComment.Size = new System.Drawing.Size(53, 34);
            this.ptbSendComment.TabIndex = 1;
            this.ptbSendComment.TabStop = false;
            // 
            // AddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "AddComment";
            this.Size = new System.Drawing.Size(645, 48);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSendComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSendComment;
        private System.Windows.Forms.TextBox txbContentComment;
    }
}
