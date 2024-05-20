namespace C_PRL.MainForms
{
    partial class BanHang
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
            pn_spShow = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            btn_xoaSpDachon = new Button();
            lv_spdachon = new ListView();
            groupBox3 = new GroupBox();
            btn_CheckBan = new Button();
            btn_xoaKm = new Button();
            label5 = new Label();
            txt_tiensaukm = new TextBox();
            btn_luuhoadon = new Button();
            btn_taohoadon = new Button();
            txt_tongsotien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_makm = new ComboBox();
            cb_trangthai = new ComboBox();
            txt_mahd = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pn_spShow);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 631);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // pn_spShow
            // 
            pn_spShow.Location = new Point(6, 26);
            pn_spShow.Name = "pn_spShow";
            pn_spShow.Size = new Size(856, 599);
            pn_spShow.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xoaSpDachon);
            groupBox2.Controls.Add(lv_spdachon);
            groupBox2.Location = new Point(889, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm đã chọn";
            // 
            // btn_xoaSpDachon
            // 
            btn_xoaSpDachon.Location = new Point(367, 270);
            btn_xoaSpDachon.Name = "btn_xoaSpDachon";
            btn_xoaSpDachon.Size = new Size(94, 29);
            btn_xoaSpDachon.TabIndex = 1;
            btn_xoaSpDachon.Text = "Xoá";
            btn_xoaSpDachon.UseVisualStyleBackColor = true;
            btn_xoaSpDachon.Click += btn_XoaSpDachon;
            // 
            // lv_spdachon
            // 
            lv_spdachon.Location = new Point(6, 26);
            lv_spdachon.MultiSelect = false;
            lv_spdachon.Name = "lv_spdachon";
            lv_spdachon.Size = new Size(455, 238);
            lv_spdachon.TabIndex = 0;
            lv_spdachon.UseCompatibleStateImageBehavior = false;
            lv_spdachon.View = View.List;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_CheckBan);
            groupBox3.Controls.Add(btn_xoaKm);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txt_tiensaukm);
            groupBox3.Controls.Add(btn_luuhoadon);
            groupBox3.Controls.Add(btn_taohoadon);
            groupBox3.Controls.Add(txt_tongsotien);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cb_makm);
            groupBox3.Controls.Add(cb_trangthai);
            groupBox3.Controls.Add(txt_mahd);
            groupBox3.Location = new Point(889, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 320);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thanh toán";
            // 
            // btn_CheckBan
            // 
            btn_CheckBan.Location = new Point(308, 252);
            btn_CheckBan.Name = "btn_CheckBan";
            btn_CheckBan.Size = new Size(145, 62);
            btn_CheckBan.TabIndex = 12;
            btn_CheckBan.Text = "Xem Bàn";
            btn_CheckBan.UseVisualStyleBackColor = true;
            btn_CheckBan.Click += btn_CheckBan_Click;
            // 
            // btn_xoaKm
            // 
            btn_xoaKm.Location = new Point(338, 91);
            btn_xoaKm.Name = "btn_xoaKm";
            btn_xoaKm.Size = new Size(30, 26);
            btn_xoaKm.TabIndex = 11;
            btn_xoaKm.Text = "x";
            btn_xoaKm.UseVisualStyleBackColor = true;
            btn_xoaKm.Click += btn_clear_km_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 196);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 10;
            label5.Text = "Số tiền qua khuyến mãi";
            // 
            // txt_tiensaukm
            // 
            txt_tiensaukm.Location = new Point(6, 219);
            txt_tiensaukm.Name = "txt_tiensaukm";
            txt_tiensaukm.ReadOnly = true;
            txt_tiensaukm.Size = new Size(261, 27);
            txt_tiensaukm.TabIndex = 9;
            txt_tiensaukm.Text = "0";
            txt_tiensaukm.TextChanged += txt_tiensaukm_TextChanged;
            // 
            // btn_luuhoadon
            // 
            btn_luuhoadon.Location = new Point(157, 253);
            btn_luuhoadon.Name = "btn_luuhoadon";
            btn_luuhoadon.Size = new Size(145, 62);
            btn_luuhoadon.TabIndex = 8;
            btn_luuhoadon.Text = "Lưu hoá đơn";
            btn_luuhoadon.UseVisualStyleBackColor = true;
            btn_luuhoadon.Click += btn_Luuhoadon_Click;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.Location = new Point(6, 252);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(145, 62);
            btn_taohoadon.TabIndex = 7;
            btn_taohoadon.Text = "Tạo hoá đơn";
            btn_taohoadon.UseVisualStyleBackColor = true;
            btn_taohoadon.Click += button1_Click;
            // 
            // txt_tongsotien
            // 
            txt_tongsotien.Location = new Point(6, 151);
            txt_tongsotien.Name = "txt_tongsotien";
            txt_tongsotien.ReadOnly = true;
            txt_tongsotien.Size = new Size(261, 27);
            txt_tongsotien.TabIndex = 6;
            txt_tongsotien.Text = "0";
            txt_tongsotien.TextChanged += txt_tongsotien_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 5;
            label4.Text = "Tổng số tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã khuyến mãi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã hoá đơn";
            // 
            // cb_makm
            // 
            cb_makm.FormattingEnabled = true;
            cb_makm.Location = new Point(151, 91);
            cb_makm.Name = "cb_makm";
            cb_makm.Size = new Size(181, 28);
            cb_makm.TabIndex = 2;
            cb_makm.SelectedIndexChanged += cb_makm_SelectedIndexChanged;
            cb_makm.TextChanged += cb_makm_SelectedTextChanged;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cb_trangthai.Location = new Point(151, 57);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(181, 28);
            cb_trangthai.TabIndex = 1;
            // 
            // txt_mahd
            // 
            txt_mahd.Location = new Point(151, 24);
            txt_mahd.Name = "txt_mahd";
            txt_mahd.ReadOnly = true;
            txt_mahd.Size = new Size(181, 27);
            txt_mahd.TabIndex = 0;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 650);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BanHang";
            Text = "BanHang";
            Load += BanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FlowLayoutPanel pn_spShow;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_makm;
        private ComboBox cb_trangthai;
        private TextBox txt_mahd;
        private Button btn_luuhoadon;
        private Button btn_taohoadon;
        private Label label5;
        private Button btn_xoaKm;
        private Button btn_xoaSpDachon;
        private Button btn_CheckBan;
        static private TextBox txt_tiensaukm;
        static private TextBox txt_tongsotien;
        static private ListView lv_spdachon;
    }
}