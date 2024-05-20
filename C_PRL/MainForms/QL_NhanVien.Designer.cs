namespace C_PRL.MainForms
{
    partial class QL_NhanVien
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
            groupBox2 = new GroupBox();
            dgv_nhanVien = new DataGridView();
            gr_ttnv = new GroupBox();
            cb_Trangthai = new ComboBox();
            btn_timkiem = new Button();
            btn_Lammoi = new Button();
            rNu = new RadioButton();
            rNam = new RadioButton();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_them = new Button();
            cb_chucvu = new ComboBox();
            txt_Matkhau = new TextBox();
            txt_Taikhoan = new TextBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            txt_Tennv = new TextBox();
            txt_Manv = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanVien).BeginInit();
            gr_ttnv.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_nhanVien);
            groupBox2.Location = new Point(12, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1234, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgv_nhanVien
            // 
            dgv_nhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhanVien.Location = new Point(10, 26);
            dgv_nhanVien.Name = "dgv_nhanVien";
            dgv_nhanVien.RowHeadersWidth = 51;
            dgv_nhanVien.RowTemplate.Height = 29;
            dgv_nhanVien.Size = new Size(1218, 233);
            dgv_nhanVien.TabIndex = 0;
            dgv_nhanVien.CellClick += dgv_nhanVien_CellClick;
            // 
            // gr_ttnv
            // 
            gr_ttnv.Controls.Add(cb_Trangthai);
            gr_ttnv.Controls.Add(btn_timkiem);
            gr_ttnv.Controls.Add(btn_Lammoi);
            gr_ttnv.Controls.Add(rNu);
            gr_ttnv.Controls.Add(rNam);
            gr_ttnv.Controls.Add(btn_Xoa);
            gr_ttnv.Controls.Add(btn_Sua);
            gr_ttnv.Controls.Add(btn_them);
            gr_ttnv.Controls.Add(cb_chucvu);
            gr_ttnv.Controls.Add(txt_Matkhau);
            gr_ttnv.Controls.Add(txt_Taikhoan);
            gr_ttnv.Controls.Add(txt_email);
            gr_ttnv.Controls.Add(txt_sdt);
            gr_ttnv.Controls.Add(txt_Tennv);
            gr_ttnv.Controls.Add(txt_Manv);
            gr_ttnv.Controls.Add(label9);
            gr_ttnv.Controls.Add(label8);
            gr_ttnv.Controls.Add(label7);
            gr_ttnv.Controls.Add(label6);
            gr_ttnv.Controls.Add(label5);
            gr_ttnv.Controls.Add(label4);
            gr_ttnv.Controls.Add(label3);
            gr_ttnv.Controls.Add(label2);
            gr_ttnv.Controls.Add(label1);
            gr_ttnv.Location = new Point(12, 12);
            gr_ttnv.Name = "gr_ttnv";
            gr_ttnv.Size = new Size(748, 291);
            gr_ttnv.TabIndex = 2;
            gr_ttnv.TabStop = false;
            gr_ttnv.Text = "Thông tin nhân viên";
            // 
            // cb_Trangthai
            // 
            cb_Trangthai.FormattingEnabled = true;
            cb_Trangthai.Items.AddRange(new object[] { "Còn hoạt động", "Đã nghỉ" });
            cb_Trangthai.Location = new Point(381, 167);
            cb_Trangthai.Name = "cb_Trangthai";
            cb_Trangthai.Size = new Size(151, 28);
            cb_Trangthai.TabIndex = 26;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(648, 256);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 25;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // btn_Lammoi
            // 
            btn_Lammoi.Location = new Point(548, 256);
            btn_Lammoi.Name = "btn_Lammoi";
            btn_Lammoi.Size = new Size(94, 29);
            btn_Lammoi.TabIndex = 24;
            btn_Lammoi.Text = "Làm mới";
            btn_Lammoi.UseVisualStyleBackColor = true;
            btn_Lammoi.Click += btn_Lammoi_Click;
            // 
            // rNu
            // 
            rNu.AutoSize = true;
            rNu.Location = new Point(183, 167);
            rNu.Name = "rNu";
            rNu.Size = new Size(50, 24);
            rNu.TabIndex = 23;
            rNu.TabStop = true;
            rNu.Text = "Nữ";
            rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            rNam.AutoSize = true;
            rNam.Location = new Point(115, 167);
            rNam.Name = "rNam";
            rNam.Size = new Size(62, 24);
            rNam.TabIndex = 22;
            rNam.TabStop = true;
            rNam.Text = "Nam";
            rNam.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(572, 164);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 20;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(572, 112);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 19;
            btn_Sua.Text = "Chỉnh sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(572, 60);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 18;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // cb_chucvu
            // 
            cb_chucvu.FormattingEnabled = true;
            cb_chucvu.Location = new Point(111, 203);
            cb_chucvu.Name = "cb_chucvu";
            cb_chucvu.Size = new Size(146, 28);
            cb_chucvu.TabIndex = 17;
            // 
            // txt_Matkhau
            // 
            txt_Matkhau.Location = new Point(381, 108);
            txt_Matkhau.Name = "txt_Matkhau";
            txt_Matkhau.Size = new Size(152, 27);
            txt_Matkhau.TabIndex = 15;
            // 
            // txt_Taikhoan
            // 
            txt_Taikhoan.Location = new Point(381, 57);
            txt_Taikhoan.Name = "txt_Taikhoan";
            txt_Taikhoan.Size = new Size(152, 27);
            txt_Taikhoan.TabIndex = 14;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(111, 123);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(146, 27);
            txt_email.TabIndex = 13;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(111, 90);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(146, 27);
            txt_sdt.TabIndex = 12;
            // 
            // txt_Tennv
            // 
            txt_Tennv.Location = new Point(111, 57);
            txt_Tennv.Name = "txt_Tennv";
            txt_Tennv.Size = new Size(146, 27);
            txt_Tennv.TabIndex = 10;
            // 
            // txt_Manv
            // 
            txt_Manv.Location = new Point(111, 24);
            txt_Manv.Name = "txt_Manv";
            txt_Manv.Size = new Size(146, 27);
            txt_Manv.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(300, 169);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 8;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(300, 115);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 60);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 6;
            label7.Text = "Tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 130);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 206);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 97);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // QL_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 586);
            Controls.Add(gr_ttnv);
            Controls.Add(groupBox2);
            Name = "QL_NhanVien";
            Text = "QL_NhanVien";
            Load += QL_NhanVien_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_nhanVien).EndInit();
            gr_ttnv.ResumeLayout(false);
            gr_ttnv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox gr_ttnv;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_them;
        private ComboBox cb_chucvu;
        private TextBox txt_Matkhau;
        private TextBox txt_Taikhoan;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private TextBox txt_Tennv;
        private TextBox txt_Manv;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private RadioButton rNam;
        private RadioButton rNu;
        private Button btn_timkiem;
        private Button btn_Lammoi;
        private DataGridView dgv_nhanVien;
        private ComboBox cb_Trangthai;
    }
}