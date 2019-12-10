namespace fLogin
{
    partial class UCDetailMessbox
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
            this.pnlDetailMess = new System.Windows.Forms.Panel();
            this.pnlDisplayMess = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbMess = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlDetailMess.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetailMess
            // 
            this.pnlDetailMess.Controls.Add(this.pnlDisplayMess);
            this.pnlDetailMess.Controls.Add(this.panel2);
            this.pnlDetailMess.Controls.Add(this.panel1);
            this.pnlDetailMess.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailMess.Name = "pnlDetailMess";
            this.pnlDetailMess.Size = new System.Drawing.Size(256, 364);
            this.pnlDetailMess.TabIndex = 2;
            // 
            // pnlDisplayMess
            // 
            this.pnlDisplayMess.AutoScroll = true;
            this.pnlDisplayMess.AutoSize = true;
            this.pnlDisplayMess.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayMess.Location = new System.Drawing.Point(0, 34);
            this.pnlDisplayMess.MaximumSize = new System.Drawing.Size(256, 293);
            this.pnlDisplayMess.MinimumSize = new System.Drawing.Size(256, 0);
            this.pnlDisplayMess.Name = "pnlDisplayMess";
            this.pnlDisplayMess.Size = new System.Drawing.Size(256, 0);
            this.pnlDisplayMess.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txbMess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 37);
            this.panel2.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(61)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(209, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // txbMess
            // 
            this.txbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMess.Location = new System.Drawing.Point(5, 7);
            this.txbMess.Name = "txbMess";
            this.txbMess.Size = new System.Drawing.Size(200, 24);
            this.txbMess.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(124)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 34);
            this.panel1.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(34, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // UCDetailMessbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDetailMess);
            this.Name = "UCDetailMessbox";
            this.Size = new System.Drawing.Size(256, 365);
            this.pnlDetailMess.ResumeLayout(false);
            this.pnlDetailMess.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetailMess;
        private System.Windows.Forms.Panel pnlDisplayMess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbMess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBack;
    }
}
