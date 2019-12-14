namespace fLogin
{
    partial class UCMessofMe
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
            this.txbMess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbMess
            // 
            this.txbMess.BackColor = System.Drawing.Color.LightSalmon;
            this.txbMess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMess.Location = new System.Drawing.Point(84, 4);
            this.txbMess.Multiline = true;
            this.txbMess.Name = "txbMess";
            this.txbMess.ReadOnly = true;
            this.txbMess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbMess.Size = new System.Drawing.Size(169, 20);
            this.txbMess.TabIndex = 2;
            // 
            // UCMessofMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txbMess);
            this.MaximumSize = new System.Drawing.Size(256, 27);
            this.MinimumSize = new System.Drawing.Size(256, 27);
            this.Name = "UCMessofMe";
            this.Size = new System.Drawing.Size(256, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMess;
    }
}
