namespace fLogin
{
    partial class UCLoading
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
            this.ptbLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLoad
            // 
            this.ptbLoad.BackColor = System.Drawing.Color.Transparent;
            this.ptbLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbLoad.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ptbLoad.Location = new System.Drawing.Point(0, 0);
            this.ptbLoad.Name = "ptbLoad";
            this.ptbLoad.Size = new System.Drawing.Size(25, 25);
            this.ptbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbLoad.TabIndex = 0;
            this.ptbLoad.TabStop = false;
            // 
            // UCLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ptbLoad);
            this.Name = "UCLoading";
            this.Size = new System.Drawing.Size(29, 28);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLoad;
    }
}
