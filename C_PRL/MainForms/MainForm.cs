using A_DAL.Models;
using B_BUS.Services;
using C_PRL.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.MainForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static bool Out = false;
        NhanvienServices _nv = new NhanvienServices();
        public static bool Logout()
        {
            return Out;
        }
        public void load_form(Form form)
        {
            if (pn_show.Controls.Count > 0)
            {
                pn_show.Controls.Clear();
            }
            form.TopLevel = false;
            pn_show.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        private void pn_SanPham_Click(object sender, EventArgs e)
        {
            QL_Sanpham qL_Sanpham = new QL_Sanpham();
            load_form(qL_Sanpham);
        }

        private void btn_QL_Nhanvien_Click(object sender, EventArgs e)
        {
            QL_NhanVien qL_Nhanvien = new QL_NhanVien();
            load_form(qL_Nhanvien);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Nhanvien Inv = new Nhanvien();
            ChucvuServices chuvu = new ChucvuServices();
            Inv = DangNhap.Role();
            Guid role = _nv.GetNhanvienList().Where(nv => nv.Manv == Inv.Manv).First().Chucvu;
            Out = false;
            if (chuvu.GetAllChucvu().ToList().Where(cv => cv.Machucvu == role).First().Tenchucvu == "Admin")
            {

            }
            else
            {
                btn_QL_Nhanvien.Visible = false;
                btn_sanpham.Visible = false;
                btn_QL_Calam.Visible = false;
                btn_QL_Hoadon.Visible = false;
                btn_QL_Khuyenmai.Visible = false;
            }
        }

        private void btn_QL_Calam_Click(object sender, EventArgs e)
        {
            QL_CaLam qL_CaLam = new QL_CaLam();
            load_form(qL_CaLam);
        }

        private void btn_QL_Hoadon_Click(object sender, EventArgs e)
        {
            QL_HoaDon qL_HoaDon = new QL_HoaDon();
            load_form(qL_HoaDon);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            this.Hide();
            banHang.Show();
            banHang.FormClosed += (s, args) => this.Show();
        }

        private void btn_QL_Khuyenmai_Click(object sender, EventArgs e)
        {
            QL_KhuyenMai qL_KhuyenMai = new QL_KhuyenMai();
            load_form(qL_KhuyenMai);
        }
    }
}
