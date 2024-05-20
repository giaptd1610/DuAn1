namespace C_PRL
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label1 = new Label();
            label2 = new Label();
            btn_DangNhap = new Button();
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            log_pwError = new Label();
            log_unError = new Label();
            btn_QMatKhau = new Button();
            label5 = new Label();
            showPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 120);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(284, 209);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 29);
            btn_DangNhap.TabIndex = 2;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(99, 60);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(191, 27);
            txt_TaiKhoan.TabIndex = 3;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(99, 113);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(191, 27);
            txt_MatKhau.TabIndex = 4;
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.KeyDown += Matkhau_KeyDown;
            // 
            // log_pwError
            // 
            log_pwError.AutoSize = true;
            log_pwError.ForeColor = Color.Red;
            log_pwError.Location = new Point(99, 143);
            log_pwError.Name = "log_pwError";
            log_pwError.Size = new Size(42, 20);
            log_pwError.TabIndex = 6;
            log_pwError.Text = "none";
            log_pwError.Visible = false;
            // 
            // log_unError
            // 
            log_unError.AutoSize = true;
            log_unError.ForeColor = Color.Red;
            log_unError.Location = new Point(99, 90);
            log_unError.Name = "log_unError";
            log_unError.Size = new Size(42, 20);
            log_unError.TabIndex = 7;
            log_unError.Text = "none";
            log_unError.Visible = false;
            // 
            // btn_QMatKhau
            // 
            btn_QMatKhau.Location = new Point(152, 209);
            btn_QMatKhau.Name = "btn_QMatKhau";
            btn_QMatKhau.Size = new Size(126, 29);
            btn_QMatKhau.TabIndex = 8;
            btn_QMatKhau.Text = "Quên mật khẩu";
            btn_QMatKhau.UseVisualStyleBackColor = true;
            btn_QMatKhau.Click += btn_QMatKhau_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(148, 37);
            label5.TabIndex = 9;
            label5.Text = "Đăng nhập";
            label5.UseMnemonic = false;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new Point(99, 166);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(127, 24);
            showPassword.TabIndex = 11;
            showPassword.Text = "Hiện mật khẩu";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 250);
            Controls.Add(showPassword);
            Controls.Add(label5);
            Controls.Add(btn_QMatKhau);
            Controls.Add(log_unError);
            Controls.Add(log_pwError);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TaiKhoan);
            Controls.Add(btn_DangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(408, 297);
            MinimumSize = new Size(408, 297);
            Name = "DangNhap";
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_DangNhap;
        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Label log_pwError;
        private Label log_unError;
        private Button btn_QMatKhau;
        private Label label5;
        private CheckBox showPassword;
    }
}