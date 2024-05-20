namespace C_PRL.SubForms
{
    partial class QL_Phucap
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
            btn_xoapc = new Button();
            btn_suapc = new Button();
            btn_thempc = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_sotienpc = new TextBox();
            txt_tenpc = new TextBox();
            groupBox2 = new GroupBox();
            dgv_phucap = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_phucap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_xoapc);
            groupBox1.Controls.Add(btn_suapc);
            groupBox1.Controls.Add(btn_thempc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_sotienpc);
            groupBox1.Controls.Add(txt_tenpc);
            groupBox1.Location = new Point(12, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phụ cấp";
            // 
            // btn_xoapc
            // 
            btn_xoapc.Location = new Point(262, 122);
            btn_xoapc.Name = "btn_xoapc";
            btn_xoapc.Size = new Size(94, 29);
            btn_xoapc.TabIndex = 6;
            btn_xoapc.Text = "Xoá";
            btn_xoapc.UseVisualStyleBackColor = true;
            btn_xoapc.Click += btn_xoapc_Click;
            // 
            // btn_suapc
            // 
            btn_suapc.Location = new Point(164, 122);
            btn_suapc.Name = "btn_suapc";
            btn_suapc.Size = new Size(94, 29);
            btn_suapc.TabIndex = 5;
            btn_suapc.Text = "Chỉnh sửa";
            btn_suapc.UseVisualStyleBackColor = true;
            btn_suapc.Click += btn_suapc_Click;
            // 
            // btn_thempc
            // 
            btn_thempc.Location = new Point(64, 122);
            btn_thempc.Name = "btn_thempc";
            btn_thempc.Size = new Size(94, 29);
            btn_thempc.TabIndex = 4;
            btn_thempc.Text = "Thêm";
            btn_thempc.UseVisualStyleBackColor = true;
            btn_thempc.Click += btn_thempc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "Số tiền trợ cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên phụ cấp";
            // 
            // txt_sotienpc
            // 
            txt_sotienpc.Location = new Point(123, 71);
            txt_sotienpc.Name = "txt_sotienpc";
            txt_sotienpc.Size = new Size(178, 27);
            txt_sotienpc.TabIndex = 1;
            // 
            // txt_tenpc
            // 
            txt_tenpc.Location = new Point(123, 38);
            txt_tenpc.Name = "txt_tenpc";
            txt_tenpc.Size = new Size(178, 27);
            txt_tenpc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_phucap);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 197);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phụ cấp";
            // 
            // dgv_phucap
            // 
            dgv_phucap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_phucap.Location = new Point(6, 26);
            dgv_phucap.Name = "dgv_phucap";
            dgv_phucap.RowHeadersWidth = 51;
            dgv_phucap.RowTemplate.Height = 29;
            dgv_phucap.Size = new Size(350, 165);
            dgv_phucap.TabIndex = 0;
            dgv_phucap.CellClick += dgv_phucap_CellClick;
            // 
            // QL_Phucap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 382);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QL_Phucap";
            Text = "QL_Phucap";
            Load += QL_Phucap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_phucap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_sotienpc;
        private TextBox txt_tenpc;
        private GroupBox groupBox2;
        private DataGridView dgv_phucap;
        private Label label2;
        private Label label1;
        private Button btn_xoapc;
        private Button btn_suapc;
        private Button btn_thempc;
    }
}