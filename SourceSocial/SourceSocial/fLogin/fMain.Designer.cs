namespace fLogin
{
    partial class fMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit_Form = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNewFeed_Main = new System.Windows.Forms.Panel();
            this.pnlAddPost = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit_Form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnExit_Form
            // 
            this.btnExit_Form.Location = new System.Drawing.Point(1043, 3);
            this.btnExit_Form.Name = "btnExit_Form";
            this.btnExit_Form.Size = new System.Drawing.Size(34, 32);
            this.btnExit_Form.TabIndex = 0;
            this.btnExit_Form.Text = "X";
            this.btnExit_Form.UseVisualStyleBackColor = true;
            this.btnExit_Form.Click += new System.EventHandler(this.BtnExit_Form_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 41);
            this.panel2.TabIndex = 1;
            // 
            // pnlNewFeed_Main
            // 
            this.pnlNewFeed_Main.AutoScroll = true;
            this.pnlNewFeed_Main.Location = new System.Drawing.Point(214, 299);
            this.pnlNewFeed_Main.Name = "pnlNewFeed_Main";
            this.pnlNewFeed_Main.Size = new System.Drawing.Size(707, 421);
            this.pnlNewFeed_Main.TabIndex = 2;
            // 
            // pnlAddPost
            // 
            this.pnlAddPost.Location = new System.Drawing.Point(214, 85);
            this.pnlAddPost.Name = "pnlAddPost";
            this.pnlAddPost.Size = new System.Drawing.Size(707, 208);
            this.pnlAddPost.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 635);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(927, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 635);
            this.panel6.TabIndex = 5;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 734);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlAddPost);
            this.Controls.Add(this.pnlNewFeed_Main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit_Form;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNewFeed_Main;
        private System.Windows.Forms.Panel pnlAddPost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}