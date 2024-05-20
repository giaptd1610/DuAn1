namespace C_PRL.MainForms
{
    partial class QL_HoaDon
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
            groupBox1 = new GroupBox();
            btn_timkiem = new Button();
            txt_manv = new TextBox();
            label7 = new Label();
            btn_xoa = new Button();
            btn_sua = new Button();
            cb_trangthai = new ComboBox();
            dtp_ngaythanhtoan = new DateTimePicker();
            dtp_ngaytao = new DateTimePicker();
            txt_makm = new TextBox();
            txt_tongtien = new TextBox();
            txt_mahd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_hoadon = new DataGridView();
            groupBox3 = new GroupBox();
            lv_sanpham = new ListView();
            btn_lammoi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_timkiem);
            groupBox1.Controls.Add(txt_manv);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(cb_trangthai);
            groupBox1.Controls.Add(dtp_ngaythanhtoan);
            groupBox1.Controls.Add(dtp_ngaytao);
            groupBox1.Controls.Add(txt_makm);
            groupBox1.Controls.Add(txt_tongtien);
            groupBox1.Controls.Add(txt_mahd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hoá đơn";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(425, 150);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(157, 59);
            btn_timkiem.TabIndex = 17;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(153, 230);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(125, 27);
            txt_manv.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 237);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 15;
            label7.Text = "Nhân viên phụ trách";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(425, 85);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(157, 59);
            btn_xoa.TabIndex = 14;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(425, 19);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(157, 59);
            btn_sua.TabIndex = 13;
            btn_sua.Text = "Chỉnh sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cb_trangthai.Location = new Point(153, 163);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(162, 28);
            cb_trangthai.TabIndex = 12;
            // 
            // dtp_ngaythanhtoan
            // 
            dtp_ngaythanhtoan.CustomFormat = "MM-dd-yyyy";
            dtp_ngaythanhtoan.Format = DateTimePickerFormat.Custom;
            dtp_ngaythanhtoan.Location = new Point(153, 97);
            dtp_ngaythanhtoan.Name = "dtp_ngaythanhtoan";
            dtp_ngaythanhtoan.Size = new Size(162, 27);
            dtp_ngaythanhtoan.TabIndex = 11;
            // 
            // dtp_ngaytao
            // 
            dtp_ngaytao.CustomFormat = "MM-dd-yyyy";
            dtp_ngaytao.Format = DateTimePickerFormat.Custom;
            dtp_ngaytao.Location = new Point(153, 64);
            dtp_ngaytao.Name = "dtp_ngaytao";
            dtp_ngaytao.Size = new Size(162, 27);
            dtp_ngaytao.TabIndex = 10;
            // 
            // txt_makm
            // 
            txt_makm.Location = new Point(153, 197);
            txt_makm.Name = "txt_makm";
            txt_makm.Size = new Size(125, 27);
            txt_makm.TabIndex = 9;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(153, 130);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(125, 27);
            txt_tongtien.TabIndex = 7;
            txt_tongtien.TextChanged += txt_tongtien_TextChanged;
            // 
            // txt_mahd
            // 
            txt_mahd.Location = new Point(153, 31);
            txt_mahd.Name = "txt_mahd";
            txt_mahd.Size = new Size(162, 27);
            txt_mahd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 204);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã khuyến mãi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 171);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá trị hoá đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày tạo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hoá đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_hoadon);
            groupBox2.Location = new Point(12, 302);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1234, 272);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hoá đơn";
            // 
            // dgv_hoadon
            // 
            dgv_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoadon.Location = new Point(6, 26);
            dgv_hoadon.Name = "dgv_hoadon";
            dgv_hoadon.RowHeadersWidth = 51;
            dgv_hoadon.RowTemplate.Height = 29;
            dgv_hoadon.Size = new Size(1222, 240);
            dgv_hoadon.TabIndex = 0;
            dgv_hoadon.CellClick += dgv_hoadon_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lv_sanpham);
            groupBox3.Location = new Point(606, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(640, 284);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // lv_sanpham
            // 
            lv_sanpham.Location = new Point(6, 26);
            lv_sanpham.Name = "lv_sanpham";
            lv_sanpham.Size = new Size(628, 252);
            lv_sanpham.TabIndex = 0;
            lv_sanpham.UseCompatibleStateImageBehavior = false;
            lv_sanpham.View = View.List;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(425, 215);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(157, 58);
            btn_lammoi.TabIndex = 18;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // QL_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 586);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QL_HoaDon";
            Text = "QL_HoaDon";
            Load += QL_HoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_hoadon;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_tongtien;
        private TextBox txt_mahd;
        private Button btn_xoa;
        private Button btn_sua;
        private ComboBox cb_trangthai;
        private DateTimePicker dtp_ngaythanhtoan;
        private DateTimePicker dtp_ngaytao;
        private TextBox txt_makm;
        private GroupBox groupBox3;
        private ListView lv_sanpham;
        private TextBox txt_manv;
        private Label label7;
        private Button btn_timkiem;
        private Button btn_lammoi;
    }
}