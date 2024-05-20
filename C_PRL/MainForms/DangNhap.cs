using A_DAL.Models;
using B_BUS.Services;
using C_PRL.MainForms;
using C_PRL.SubForms;
using System.ComponentModel;
using System.Linq;

namespace C_PRL
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        NhanvienServices _nhanvienServices = new NhanvienServices();
        ChucvuServices _chucvuServices = new ChucvuServices();
        static Nhanvien nv = new Nhanvien();
        public static Nhanvien Role()
        {
            return nv;
        }
        public bool isNullOrEmty()
        {
            if (string.IsNullOrWhiteSpace(txt_TaiKhoan.Text))
            {
                log_unError.Visible = true; log_unError.Text = "Vui lòng nhập tài khoản!"; return false;
            }
            else log_unError.Visible = false;

            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                log_pwError.Visible = true; log_pwError.Text = "Vui lòng nhập mật khẩu!"; return false;
            }
            else log_pwError.Visible = false;

            return true;
        }
        public void login()
        {

            if (isNullOrEmty())
            {
                var user = _nhanvienServices.GetNhanvienList().Where(nv => nv.Taikhoan == txt_TaiKhoan.Text).FirstOrDefault();
                if (user == null)
                {
                    log_unError.Visible = true; log_unError.Text = "Tài khoản không tồn tại";
                }
                else if (user.Matkhau != txt_MatKhau.Text)
                {
                    log_unError.Visible = false;
                    log_pwError.Visible = true; log_pwError.Text = "Mật khẩu không chính xác";
                }
                else
                {
                    log_pwError.Visible = false;
                    nv = user;
                    this.Hide();
                    var form2 = new MainForm();
                    form2.Show();
                    form2.Closed += (s, args) => this.Close();
                }
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            login();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked) txt_MatKhau.UseSystemPasswordChar = false;
            else txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_QMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void Matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (!_nhanvienServices.GetNhanvienList().Any() && !_chucvuServices.GetAllChucvu().Any())
            {
                Chucvu chucvu = new Chucvu()
                {
                    Machucvu = Guid.NewGuid(),
                    Tenchucvu = "Admin",
                };
                Chucvu chucvu2 = new Chucvu()
                {
                    Machucvu = Guid.NewGuid(),
                    Tenchucvu = "Nhân Viên",
                };
                _chucvuServices.AddChucvu(chucvu);
                _chucvuServices.AddChucvu(chucvu2);
                nv.Manv = "01";
                nv.Hoten = "Admin";
                nv.Gioitinh = "Nam";
                nv.Sdt = "0000000000";
                nv.Email = "a1@mail.com";
                nv.Taikhoan = "admin";
                nv.Matkhau = "12345";
                nv.Chucvu = chucvu.Machucvu;
                nv.Trangthai = "Còn hoạt động";
                _nhanvienServices.AddNhanvien(nv);
            }
        }
    }
}