namespace C_PRL.SubForms
{
    partial class Sanpham_OnDisplay
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
            pb_image = new PictureBox();
            btn_them = new Button();
            btn_xoa = new Button();
            nud_Soluong = new NumericUpDown();
            lb_tensp = new Label();
            lb_giatien = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Soluong).BeginInit();
            SuspendLayout();
            // 
            // pb_image
            // 
            pb_image.Location = new Point(12, 55);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(147, 120);
            pb_image.TabIndex = 0;
            pb_image.TabStop = false;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(161, 111);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(161, 146);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // nud_Soluong
            // 
            nud_Soluong.Location = new Point(165, 78);
            nud_Soluong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Soluong.Name = "nud_Soluong";
            nud_Soluong.Size = new Size(90, 27);
            nud_Soluong.TabIndex = 3;
            nud_Soluong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lb_tensp
            // 
            lb_tensp.AutoSize = true;
            lb_tensp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tensp.Location = new Point(12, 9);
            lb_tensp.Name = "lb_tensp";
            lb_tensp.Size = new Size(38, 23);
            lb_tensp.TabIndex = 4;
            lb_tensp.Text = "null";
            // 
            // lb_giatien
            // 
            lb_giatien.AutoSize = true;
            lb_giatien.Location = new Point(12, 32);
            lb_giatien.Name = "lb_giatien";
            lb_giatien.Size = new Size(30, 20);
            lb_giatien.TabIndex = 5;
            lb_giatien.Text = "0 đ";
            lb_giatien.TextChanged += lb_giatien_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 55);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Số lượng";
            // 
            // Sanpham_OnDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 191);
            Controls.Add(label1);
            Controls.Add(lb_giatien);
            Controls.Add(lb_tensp);
            Controls.Add(nud_Soluong);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(pb_image);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sanpham_OnDisplay";
            Text = "Sanpham_OnDisplay";
            Load += Sanpham_OnDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Soluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_image;
        private Button btn_them;
        private Button btn_xoa;
        private NumericUpDown nud_Soluong;
        private Label lb_tensp;
        private Label lb_giatien;
        private Label label1;
    }
}