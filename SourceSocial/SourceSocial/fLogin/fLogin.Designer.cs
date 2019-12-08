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
<<<<<<< HEAD
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txbUsername_SignIn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPassword_SignIn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lable1 = new MaterialSkin.Controls.MaterialLabel();
            this.lable2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSignUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txbRePassword_SignUp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbPassword_SignUp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbUsername_SignUp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txbName_SignUp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(368, 24);
            this.materialTabSelector2.TabIndex = 8;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 86);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(368, 349);
            this.materialTabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnSignIn);
            this.tabPage1.Controls.Add(this.txbUsername_SignIn);
            this.tabPage1.Controls.Add(this.txbPassword_SignIn);
            this.tabPage1.Controls.Add(this.lable1);
            this.tabPage1.Controls.Add(this.lable2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng nhập";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(134, 164);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = true;
            this.btnSignIn.Size = new System.Drawing.Size(170, 40);
            this.btnSignIn.TabIndex = 16;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // txbUsername_SignIn
            // 
            this.txbUsername_SignIn.Depth = 0;
            this.txbUsername_SignIn.Hint = "Tên đăng nhập";
            this.txbUsername_SignIn.Location = new System.Drawing.Point(134, 85);
            this.txbUsername_SignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbUsername_SignIn.Name = "txbUsername_SignIn";
            this.txbUsername_SignIn.PasswordChar = '\0';
            this.txbUsername_SignIn.SelectedText = "";
            this.txbUsername_SignIn.SelectionLength = 0;
            this.txbUsername_SignIn.SelectionStart = 0;
            this.txbUsername_SignIn.Size = new System.Drawing.Size(170, 23);
            this.txbUsername_SignIn.TabIndex = 15;
            this.txbUsername_SignIn.UseSystemPasswordChar = false;
            // 
            // txbPassword_SignIn
            // 
            this.txbPassword_SignIn.Depth = 0;
            this.txbPassword_SignIn.Hint = "Mật khẩu";
            this.txbPassword_SignIn.Location = new System.Drawing.Point(134, 119);
            this.txbPassword_SignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPassword_SignIn.Name = "txbPassword_SignIn";
            this.txbPassword_SignIn.PasswordChar = '*';
            this.txbPassword_SignIn.SelectedText = "";
            this.txbPassword_SignIn.SelectionLength = 0;
            this.txbPassword_SignIn.SelectionStart = 0;
            this.txbPassword_SignIn.Size = new System.Drawing.Size(170, 23);
            this.txbPassword_SignIn.TabIndex = 14;
            this.txbPassword_SignIn.UseSystemPasswordChar = false;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Depth = 0;
            this.lable1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lable1.Location = new System.Drawing.Point(47, 89);
            this.lable1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(77, 19);
            this.lable1.TabIndex = 12;
            this.lable1.Text = "Username";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Depth = 0;
            this.lable2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lable2.Location = new System.Drawing.Point(47, 119);
            this.lable2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(75, 19);
            this.lable2.TabIndex = 13;
            this.lable2.Text = "Password";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnSignUp);
            this.tabPage2.Controls.Add(this.txbRePassword_SignUp);
            this.tabPage2.Controls.Add(this.txbPassword_SignUp);
            this.tabPage2.Controls.Add(this.txbUsername_SignUp);
            this.tabPage2.Controls.Add(this.txbName_SignUp);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng ký";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Depth = 0;
            this.btnSignUp.Location = new System.Drawing.Point(139, 201);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Primary = true;
            this.btnSignUp.Size = new System.Drawing.Size(160, 37);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_SignUp_Click);
            // 
            // txbRePassword_SignUp
            // 
            this.txbRePassword_SignUp.Depth = 0;
            this.txbRePassword_SignUp.Hint = "Nhập lại mật khẩu";
            this.txbRePassword_SignUp.Location = new System.Drawing.Point(139, 161);
            this.txbRePassword_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbRePassword_SignUp.Name = "txbRePassword_SignUp";
            this.txbRePassword_SignUp.PasswordChar = '*';
            this.txbRePassword_SignUp.SelectedText = "";
            this.txbRePassword_SignUp.SelectionLength = 0;
            this.txbRePassword_SignUp.SelectionStart = 0;
            this.txbRePassword_SignUp.Size = new System.Drawing.Size(188, 23);
            this.txbRePassword_SignUp.TabIndex = 10;
            this.txbRePassword_SignUp.UseSystemPasswordChar = false;
            // 
            // txbPassword_SignUp
            // 
            this.txbPassword_SignUp.Depth = 0;
            this.txbPassword_SignUp.Hint = "Mật khẩu";
            this.txbPassword_SignUp.Location = new System.Drawing.Point(140, 127);
            this.txbPassword_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbPassword_SignUp.Name = "txbPassword_SignUp";
            this.txbPassword_SignUp.PasswordChar = '*';
            this.txbPassword_SignUp.SelectedText = "";
            this.txbPassword_SignUp.SelectionLength = 0;
            this.txbPassword_SignUp.SelectionStart = 0;
            this.txbPassword_SignUp.Size = new System.Drawing.Size(188, 23);
            this.txbPassword_SignUp.TabIndex = 10;
            this.txbPassword_SignUp.UseSystemPasswordChar = false;
            // 
            // txbUsername_SignUp
            // 
            this.txbUsername_SignUp.Depth = 0;
            this.txbUsername_SignUp.Hint = "Tên đăng nhập";
            this.txbUsername_SignUp.Location = new System.Drawing.Point(140, 93);
            this.txbUsername_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbUsername_SignUp.Name = "txbUsername_SignUp";
            this.txbUsername_SignUp.PasswordChar = '\0';
            this.txbUsername_SignUp.SelectedText = "";
            this.txbUsername_SignUp.SelectionLength = 0;
            this.txbUsername_SignUp.SelectionStart = 0;
            this.txbUsername_SignUp.Size = new System.Drawing.Size(188, 23);
            this.txbUsername_SignUp.TabIndex = 10;
            this.txbUsername_SignUp.UseSystemPasswordChar = false;
            // 
            // txbName_SignUp
            // 
            this.txbName_SignUp.Depth = 0;
            this.txbName_SignUp.Hint = "Tên hiển thị";
            this.txbName_SignUp.Location = new System.Drawing.Point(140, 59);
            this.txbName_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txbName_SignUp.Name = "txbName_SignUp";
            this.txbName_SignUp.PasswordChar = '\0';
            this.txbName_SignUp.SelectedText = "";
            this.txbName_SignUp.SelectionLength = 0;
            this.txbName_SignUp.SelectionStart = 0;
            this.txbName_SignUp.Size = new System.Drawing.Size(188, 23);
            this.txbName_SignUp.TabIndex = 10;
            this.txbName_SignUp.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(32, 162);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "rePassword";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(45, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Password";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(385, 106);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Username";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(71, 63);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Name";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(365, 435);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector2);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mạng xã hội";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

=======
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
            this.AcceptButton = this.btnSignIn;
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

>>>>>>> Minh
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignIn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbUsername_SignIn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPassword_SignIn;
        private MaterialSkin.Controls.MaterialLabel lable1;
        private MaterialSkin.Controls.MaterialLabel lable2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbRePassword_SignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbPassword_SignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbUsername_SignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txbName_SignUp;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignUp;
    }
}

