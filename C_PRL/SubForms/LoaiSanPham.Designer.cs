namespace C_PRL.SubForms
{
    partial class LoaiSanPham
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
            label1 = new Label();
            label2 = new Label();
            txt_tenLoaisp = new TextBox();
            txt_mota = new RichTextBox();
            dgv_loaisanpham = new DataGridView();
            btn_them = new Button();
            btn_chinhsua = new Button();
            btn_xoa = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_loaisanpham).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 72);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // txt_tenLoaisp
            // 
            txt_tenLoaisp.Location = new Point(112, 24);
            txt_tenLoaisp.Name = "txt_tenLoaisp";
            txt_tenLoaisp.Size = new Size(139, 27);
            txt_tenLoaisp.TabIndex = 2;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(112, 69);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(232, 103);
            txt_mota.TabIndex = 3;
            txt_mota.Text = "";
            // 
            // dgv_loaisanpham
            // 
            dgv_loaisanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_loaisanpham.Location = new Point(5, 25);
            dgv_loaisanpham.Name = "dgv_loaisanpham";
            dgv_loaisanpham.RowHeadersWidth = 51;
            dgv_loaisanpham.RowTemplate.Height = 29;
            dgv_loaisanpham.Size = new Size(480, 157);
            dgv_loaisanpham.TabIndex = 4;
            dgv_loaisanpham.CellClick += dgv_loaisanpham_CellClick;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(387, 37);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 5;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_chinhsua
            // 
            btn_chinhsua.Location = new Point(387, 72);
            btn_chinhsua.Name = "btn_chinhsua";
            btn_chinhsua.Size = new Size(94, 29);
            btn_chinhsua.TabIndex = 6;
            btn_chinhsua.Text = "Chỉnh sửa";
            btn_chinhsua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(387, 107);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 7;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_loaisanpham);
            groupBox1.Location = new Point(8, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 193);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // LoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 389);
            Controls.Add(groupBox1);
            Controls.Add(btn_xoa);
            Controls.Add(btn_chinhsua);
            Controls.Add(btn_them);
            Controls.Add(txt_mota);
            Controls.Add(txt_tenLoaisp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoaiSanPham";
            Text = "LoaiSanPham";
            Load += LoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_loaisanpham).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_tenLoaisp;
        private RichTextBox txt_mota;
        private DataGridView dgv_loaisanpham;
        private Button btn_them;
        private Button btn_chinhsua;
        private Button btn_xoa;
        private GroupBox groupBox1;
    }
}