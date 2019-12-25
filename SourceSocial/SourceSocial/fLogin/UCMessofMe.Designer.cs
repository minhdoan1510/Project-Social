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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMess = new RoundedLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(249, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 28);
            this.panel1.TabIndex = 0;
            // 
            // txbMess
            // 
            this.txbMess._BackColor = System.Drawing.Color.LightSalmon;
            this.txbMess.BackColor = System.Drawing.Color.Transparent;
            this.txbMess.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbMess.Location = new System.Drawing.Point(80, 0);
            this.txbMess.MaximumSize = new System.Drawing.Size(210, 26);
            this.txbMess.Name = "txbMess";
            this.txbMess.Size = new System.Drawing.Size(169, 26);
            this.txbMess.TabIndex = 2;
            this.txbMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCMessofMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txbMess);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "UCMessofMe";
            this.Size = new System.Drawing.Size(256, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundedLabel txbMess;
    }
}
