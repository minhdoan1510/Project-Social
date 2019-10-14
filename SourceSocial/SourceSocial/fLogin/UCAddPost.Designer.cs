namespace fLogin
{
    partial class UCAddPost
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
            this.btnAddPost_Main = new System.Windows.Forms.Button();
            this.rtbContent_Main = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 162);
            this.panel1.TabIndex = 0;
            // 
            // btnAddPost_Main
            // 
            this.btnAddPost_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddPost_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost_Main.ForeColor = System.Drawing.Color.White;
            this.btnAddPost_Main.Location = new System.Drawing.Point(575, 121);
            this.btnAddPost_Main.Name = "btnAddPost_Main";
            this.btnAddPost_Main.Size = new System.Drawing.Size(100, 34);
            this.btnAddPost_Main.TabIndex = 1;
            this.btnAddPost_Main.Text = "ĐĂNG";
            this.btnAddPost_Main.UseVisualStyleBackColor = false;
            this.btnAddPost_Main.Click += new System.EventHandler(this.BtnAddPost_Main_Click);
            // 
            // rtbContent_Main
            // 
            this.rtbContent_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent_Main.Location = new System.Drawing.Point(0, 0);
            this.rtbContent_Main.Name = "rtbContent_Main";
            this.rtbContent_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbContent_Main.Size = new System.Drawing.Size(680, 115);
            this.rtbContent_Main.TabIndex = 0;
            this.rtbContent_Main.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.rtbContent_Main);
            this.panel2.Controls.Add(this.btnAddPost_Main);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 161);
            this.panel2.TabIndex = 2;
            // 
            // UCAddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UCAddPost";
            this.Size = new System.Drawing.Size(688, 211);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPost_Main;
        private System.Windows.Forms.RichTextBox rtbContent_Main;
        private System.Windows.Forms.Panel panel2;
    }
}
