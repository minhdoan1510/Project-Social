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

