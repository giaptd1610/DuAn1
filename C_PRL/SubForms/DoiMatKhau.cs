using A_DAL.Models;
using B_BUS.Services;
using C_PRL.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.SubForms
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        public Nhanvien _nv = new Nhanvien();
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Text = _nv.Taikhoan;
            lb_sainhaplaimk.Visible = false;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == txt_nhaplaimk.Text)
            {
                NhanvienServices nhanvienServices = new NhanvienServices();
                _nv.Matkhau = txt_matkhau.Text;
                nhanvienServices.UpdateNhanvien(_nv);
                this.Close();
            }
            else
            {
                lb_sainhaplaimk.Text = "Nhập lại mật khẩu bị sai";
                lb_sainhaplaimk.Visible = true;
            }
        }

        private void hienMatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (hienMatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
                txt_nhaplaimk.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
                txt_nhaplaimk.UseSystemPasswordChar = true;
            }
        }
    }
}
