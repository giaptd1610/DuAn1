using A_DAL.Models;
using B_BUS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.MainForms
{
    public partial class QL_NhanVien : Form
    {
        public QL_NhanVien()
        {
            InitializeComponent();
        }
        NhanvienServices? _nhanvienServices = new NhanvienServices();
        ChucvuServices? _chucvuServices = new ChucvuServices();
        Duan1Context? _duan1Context = new Duan1Context();
        public void loadData()
        {
            var nv_cv = (from nv in _nhanvienServices.GetNhanvienList()
                         join cv in _chucvuServices.GetAllChucvu() on nv.Chucvu equals cv.Machucvu
                         select new
                         {
                             Manv = nv.Manv,
                             Tennv = nv.Hoten,
                             Sdt = nv.Sdt,
                             Email = nv.Email,
                             Gioitinh = nv.Gioitinh,
                             chucvu = cv.Tenchucvu,
                             Taikhoan = nv.Taikhoan,
                             Matkhau = nv.Matkhau,
                             Trangthai = nv.Trangthai,
                         }
                ).ToList();
            dgv_nhanVien.DataSource = nv_cv;
        }
        public void loadChucVu()
        {
            if (!_chucvuServices.GetAllChucvu().Any())
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
            }
            cb_chucvu.DataSource = _chucvuServices.GetAllChucvu();
            cb_chucvu.ValueMember = "Machucvu";
            cb_chucvu.DisplayMember = "Tenchucvu";
        }
        public bool IsNullOrEmty()
        {
            if (string.IsNullOrWhiteSpace(txt_Manv.Text) && !Regex.IsMatch(txt_Taikhoan.Text, @"^[a-z0-9]{1,10}$"))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên (Không quá 10 kí tự!)", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Tennv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Error");
                return false;
            }
            if (!Regex.IsMatch(txt_sdt.Text, @"((09|03|07|08|05)+([0-9]{8})\b)"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Vui lòng nhập email", "Error");
                return false;
            }
            if (!Regex.IsMatch(txt_email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("Email không hợp lệ", "Error");
                return false;
            }
            if (!rNam.Checked && !rNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Taikhoan.Text) && !Regex.IsMatch(txt_Taikhoan.Text, @"^[a-z0-9]{1,50}$"))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Error");
                return false;
            }
            if (cb_Trangthai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái của tài khoản", "Error");
                return false;
            }
            return true;
        }
        public bool isDuplicate()
        {
            if (_nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Manv.ToLower().Contains(txt_Manv.Text.ToLower())).FirstOrDefault() != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại\nVui lòng nhập lại mã nhân viên");
                return false;
            }
            if (_nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Sdt.Contains(txt_sdt.Text)).FirstOrDefault() != null)
            {
                MessageBox.Show("Số điện thoại đã tồn tại\n Vui lòng nhập lại số điện thoại");
                return false;
            }
            if (_nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Email.ToLower().Contains(txt_email.Text.ToLower())).FirstOrDefault() != null)
            {
                MessageBox.Show("Email đã tồn tại\n Vui lòng nhập tại Email");
                return false;
            }
            if (_nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Taikhoan.ToLower().Contains(txt_Taikhoan.Text.ToLower())).FirstOrDefault() != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại\n Vui lòng nhập lại tài khoản");
                return false;
            }
            return true;
        }
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            loadChucVu();
            loadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string gt;
            if (IsNullOrEmty() && isDuplicate())
            {
                if (rNam.Checked)
                {
                    gt = rNam.Text;
                }
                else gt = rNu.Text;
                Nhanvien nhanvien = new Nhanvien()
                {
                    Manv = txt_Manv.Text,
                    Hoten = txt_Tennv.Text,
                    Sdt = txt_sdt.Text,
                    Email = txt_email.Text,
                    Gioitinh = gt,
                    Taikhoan = txt_Taikhoan.Text,
                    Matkhau = txt_Matkhau.Text,
                    Chucvu = Guid.Parse(cb_chucvu.SelectedValue.ToString()),
                    Trangthai = cb_Trangthai.SelectedItem.ToString(),
                };
                _nhanvienServices.AddNhanvien(nhanvien);
            }
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Manv.Text) ||
                _nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Manv.ToLower().Contains(txt_Manv.Text.ToLower())).FirstOrDefault() != null
                )
            {
                if (MessageBox.Show("Bạn có muốn xoá nhân viên này không?\nNếu xoá thì nhân viên không thể đăng nhập vào hệ thống được nữa!"
                    , "Cảnh báo"
                    , MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _nhanvienServices.DeleteNhanvien(txt_Manv.Text);
                }
            }
            else MessageBox.Show("Mã nhân viên không tồn tại!\nVui lòng nhập mã nhân viên khác");
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gt;
            if (IsNullOrEmty())
            {
                if (_nhanvienServices.GetNhanvienList().ToList().Where(nv => nv.Manv.ToLower().Contains(txt_Manv.Text.ToLower())).FirstOrDefault() != null)
                {
                    if (rNam.Checked)
                    {
                        gt = rNam.Text;
                    }
                    else gt = rNu.Text;
                    var nhanvien = _nhanvienServices.GetNhanvienById(txt_Manv.Text);
                    nhanvien.Hoten = txt_Tennv.Text;
                    nhanvien.Sdt = txt_sdt.Text;
                    nhanvien.Email = txt_email.Text;
                    nhanvien.Gioitinh = gt;
                    nhanvien.Taikhoan = txt_Taikhoan.Text;
                    nhanvien.Matkhau = txt_Matkhau.Text;
                    nhanvien.Chucvu = Guid.Parse(cb_chucvu.SelectedValue.ToString());
                    nhanvien.Trangthai = cb_Trangthai.SelectedItem.ToString();
                    _nhanvienServices.UpdateNhanvien(nhanvien);
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại\n Vui lòng nhập mã nhân viên khác!");
                }
            }
            loadData();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txt_Manv.Text = string.Empty;
            txt_Tennv.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_Taikhoan.Text = string.Empty;
            txt_Matkhau.Text = string.Empty;
            loadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string? manv, tennv, email, sdt, Email, chucvu, gioitinh, taikhoan, matkhau, trangthai;
            if (string.IsNullOrWhiteSpace(txt_Manv.Text) && Regex.IsMatch(txt_Manv.Text, @"^[a-z0-9]{1,10}$"))
            {
                manv = "";
            }
            else manv = $" manv = N'{txt_Manv.Text}' and ";

            if (string.IsNullOrWhiteSpace(txt_Tennv.Text))
            {
                tennv = "";
            }
            else tennv = $" hoten = N'{txt_Tennv.Text}' and ";

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                Email = "";
            }
            else Email = $" email = '{txt_email.Text}' and";

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                sdt = "";
            }
            else sdt = $" sdt = '{txt_sdt.Text}' and ";

            if (string.IsNullOrWhiteSpace(cb_chucvu.SelectedValue.ToString()))
            {
                chucvu = "";
            }
            else chucvu = $" chucvu = N'{cb_chucvu.SelectedValue.ToString()}' and ";

            if (rNam.Checked)
            {
                gioitinh = $" gioitinh = 'Nam' and ";
            }
            else if (rNu.Checked)
            {
                gioitinh = $" gioitinh = N'Nữ' and ";
            }
            else gioitinh = "";

            if (string.IsNullOrWhiteSpace(txt_Taikhoan.Text))
            {
                taikhoan = "";
            }
            else taikhoan = $" taikhoan = N'{txt_Taikhoan.Text}' and ";

            if (string.IsNullOrWhiteSpace(txt_Matkhau.Text))
            {
                matkhau = "";
            }
            else matkhau = $" matkhau = N'{txt_Matkhau.Text}' and ";

            if (cb_Trangthai.SelectedItem == null)
            {
                trangthai = "";
            }
            else trangthai = $" trangthai = N'{cb_Trangthai.SelectedItem.ToString()}' and ";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_duan1Context.connectiongString()))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from nhanvien "
                    + "Where " + manv + tennv + sdt + Email + chucvu + gioitinh + taikhoan + matkhau + trangthai + " manv = manv "
                    );
                sqlCommand.Connection = con;
                con.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    con.Close();
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bug : \n\n" + ex);
                }
            };
            List<Nhanvien> nhanviens = new List<Nhanvien>();
            foreach (DataRow row in dt.Rows)
            {
                Nhanvien nv = new Nhanvien();
                nv.Manv = row["Manv"].ToString();
                nv.Hoten = row["Hoten"].ToString();
                nv.Email = row["Email"].ToString();
                nv.Sdt = row["Sdt"].ToString();
                nv.Gioitinh = row["Gioitinh"].ToString();
                nv.Chucvu = Guid.Parse(row["Chucvu"].ToString());
                nv.Taikhoan = row["Taikhoan"].ToString();
                nv.Matkhau = row["Matkhau"].ToString();
                nv.Trangthai = row["Trangthai"].ToString();
                nhanviens.Add(nv);
            }
            var nvAfter = (from nv in nhanviens
                           join cv in _chucvuServices.GetAllChucvu() on nv.Chucvu equals cv.Machucvu
                           select new
                           {
                               Manv = nv.Manv,
                               Tennv = nv.Hoten,
                               Sdt = nv.Sdt,
                               Email = nv.Email,
                               Gioitinh = nv.Gioitinh,
                               chucvu = cv.Tenchucvu,
                               Taikhoan = nv.Taikhoan,
                               Matkhau = nv.Matkhau,
                               Trangthai = nv.Trangthai,
                           }
                ).ToList();
            dgv_nhanVien.DataSource = nvAfter;
        }

        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_Manv.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Tennv.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_sdt.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_email.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgv_nhanVien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
                {
                    rNam.Select();
                }
                else rNu.Select();
                cb_chucvu.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_Taikhoan.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_Matkhau.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                cb_Trangthai.Text = dgv_nhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }
    }
}
