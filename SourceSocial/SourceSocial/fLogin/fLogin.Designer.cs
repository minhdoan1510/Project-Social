namespace fLogin
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUsername_SignIn = new System.Windows.Forms.TextBox();
            this.txbPassword_SignIn = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignUp_SignUp = new System.Windows.Forms.Button();
            this.txbName_SignUp = new System.Windows.Forms.TextBox();
            this.txbRePassword_SignUp = new System.Windows.Forms.TextBox();
            this.txbUsername_SignUp = new System.Windows.Forms.TextBox();
            this.txbPassword_SignUp = new System.Windows.Forms.TextBox();
            this.pnlSignIn.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txbUsername_SignIn
            // 
            this.txbUsername_SignIn.Location = new System.Drawing.Point(104, 68);
            this.txbUsername_SignIn.Name = "txbUsername_SignIn";
            this.txbUsername_SignIn.Size = new System.Drawing.Size(118, 20);
            this.txbUsername_SignIn.TabIndex = 1;
            // 
            // txbPassword_SignIn
            // 
            this.txbPassword_SignIn.Location = new System.Drawing.Point(104, 91);
            this.txbPassword_SignIn.Name = "txbPassword_SignIn";
            this.txbPassword_SignIn.Size = new System.Drawing.Size(118, 20);
            this.txbPassword_SignIn.TabIndex = 2;
            this.txbPassword_SignIn.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(55, 130);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(147, 130);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MẠNG XÃ HỘI MINTUS";
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.Controls.Add(this.label3);
            this.pnlSignIn.Controls.Add(this.label1);
            this.pnlSignIn.Controls.Add(this.btnSignIn);
            this.pnlSignIn.Controls.Add(this.label2);
            this.pnlSignIn.Controls.Add(this.btnSignUp);
            this.pnlSignIn.Controls.Add(this.txbUsername_SignIn);
            this.pnlSignIn.Controls.Add(this.txbPassword_SignIn);
            this.pnlSignIn.Location = new System.Drawing.Point(0, 0);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(270, 255);
            this.pnlSignIn.TabIndex = 5;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.pnlSignIn);
            this.pnlSignUp.Controls.Add(this.label4);
            this.pnlSignUp.Controls.Add(this.label7);
            this.pnlSignUp.Controls.Add(this.label5);
            this.pnlSignUp.Controls.Add(this.label8);
            this.pnlSignUp.Controls.Add(this.label6);
            this.pnlSignUp.Controls.Add(this.btnSignUp_SignUp);
            this.pnlSignUp.Controls.Add(this.txbName_SignUp);
            this.pnlSignUp.Controls.Add(this.txbRePassword_SignUp);
            this.pnlSignUp.Controls.Add(this.txbUsername_SignUp);
            this.pnlSignUp.Controls.Add(this.txbPassword_SignUp);
            this.pnlSignUp.Location = new System.Drawing.Point(1, 1);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(270, 255);
            this.pnlSignUp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MẠNG XÃ HỘI MINTUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "rePassword";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // btnSignUp_SignUp
            // 
            this.btnSignUp_SignUp.Location = new System.Drawing.Point(111, 174);
            this.btnSignUp_SignUp.Name = "btnSignUp_SignUp";
            this.btnSignUp_SignUp.Size = new System.Drawing.Size(118, 36);
            this.btnSignUp_SignUp.TabIndex = 5;
            this.btnSignUp_SignUp.Text = "ĐĂNG KÝ";
            this.btnSignUp_SignUp.UseVisualStyleBackColor = true;
            this.btnSignUp_SignUp.Click += new System.EventHandler(this.BtnSignUp_SignUp_Click);
            // 
            // txbName_SignUp
            // 
            this.txbName_SignUp.Location = new System.Drawing.Point(111, 64);
            this.txbName_SignUp.Name = "txbName_SignUp";
            this.txbName_SignUp.Size = new System.Drawing.Size(118, 20);
            this.txbName_SignUp.TabIndex = 1;
            // 
            // txbRePassword_SignUp
            // 
            this.txbRePassword_SignUp.Location = new System.Drawing.Point(111, 137);
            this.txbRePassword_SignUp.Name = "txbRePassword_SignUp";
            this.txbRePassword_SignUp.Size = new System.Drawing.Size(118, 20);
            this.txbRePassword_SignUp.TabIndex = 4;
            this.txbRePassword_SignUp.UseSystemPasswordChar = true;
            // 
            // txbUsername_SignUp
            // 
            this.txbUsername_SignUp.Location = new System.Drawing.Point(111, 87);
            this.txbUsername_SignUp.Name = "txbUsername_SignUp";
            this.txbUsername_SignUp.Size = new System.Drawing.Size(118, 20);
            this.txbUsername_SignUp.TabIndex = 2;
            // 
            // txbPassword_SignUp
            // 
            this.txbPassword_SignUp.Location = new System.Drawing.Point(111, 113);
            this.txbPassword_SignUp.Name = "txbPassword_SignUp";
            this.txbPassword_SignUp.Size = new System.Drawing.Size(118, 20);
            this.txbPassword_SignUp.TabIndex = 3;
            this.txbPassword_SignUp.UseSystemPasswordChar = true;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 257);
            this.Controls.Add(this.pnlSignUp);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUsername_SignIn;
        private System.Windows.Forms.TextBox txbPassword_SignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSignUp_SignUp;
        private System.Windows.Forms.TextBox txbName_SignUp;
        private System.Windows.Forms.TextBox txbRePassword_SignUp;
        private System.Windows.Forms.TextBox txbUsername_SignUp;
        private System.Windows.Forms.TextBox txbPassword_SignUp;
    }
}

