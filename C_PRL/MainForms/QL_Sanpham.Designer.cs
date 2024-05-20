namespace C_PRL.MainForms
{
    partial class QL_Sanpham
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
            tt_sanpham = new GroupBox();
            btn_themLoaisp = new Button();
            label7 = new Label();
            cb_Loaisp = new ComboBox();
            pictureBox1 = new PictureBox();
            btn_themHinhAnh = new Button();
            btn_chinhSuaSp = new Button();
            btn_xoaSp = new Button();
            btn_themSp = new Button();
            txt_giaban = new TextBox();
            txt_mota = new RichTextBox();
            txt_tensp = new TextBox();
            txt_masp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_sanpham = new DataGridView();
            groupBox3 = new GroupBox();
            btn_lamMoi = new Button();
            btn_timKiem = new Button();
            cb_tkLoaisp = new ComboBox();
            label12 = new Label();
            txt_tkGiaban = new TextBox();
            txt_tkTensp = new TextBox();
            txt_tkMasp = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cb_Trangthai = new ComboBox();
            cb_tkTrangthai = new ComboBox();
            tt_sanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tt_sanpham
            // 
            tt_sanpham.Controls.Add(cb_Trangthai);
            tt_sanpham.Controls.Add(btn_themLoaisp);
            tt_sanpham.Controls.Add(label7);
            tt_sanpham.Controls.Add(cb_Loaisp);
            tt_sanpham.Controls.Add(pictureBox1);
            tt_sanpham.Controls.Add(btn_themHinhAnh);
            tt_sanpham.Controls.Add(btn_chinhSuaSp);
            tt_sanpham.Controls.Add(btn_xoaSp);
            tt_sanpham.Controls.Add(btn_themSp);
            tt_sanpham.Controls.Add(txt_giaban);
            tt_sanpham.Controls.Add(txt_mota);
            tt_sanpham.Controls.Add(txt_tensp);
            tt_sanpham.Controls.Add(txt_masp);
            tt_sanpham.Controls.Add(label6);
            tt_sanpham.Controls.Add(label5);
            tt_sanpham.Controls.Add(label4);
            tt_sanpham.Controls.Add(label3);
            tt_sanpham.Controls.Add(label2);
            tt_sanpham.Controls.Add(label1);
            tt_sanpham.Location = new Point(417, 12);
            tt_sanpham.Name = "tt_sanpham";
            tt_sanpham.Size = new Size(758, 279);
            tt_sanpham.TabIndex = 0;
            tt_sanpham.TabStop = false;
            tt_sanpham.Text = "Thông tin sản phẩm";
            // 
            // btn_themLoaisp
            // 
            btn_themLoaisp.FlatStyle = FlatStyle.System;
            btn_themLoaisp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_themLoaisp.ForeColor = SystemColors.ControlText;
            btn_themLoaisp.ImageAlign = ContentAlignment.TopCenter;
            btn_themLoaisp.Location = new Point(490, 216);
            btn_themLoaisp.Name = "btn_themLoaisp";
            btn_themLoaisp.Size = new Size(33, 28);
            btn_themLoaisp.TabIndex = 13;
            btn_themLoaisp.Text = "+";
            btn_themLoaisp.UseVisualStyleBackColor = true;
            btn_themLoaisp.Click += btn_themLoaisp_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 193);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 17;
            label7.Text = "Loại sản phẩm";
            // 
            // cb_Loaisp
            // 
            cb_Loaisp.FormattingEnabled = true;
            cb_Loaisp.Location = new Point(333, 216);
            cb_Loaisp.Name = "cb_Loaisp";
            cb_Loaisp.Size = new Size(151, 28);
            cb_Loaisp.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(276, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_themHinhAnh
            // 
            btn_themHinhAnh.Location = new Point(115, 155);
            btn_themHinhAnh.Name = "btn_themHinhAnh";
            btn_themHinhAnh.Size = new Size(127, 29);
            btn_themHinhAnh.TabIndex = 10;
            btn_themHinhAnh.Text = "thêm hình ảnh";
            btn_themHinhAnh.UseVisualStyleBackColor = true;
            btn_themHinhAnh.Click += btn_themHinhAnh_Click;
            // 
            // btn_chinhSuaSp
            // 
            btn_chinhSuaSp.Location = new Point(528, 122);
            btn_chinhSuaSp.Name = "btn_chinhSuaSp";
            btn_chinhSuaSp.Size = new Size(94, 29);
            btn_chinhSuaSp.TabIndex = 16;
            btn_chinhSuaSp.Text = "Chỉnh sửa";
            btn_chinhSuaSp.UseVisualStyleBackColor = true;
            btn_chinhSuaSp.Click += btn_chinhSuaSp_Click;
            // 
            // btn_xoaSp
            // 
            btn_xoaSp.Location = new Point(528, 73);
            btn_xoaSp.Name = "btn_xoaSp";
            btn_xoaSp.Size = new Size(94, 29);
            btn_xoaSp.TabIndex = 15;
            btn_xoaSp.Text = "Xoá";
            btn_xoaSp.UseVisualStyleBackColor = true;
            btn_xoaSp.Click += btn_xoaSp_Click;
            // 
            // btn_themSp
            // 
            btn_themSp.Location = new Point(528, 26);
            btn_themSp.Name = "btn_themSp";
            btn_themSp.Size = new Size(94, 29);
            btn_themSp.TabIndex = 14;
            btn_themSp.Text = "Thêm";
            btn_themSp.UseVisualStyleBackColor = true;
            btn_themSp.Click += btn_themSp_Click;
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(115, 86);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(146, 27);
            txt_giaban.TabIndex = 8;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(115, 190);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(212, 83);
            txt_mota.TabIndex = 11;
            txt_mota.Text = "";
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(115, 53);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(146, 27);
            txt_tensp.TabIndex = 7;
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(115, 20);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(146, 27);
            txt_masp.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 190);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 159);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 126);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_sanpham);
            groupBox2.Location = new Point(90, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1085, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(6, 26);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.RowHeadersWidth = 51;
            dgv_sanpham.RowTemplate.Height = 29;
            dgv_sanpham.Size = new Size(1073, 245);
            dgv_sanpham.TabIndex = 0;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb_tkTrangthai);
            groupBox3.Controls.Add(btn_lamMoi);
            groupBox3.Controls.Add(btn_timKiem);
            groupBox3.Controls.Add(cb_tkLoaisp);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txt_tkGiaban);
            groupBox3.Controls.Add(txt_tkTensp);
            groupBox3.Controls.Add(txt_tkMasp);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(96, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 279);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm sản phẩm";
            // 
            // btn_lamMoi
            // 
            btn_lamMoi.Location = new Point(115, 244);
            btn_lamMoi.Name = "btn_lamMoi";
            btn_lamMoi.Size = new Size(94, 29);
            btn_lamMoi.TabIndex = 11;
            btn_lamMoi.Text = "Làm mới";
            btn_lamMoi.UseVisualStyleBackColor = true;
            btn_lamMoi.Click += btn_lamMoi_Click;
            // 
            // btn_timKiem
            // 
            btn_timKiem.Location = new Point(215, 244);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(94, 29);
            btn_timKiem.TabIndex = 10;
            btn_timKiem.Text = "Tìm kiếm";
            btn_timKiem.UseVisualStyleBackColor = true;
            btn_timKiem.Click += btn_timKiem_Click;
            // 
            // cb_tkLoaisp
            // 
            cb_tkLoaisp.FormattingEnabled = true;
            cb_tkLoaisp.Location = new Point(117, 198);
            cb_tkLoaisp.Name = "cb_tkLoaisp";
            cb_tkLoaisp.Size = new Size(156, 28);
            cb_tkLoaisp.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 201);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 8;
            label12.Text = "Loại sản phẩm";
            // 
            // txt_tkGiaban
            // 
            txt_tkGiaban.Location = new Point(117, 113);
            txt_tkGiaban.Name = "txt_tkGiaban";
            txt_tkGiaban.Size = new Size(156, 27);
            txt_tkGiaban.TabIndex = 6;
            // 
            // txt_tkTensp
            // 
            txt_tkTensp.Location = new Point(117, 70);
            txt_tkTensp.Name = "txt_tkTensp";
            txt_tkTensp.Size = new Size(156, 27);
            txt_tkTensp.TabIndex = 5;
            // 
            // txt_tkMasp
            // 
            txt_tkMasp.Location = new Point(117, 27);
            txt_tkMasp.Name = "txt_tkMasp";
            txt_tkMasp.Size = new Size(156, 27);
            txt_tkMasp.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 159);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 3;
            label11.Text = "Trạng thái";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 120);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 2;
            label10.Text = "Giá bán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 77);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 1;
            label9.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 35);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 0;
            label8.Text = "Mã sản phẩm";
            // 
            // cb_Trangthai
            // 
            cb_Trangthai.FormattingEnabled = true;
            cb_Trangthai.Items.AddRange(new object[] { "Bán", "Không bán" });
            cb_Trangthai.Location = new Point(115, 121);
            cb_Trangthai.Name = "cb_Trangthai";
            cb_Trangthai.Size = new Size(146, 28);
            cb_Trangthai.TabIndex = 18;
            // 
            // cb_tkTrangthai
            // 
            cb_tkTrangthai.FormattingEnabled = true;
            cb_tkTrangthai.Items.AddRange(new object[] { "Bán", "Không bán" });
            cb_tkTrangthai.Location = new Point(117, 156);
            cb_tkTrangthai.Name = "cb_tkTrangthai";
            cb_tkTrangthai.Size = new Size(156, 28);
            cb_tkTrangthai.TabIndex = 12;
            // 
            // QL_Sanpham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 586);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(tt_sanpham);
            Name = "QL_Sanpham";
            Text = "QL_Sanpham";
            Load += QL_Sanpham_Load;
            tt_sanpham.ResumeLayout(false);
            tt_sanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox tt_sanpham;
        private TextBox txt_masp;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgv_sanpham;
        private GroupBox groupBox3;
        private TextBox txt_giaban;
        private RichTextBox rtxt_mota;
        private TextBox txt_tensp;
        private Button btn_themHinhAnh;
        private Button btn_chinhSuaSp;
        private Button btn_xoaSp;
        private Button btn_themSp;
        private PictureBox pictureBox1;
        private Button btn_themLoaisp;
        private Label label7;
        private ComboBox cb_Loaisp;
        private RichTextBox txt_mota;
        private TextBox txt_tkGiaban;
        private TextBox txt_tkTensp;
        private TextBox txt_tkMasp;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btn_timKiem;
        private ComboBox cb_tkLoaisp;
        private Label label12;
        private Button btn_lamMoi;
        private ComboBox cb_Trangthai;
        private ComboBox cb_tkTrangthai;
    }
}