namespace C_PRL.MainForms
{
    partial class QL_KhuyenMai
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
            btn_them = new Button();
            btn_Sua = new Button();
            btn_xoa = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_makhuyenmai = new TextBox();
            txt_tenkhuyenmai = new TextBox();
            txt_mota = new TextBox();
            txt_Phantram = new TextBox();
            txt_Sotien = new TextBox();
            txt_Dieukien = new TextBox();
            dtp_Ngaybatdau = new DateTimePicker();
            dtp_NgayKt = new DateTimePicker();
            dgv_KhuyenMai = new DataGridView();
            btn_clear = new Button();
            label3 = new Label();
            dtp_ngaytao = new DateTimePicker();
            c1 = new GroupBox();
            c = new Label();
            txt_search = new TextBox();
            groupBox1 = new GroupBox();
            h = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_KhuyenMai).BeginInit();
            c1.SuspendLayout();
            groupBox1.SuspendLayout();
            h.SuspendLayout();
            SuspendLayout();
            // 
            // btn_them
            // 
            btn_them.Location = new Point(41, 29);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(130, 40);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(41, 91);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(130, 42);
            btn_Sua.TabIndex = 2;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(41, 151);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(130, 45);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã khuyến mãi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 55);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên khuyến mãi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 128);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 164);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 196);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 10;
            label6.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 25);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 11;
            label7.Text = "Phần trăm giảm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 62);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 12;
            label8.Text = "Số tiền giảm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 102);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 13;
            label9.Text = "Điều kiện";
            // 
            // txt_makhuyenmai
            // 
            txt_makhuyenmai.Location = new Point(124, 22);
            txt_makhuyenmai.Name = "txt_makhuyenmai";
            txt_makhuyenmai.Size = new Size(250, 27);
            txt_makhuyenmai.TabIndex = 14;
            // 
            // txt_tenkhuyenmai
            // 
            txt_tenkhuyenmai.Location = new Point(124, 55);
            txt_tenkhuyenmai.Name = "txt_tenkhuyenmai";
            txt_tenkhuyenmai.Size = new Size(250, 27);
            txt_tenkhuyenmai.TabIndex = 15;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(124, 197);
            txt_mota.Multiline = true;
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(250, 73);
            txt_mota.TabIndex = 19;
            // 
            // txt_Phantram
            // 
            txt_Phantram.Location = new Point(502, 18);
            txt_Phantram.Name = "txt_Phantram";
            txt_Phantram.Size = new Size(151, 27);
            txt_Phantram.TabIndex = 20;
            // 
            // txt_Sotien
            // 
            txt_Sotien.Location = new Point(502, 59);
            txt_Sotien.Name = "txt_Sotien";
            txt_Sotien.Size = new Size(151, 27);
            txt_Sotien.TabIndex = 21;
            // 
            // txt_Dieukien
            // 
            txt_Dieukien.Location = new Point(502, 95);
            txt_Dieukien.Multiline = true;
            txt_Dieukien.Name = "txt_Dieukien";
            txt_Dieukien.Size = new Size(238, 75);
            txt_Dieukien.TabIndex = 22;
            // 
            // dtp_Ngaybatdau
            // 
            dtp_Ngaybatdau.CustomFormat = "MM/dd/yyyy";
            dtp_Ngaybatdau.Format = DateTimePickerFormat.Custom;
            dtp_Ngaybatdau.Location = new Point(124, 132);
            dtp_Ngaybatdau.Name = "dtp_Ngaybatdau";
            dtp_Ngaybatdau.Size = new Size(125, 27);
            dtp_Ngaybatdau.TabIndex = 24;
            // 
            // dtp_NgayKt
            // 
            dtp_NgayKt.CustomFormat = "MM/dd/yyyy";
            dtp_NgayKt.Format = DateTimePickerFormat.Custom;
            dtp_NgayKt.Location = new Point(124, 165);
            dtp_NgayKt.Name = "dtp_NgayKt";
            dtp_NgayKt.Size = new Size(125, 27);
            dtp_NgayKt.TabIndex = 25;
            // 
            // dgv_KhuyenMai
            // 
            dgv_KhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KhuyenMai.Location = new Point(0, 26);
            dgv_KhuyenMai.Name = "dgv_KhuyenMai";
            dgv_KhuyenMai.RowHeadersWidth = 51;
            dgv_KhuyenMai.RowTemplate.Height = 29;
            dgv_KhuyenMai.Size = new Size(969, 253);
            dgv_KhuyenMai.TabIndex = 26;
            dgv_KhuyenMai.CellClick += dgv_KhuyenMai_CellClick;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(41, 213);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(130, 40);
            btn_clear.TabIndex = 28;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 94);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày tạo";
            // 
            // dtp_ngaytao
            // 
            dtp_ngaytao.CustomFormat = "MM/dd/yyyy";
            dtp_ngaytao.Format = DateTimePickerFormat.Custom;
            dtp_ngaytao.Location = new Point(124, 94);
            dtp_ngaytao.Name = "dtp_ngaytao";
            dtp_ngaytao.Size = new Size(125, 27);
            dtp_ngaytao.TabIndex = 23;
            // 
            // c1
            // 
            c1.Controls.Add(c);
            c1.Controls.Add(txt_search);
            c1.Controls.Add(txt_tenkhuyenmai);
            c1.Controls.Add(label1);
            c1.Controls.Add(label2);
            c1.Controls.Add(dtp_NgayKt);
            c1.Controls.Add(label3);
            c1.Controls.Add(dtp_Ngaybatdau);
            c1.Controls.Add(label4);
            c1.Controls.Add(dtp_ngaytao);
            c1.Controls.Add(label5);
            c1.Controls.Add(txt_Dieukien);
            c1.Controls.Add(label6);
            c1.Controls.Add(txt_Sotien);
            c1.Controls.Add(label7);
            c1.Controls.Add(txt_Phantram);
            c1.Controls.Add(label8);
            c1.Controls.Add(txt_mota);
            c1.Controls.Add(label9);
            c1.Controls.Add(txt_makhuyenmai);
            c1.Location = new Point(6, -1);
            c1.Name = "c1";
            c1.Size = new Size(743, 279);
            c1.TabIndex = 29;
            c1.TabStop = false;
            c1.Text = "Thông tin";
            // 
            // c
            // 
            c.AutoSize = true;
            c.Location = new Point(392, 199);
            c.Name = "c";
            c.Size = new Size(70, 20);
            c.TabIndex = 30;
            c.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(502, 196);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Tìm kiếm tên khuyến mãi";
            txt_search.Size = new Size(238, 27);
            txt_search.TabIndex = 29;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Location = new Point(764, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 279);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // h
            // 
            h.Controls.Add(dgv_KhuyenMai);
            h.Location = new Point(6, 284);
            h.Name = "h";
            h.Size = new Size(975, 285);
            h.TabIndex = 31;
            h.TabStop = false;
            h.Text = "Danh sách khuyến mãi";
            // 
            // QL_KhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 581);
            Controls.Add(h);
            Controls.Add(groupBox1);
            Controls.Add(c1);
            Name = "QL_KhuyenMai";
            Text = "QL_KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)dgv_KhuyenMai).EndInit();
            c1.ResumeLayout(false);
            c1.PerformLayout();
            groupBox1.ResumeLayout(false);
            h.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_them;
        private Button btn_Sua;
        private Button btn_xoa;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_makhuyenmai;
        private TextBox txt_tenkhuyenmai;
        private TextBox txt_mota;
        private TextBox txt_Phantram;
        private TextBox txt_Sotien;
        private TextBox txt_Dieukien;
        private DateTimePicker dtp_Ngaybatdau;
        private DateTimePicker dtp_NgayKt;
        private DataGridView dgv_KhuyenMai;
        private Button btn_clear;
        private Label label3;
        private DateTimePicker dtp_ngaytao;
        private GroupBox c1;
        private TextBox txt_search;
        private Label c;
        private GroupBox groupBox1;
        private GroupBox h;
    }
}