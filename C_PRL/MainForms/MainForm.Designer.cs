namespace C_PRL.MainForms
{
    partial class MainForm
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
            btn_sanpham = new Button();
            pn_show = new Panel();
            flp_chucnang = new FlowLayoutPanel();
            btn_BanHang = new Button();
            btn_QL_Nhanvien = new Button();
            btn_QL_Calam = new Button();
            btn_QL_Hoadon = new Button();
            btn_QL_Khuyenmai = new Button();
            flp_chucnang.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sanpham
            // 
            btn_sanpham.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.Location = new Point(3, 68);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(211, 59);
            btn_sanpham.TabIndex = 0;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = true;
            btn_sanpham.Click += pn_SanPham_Click;
            // 
            // pn_show
            // 
            pn_show.Location = new Point(232, 12);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(1276, 633);
            pn_show.TabIndex = 3;
            // 
            // flp_chucnang
            // 
            flp_chucnang.Controls.Add(btn_BanHang);
            flp_chucnang.Controls.Add(btn_sanpham);
            flp_chucnang.Controls.Add(btn_QL_Nhanvien);
            flp_chucnang.Controls.Add(btn_QL_Calam);
            flp_chucnang.Controls.Add(btn_QL_Hoadon);
            flp_chucnang.Controls.Add(btn_QL_Khuyenmai);
            flp_chucnang.Location = new Point(12, 12);
            flp_chucnang.Name = "flp_chucnang";
            flp_chucnang.Size = new Size(214, 396);
            flp_chucnang.TabIndex = 4;
            // 
            // btn_BanHang
            // 
            btn_BanHang.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BanHang.Location = new Point(3, 3);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(211, 59);
            btn_BanHang.TabIndex = 3;
            btn_BanHang.Text = "Bán hàng";
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // btn_QL_Nhanvien
            // 
            btn_QL_Nhanvien.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QL_Nhanvien.Location = new Point(3, 133);
            btn_QL_Nhanvien.Name = "btn_QL_Nhanvien";
            btn_QL_Nhanvien.Size = new Size(211, 59);
            btn_QL_Nhanvien.TabIndex = 1;
            btn_QL_Nhanvien.Text = "Nhân Viên";
            btn_QL_Nhanvien.UseVisualStyleBackColor = true;
            btn_QL_Nhanvien.Click += btn_QL_Nhanvien_Click;
            // 
            // btn_QL_Calam
            // 
            btn_QL_Calam.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QL_Calam.Location = new Point(3, 198);
            btn_QL_Calam.Name = "btn_QL_Calam";
            btn_QL_Calam.Size = new Size(211, 59);
            btn_QL_Calam.TabIndex = 2;
            btn_QL_Calam.Text = "Chấm Công";
            btn_QL_Calam.UseVisualStyleBackColor = true;
            btn_QL_Calam.Click += btn_QL_Calam_Click;
            // 
            // btn_QL_Hoadon
            // 
            btn_QL_Hoadon.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QL_Hoadon.Location = new Point(3, 263);
            btn_QL_Hoadon.Name = "btn_QL_Hoadon";
            btn_QL_Hoadon.Size = new Size(211, 59);
            btn_QL_Hoadon.TabIndex = 4;
            btn_QL_Hoadon.Text = "Hoá đơn";
            btn_QL_Hoadon.UseVisualStyleBackColor = true;
            btn_QL_Hoadon.Click += btn_QL_Hoadon_Click;
            // 
            // btn_QL_Khuyenmai
            // 
            btn_QL_Khuyenmai.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QL_Khuyenmai.Location = new Point(3, 328);
            btn_QL_Khuyenmai.Name = "btn_QL_Khuyenmai";
            btn_QL_Khuyenmai.Size = new Size(211, 59);
            btn_QL_Khuyenmai.TabIndex = 5;
            btn_QL_Khuyenmai.Text = "Khuyến mãi";
            btn_QL_Khuyenmai.UseVisualStyleBackColor = true;
            btn_QL_Khuyenmai.Click += btn_QL_Khuyenmai_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 647);
            Controls.Add(flp_chucnang);
            Controls.Add(pn_show);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Coffew";
            Load += MainForm_Load;
            flp_chucnang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_sanpham;
        private Panel pn_show;
        private FlowLayoutPanel flp_chucnang;
        private Button btn_QL_Nhanvien;
        private Button btn_QL_Calam;
        private Button btn_BanHang;
        private Button btn_QL_Hoadon;
        private Button btn_QL_Khuyenmai;
    }
}