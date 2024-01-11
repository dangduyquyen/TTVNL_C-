namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 93);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbUserName.Location = new Point(223, 36);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(380, 30);
            txbUserName.TabIndex = 1;
            txbUserName.Text = "K9";
            txbUserName.TextChanged += txbUserName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassWord);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 93);
            panel2.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbPassWord.Location = new Point(223, 36);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(380, 30);
            txbPassWord.TabIndex = 1;
            txbPassWord.Text = "1";
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 37);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(379, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 38);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(518, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 38);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(640, 323);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbPassWord;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
    }
}