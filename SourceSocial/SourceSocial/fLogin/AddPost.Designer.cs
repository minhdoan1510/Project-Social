namespace fLogin
{
    partial class AddPost
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
            this.rtbContent_Main = new System.Windows.Forms.RichTextBox();
            this.btnAddPost_Main = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnAddPost_Main);
            this.panel1.Controls.Add(this.rtbContent_Main);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 202);
            this.panel1.TabIndex = 0;
            // 
            // rtbContent_Main
            // 
            this.rtbContent_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbContent_Main.Location = new System.Drawing.Point(0, 0);
            this.rtbContent_Main.Name = "rtbContent_Main";
            this.rtbContent_Main.Size = new System.Drawing.Size(701, 158);
            this.rtbContent_Main.TabIndex = 0;
            this.rtbContent_Main.Text = "";
            // 
            // btnAddPost_Main
            // 
            this.btnAddPost_Main.Location = new System.Drawing.Point(612, 168);
            this.btnAddPost_Main.Name = "btnAddPost_Main";
            this.btnAddPost_Main.Size = new System.Drawing.Size(75, 23);
            this.btnAddPost_Main.TabIndex = 1;
            this.btnAddPost_Main.Text = "Đăng";
            this.btnAddPost_Main.UseVisualStyleBackColor = true;
            this.btnAddPost_Main.Click += new System.EventHandler(this.BtnAddPost_Main_Click);
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddPost";
            this.Size = new System.Drawing.Size(707, 208);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPost_Main;
        private System.Windows.Forms.RichTextBox rtbContent_Main;
    }
}
