namespace C_PRL.SubForms
{
    partial class QuenMatKhau
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
            txt_maxn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Emailkp = new TextBox();
            btn_gui = new Button();
            btn_xacnhan = new Button();
            SuspendLayout();
            // 
            // txt_maxn
            // 
            txt_maxn.Location = new Point(132, 63);
            txt_maxn.Name = "txt_maxn";
            txt_maxn.Size = new Size(141, 27);
            txt_maxn.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Email khôi phục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã xác nhận";
            // 
            // txt_Emailkp
            // 
            txt_Emailkp.Location = new Point(132, 16);
            txt_Emailkp.Name = "txt_Emailkp";
            txt_Emailkp.Size = new Size(248, 27);
            txt_Emailkp.TabIndex = 3;
            // 
            // btn_gui
            // 
            btn_gui.Location = new Point(198, 107);
            btn_gui.Name = "btn_gui";
            btn_gui.Size = new Size(94, 29);
            btn_gui.TabIndex = 4;
            btn_gui.Text = "Gửi mã";
            btn_gui.UseVisualStyleBackColor = true;
            btn_gui.Click += btn_gui_Click;
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.Location = new Point(301, 107);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new Size(94, 29);
            btn_xacnhan.TabIndex = 5;
            btn_xacnhan.Text = "Xác nhận";
            btn_xacnhan.UseVisualStyleBackColor = true;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 146);
            Controls.Add(btn_xacnhan);
            Controls.Add(btn_gui);
            Controls.Add(txt_Emailkp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_maxn);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_maxn;
        private Label label1;
        private Label label2;
        private TextBox txt_Emailkp;
        private Button btn_gui;
        private Button btn_xacnhan;
    }
}