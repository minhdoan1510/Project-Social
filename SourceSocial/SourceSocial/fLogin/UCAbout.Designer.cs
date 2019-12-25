namespace fLogin
{
    partial class UCAbout
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
            this.lb = new System.Windows.Forms.Label();
            this.btnMinh = new System.Windows.Forms.Button();
            this.btnTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(13, 14);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(133, 23);
            this.lb.TabIndex = 0;
            this.lb.Text = "Nhóm tác giả:";
            // 
            // btnMinh
            // 
            this.btnMinh.BackColor = System.Drawing.Color.Transparent;
            this.btnMinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinh.FlatAppearance.BorderSize = 2;
            this.btnMinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinh.ForeColor = System.Drawing.Color.Olive;
            this.btnMinh.Location = new System.Drawing.Point(3, 57);
            this.btnMinh.Name = "btnMinh";
            this.btnMinh.Size = new System.Drawing.Size(211, 37);
            this.btnMinh.TabIndex = 1;
            this.btnMinh.Text = "Đoàn Công Minh";
            this.btnMinh.UseVisualStyleBackColor = false;
            this.btnMinh.Click += new System.EventHandler(this.BtnMinh_Click);
            // 
            // btnTien
            // 
            this.btnTien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTien.FlatAppearance.BorderSize = 2;
            this.btnTien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTien.ForeColor = System.Drawing.Color.Olive;
            this.btnTien.Location = new System.Drawing.Point(3, 100);
            this.btnTien.Name = "btnTien";
            this.btnTien.Size = new System.Drawing.Size(211, 37);
            this.btnTien.TabIndex = 1;
            this.btnTien.Text = "Bùi Minh Tiến";
            this.btnTien.UseVisualStyleBackColor = true;
            this.btnTien.Click += new System.EventHandler(this.BtnTien_Click);
            // 
            // UCAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTien);
            this.Controls.Add(this.btnMinh);
            this.Controls.Add(this.lb);
            this.Name = "UCAbout";
            this.Size = new System.Drawing.Size(217, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnMinh;
        private System.Windows.Forms.Button btnTien;
    }
}
