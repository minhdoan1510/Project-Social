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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbContent_Main = new System.Windows.Forms.RichTextBox();
            this.btnAddPost_Main = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 164);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(111)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.rtbContent_Main);
            this.panel2.Controls.Add(this.btnAddPost_Main);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 161);
            this.panel2.TabIndex = 2;
            // 
            // rtbContent_Main
            // 
            this.rtbContent_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent_Main.Location = new System.Drawing.Point(0, 0);
            this.rtbContent_Main.Name = "rtbContent_Main";
            this.rtbContent_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbContent_Main.Size = new System.Drawing.Size(695, 115);
            this.rtbContent_Main.TabIndex = 0;
            this.rtbContent_Main.Text = "";
            // 
            // btnAddPost_Main
            // 
            this.btnAddPost_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAddPost_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPost_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPost_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddPost_Main.Location = new System.Drawing.Point(578, 121);
            this.btnAddPost_Main.Name = "btnAddPost_Main";
            this.btnAddPost_Main.Size = new System.Drawing.Size(100, 34);
            this.btnAddPost_Main.TabIndex = 1;
            this.btnAddPost_Main.Text = "ĐĂNG";
            this.btnAddPost_Main.UseVisualStyleBackColor = false;
            this.btnAddPost_Main.Click += new System.EventHandler(this.BtnAddPost_Main_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // UCAddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UCAddPost";
            this.Size = new System.Drawing.Size(703, 211);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPost_Main;
        private System.Windows.Forms.RichTextBox rtbContent_Main;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
