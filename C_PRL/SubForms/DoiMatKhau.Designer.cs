namespace C_PRL.SubForms
{
    partial class DoiMatKhau
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
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            txt_nhaplaimk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_sainhaplaimk = new Label();
            btn_doimk = new Button();
            hienMatkhau = new CheckBox();
            SuspendLayout();
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(148, 12);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.ReadOnly = true;
            txt_taikhoan.Size = new Size(179, 27);
            txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(148, 45);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(179, 27);
            txt_matkhau.TabIndex = 1;
            txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_nhaplaimk
            // 
            txt_nhaplaimk.Location = new Point(148, 78);
            txt_nhaplaimk.Name = "txt_nhaplaimk";
            txt_nhaplaimk.Size = new Size(179, 27);
            txt_nhaplaimk.TabIndex = 2;
            txt_nhaplaimk.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // lb_sainhaplaimk
            // 
            lb_sainhaplaimk.AutoSize = true;
            lb_sainhaplaimk.ForeColor = Color.Red;
            lb_sainhaplaimk.Location = new Point(148, 108);
            lb_sainhaplaimk.Name = "lb_sainhaplaimk";
            lb_sainhaplaimk.Size = new Size(50, 20);
            lb_sainhaplaimk.TabIndex = 8;
            lb_sainhaplaimk.Text = "label6";
            // 
            // btn_doimk
            // 
            btn_doimk.Location = new Point(189, 173);
            btn_doimk.Name = "btn_doimk";
            btn_doimk.Size = new Size(143, 39);
            btn_doimk.TabIndex = 9;
            btn_doimk.Text = "Đổi mật khẩu";
            btn_doimk.UseVisualStyleBackColor = true;
            btn_doimk.Click += btn_doimk_Click;
            // 
            // hienMatkhau
            // 
            hienMatkhau.AutoSize = true;
            hienMatkhau.Location = new Point(148, 131);
            hienMatkhau.Name = "hienMatkhau";
            hienMatkhau.Size = new Size(127, 24);
            hienMatkhau.TabIndex = 11;
            hienMatkhau.Text = "Hiện mật khẩu";
            hienMatkhau.UseVisualStyleBackColor = true;
            hienMatkhau.CheckedChanged += hienMatkhau_CheckedChanged;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 224);
            Controls.Add(hienMatkhau);
            Controls.Add(btn_doimk);
            Controls.Add(lb_sainhaplaimk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_nhaplaimk);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private TextBox txt_nhaplaimk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_saitk;
        private Label lb_sainhaplaimk;
        private Button btn_doimk;
        private CheckBox hienMatkhau;
    }
}