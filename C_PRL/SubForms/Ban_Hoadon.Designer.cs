namespace C_PRL.SubForms
{
    partial class Ban_Hoadon
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
            dgv_coNguoi = new DataGridView();
            dgv_khongCoNguoi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_ThemBanHd = new Button();
            btn_XoaBanHd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_coNguoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_khongCoNguoi).BeginInit();
            SuspendLayout();
            // 
            // dgv_coNguoi
            // 
            dgv_coNguoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_coNguoi.Location = new Point(12, 48);
            dgv_coNguoi.Name = "dgv_coNguoi";
            dgv_coNguoi.RowHeadersWidth = 51;
            dgv_coNguoi.RowTemplate.Height = 29;
            dgv_coNguoi.Size = new Size(460, 288);
            dgv_coNguoi.TabIndex = 0;
            dgv_coNguoi.CellClick += dgv_coNguoi_CellClick;
            // 
            // dgv_khongCoNguoi
            // 
            dgv_khongCoNguoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_khongCoNguoi.Location = new Point(513, 49);
            dgv_khongCoNguoi.Name = "dgv_khongCoNguoi";
            dgv_khongCoNguoi.RowHeadersWidth = 51;
            dgv_khongCoNguoi.RowTemplate.Height = 29;
            dgv_khongCoNguoi.Size = new Size(316, 288);
            dgv_khongCoNguoi.TabIndex = 1;
            dgv_khongCoNguoi.CellClick += dgv_khongCoNguoi_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Có người";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 26);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Không có người";
            // 
            // btn_ThemBanHd
            // 
            btn_ThemBanHd.Location = new Point(835, 49);
            btn_ThemBanHd.Name = "btn_ThemBanHd";
            btn_ThemBanHd.Size = new Size(131, 63);
            btn_ThemBanHd.TabIndex = 4;
            btn_ThemBanHd.Text = "Thêm vào";
            btn_ThemBanHd.UseVisualStyleBackColor = true;
            btn_ThemBanHd.Click += button1_Click;
            // 
            // btn_XoaBanHd
            // 
            btn_XoaBanHd.Location = new Point(835, 118);
            btn_XoaBanHd.Name = "btn_XoaBanHd";
            btn_XoaBanHd.Size = new Size(131, 63);
            btn_XoaBanHd.TabIndex = 5;
            btn_XoaBanHd.Text = "Chuyển";
            btn_XoaBanHd.UseVisualStyleBackColor = true;
            btn_XoaBanHd.Click += btn_XoaBanHd_Click;
            // 
            // Ban_Hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 349);
            Controls.Add(btn_XoaBanHd);
            Controls.Add(btn_ThemBanHd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_khongCoNguoi);
            Controls.Add(dgv_coNguoi);
            Name = "Ban_Hoadon";
            Text = "Ban_Hoadon";
            Load += Ban_Hoadon_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_coNguoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_khongCoNguoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_coNguoi;
        private DataGridView dgv_khongCoNguoi;
        private Label label1;
        private Label label2;
        private Button btn_ThemBanHd;
        private Button btn_XoaBanHd;
    }
}