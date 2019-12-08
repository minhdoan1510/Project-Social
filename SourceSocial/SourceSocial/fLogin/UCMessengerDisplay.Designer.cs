namespace fLogin
{
    partial class UCMessengerDisplay
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
            this.pnlListMess = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlListMess
            // 
            this.pnlListMess.Location = new System.Drawing.Point(0, 0);
            this.pnlListMess.Name = "pnlListMess";
            this.pnlListMess.Size = new System.Drawing.Size(256, 364);
            this.pnlListMess.TabIndex = 0;
            // 
            // UCMessengerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListMess);
            this.Name = "UCMessengerDisplay";
            this.Size = new System.Drawing.Size(256, 364);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListMess;
    }
}
