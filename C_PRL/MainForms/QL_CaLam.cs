using A_DAL.Models;
using B_BUS.Services;
using C_PRL.SubForms;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text.RegularExpressions;

namespace C_PRL.MainForms
{
    public partial class QL_CaLam : Form
    {
        public QL_CaLam()
        {
            InitializeComponent();
        }
        CalamServices? _caLamServices = new CalamServices();
        NhanvienServices? _nhanvienServices = new NhanvienServices();
        ChucvuServices? _chucvuServices = new ChucvuServices();
        public void loadCb()
        {
            var chucvu = _chucvuServices.GetAllChucvu().ToList().Where(cv => cv.Tenchucvu == "Nhân Viên").FirstOrDefault().Machucvu;
            cb_cManv.DataSource = _nhanvienServices.GetNhanvienList().Where(nv => nv.Chucvu == chucvu && nv.Trangthai == "Còn hoạt động").ToList();
            cb_cManv.DisplayMember = "Manv";
            cb_cManv.ValueMember = "Manv";
            cb_lManv.DataSource = _nhanvienServices.GetNhanvienList().Where(nv => nv.Chucvu == chucvu && nv.Trangthai == "Còn hoạt động").ToList();
            cb_lManv.DisplayMember = "Manv";
            cb_lManv.ValueMember = "Manv";
        }
        public void loadCaLam()
        {
            var calam = (from cl in _caLamServices.GetAllCalam()
                         orderby cl.Ngaylamviec ascending
                         select new
                         {
                             Maca = cl.Maca,
                             Giobd = cl.Giobd,
                             Giokt = cl.Giokt,
                             Ngaylamviec = cl.Ngaylamviec.ToString("MM/dd/yyyy"),
                             Manv = cl.Manv,
                         }
                         ).ToList();
            dgv_calam.DataSource = calam;
        }
        public bool isNullOrEmty()
        {
            if (string.IsNullOrWhiteSpace(txt_Maca.Text) && Regex.IsMatch(txt_Maca.Text, @"^[a-z0-9]{1,10}$"))
            {
                MessageBox.Show("Vui lòng thêm mã ca", "Missing");
                return false;
            }
            if (_caLamServices.GetAllCalam().ToList().Where(cl => cl.Maca == txt_Maca.Text).Any())
            {
                MessageBox.Show("Mã ca này đã tồn tại", "Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cb_cManv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Missing");
                return false;
            }
            if (((nud_giokt.Value * 60) + nud_phutkt.Value) - ((nud_giobd.Value * 60) + nud_phutbd.Value) < 1)
            {
                MessageBox.Show("Giờ bắt đầu và giờ kết thúc không hợp lệ", "Error");
                return false;
            }
            if (dtp_ngayLamViec.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày làm việc phải trong tương lai", "Error");
                return false;
            }
            return true;
        }

        public bool ForUpdate()
        {
            if (string.IsNullOrWhiteSpace(txt_Maca.Text) && Regex.IsMatch(txt_Maca.Text, @"^[a-z0-9]{1,10}$"))
            {
                MessageBox.Show("Vui lòng thêm mã ca", "Missing");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cb_cManv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Missing");
                return false;
            }
            if (((nud_giokt.Value * 60) + nud_phutkt.Value) - ((nud_giobd.Value * 60) + nud_phutbd.Value) < 1)
            {
                MessageBox.Show("Giờ bắt đầu và giờ kết thúc không hợp lệ", "Error");
                return false;
            }
            if (dtp_ngayLamViec.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày làm việc phải trong tương lai", "Error");
                return false;
            }
            return true;
        }
        private void btn_cthem_Click(object sender, EventArgs e)
        {
            if (isNullOrEmty())
            {
                TimeOnly giobatdau = new TimeOnly(Int32.Parse(nud_giobd.Value.ToString()), Int32.Parse(nud_phutbd.Value.ToString()));
                TimeOnly gioketthuc = new TimeOnly(Int32.Parse(nud_giokt.Value.ToString()), Int32.Parse(nud_phutkt.Value.ToString()));
                Calam calam = new Calam()
                {
                    Maca = txt_Maca.Text,
                    Manv = cb_cManv.SelectedValue.ToString(),
                    Giobd = TimeSpan.Parse(giobatdau.ToString("HH:mm")),
                    Giokt = TimeSpan.Parse(gioketthuc.ToString("HH:mm")),
                    Ngaylamviec = dtp_ngayLamViec.Value
                };
                _caLamServices.AddCalam(calam);
            }
            loadCaLam();
        }

        private void QL_CaLam_Load(object sender, EventArgs e)
        {
            dtp_ngayLamViec.Format = DateTimePickerFormat.Custom;
            dtp_Ngaytra.Format = DateTimePickerFormat.Custom;
            dtp_ngayLamViec.CustomFormat = "MM-dd-yyyy";
            dtp_Ngaytra.CustomFormat = "MM-dd-yyyy";
            loadCaLam();
            loadCb();
            LoadLuong();
            LoadListView();
        }

        private void btn_csua_Click(object sender, EventArgs e)
        {
            if (ForUpdate())
            {
                if (_caLamServices.GetAllCalam().ToList().Where(cl => cl.Maca == txt_Maca.Text).Any())
                {
                    TimeOnly giobatdau = new TimeOnly(Int32.Parse(nud_giobd.Value.ToString()), Int32.Parse(nud_phutbd.Value.ToString()));
                    TimeOnly gioketthuc = new TimeOnly(Int32.Parse(nud_giokt.Value.ToString()), Int32.Parse(nud_phutkt.Value.ToString()));
                    Calam calam = new Calam();
                    calam = _caLamServices.GetCalamById(txt_Maca.Text);
                    calam.Manv = cb_cManv.SelectedValue.ToString();
                    calam.Giobd = TimeSpan.Parse(giobatdau.ToString("HH:mm"));
                    calam.Giokt = TimeSpan.Parse(gioketthuc.ToString("HH:mm"));
                    calam.Ngaylamviec = dtp_ngayLamViec.Value;
                    _caLamServices.UpdateCalam(calam);
                }
            }
            loadCaLam();
        }

        private void btn_cxoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Maca.Text))
            {
                if (_caLamServices.GetAllCalam().ToList().Where(cl => cl.Maca == txt_Maca.Text).Any())
                {
                    _caLamServices.DeleteCalam(txt_Maca.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ca làm này!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã ca!", "Missing");
            }
            loadCaLam();
        }

        private void dgv_calam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                TimeSpan tgBatdau = TimeSpan.Parse(dgv_calam.Rows[e.RowIndex].Cells[1].Value.ToString());
                TimeSpan tgKetthuc = TimeSpan.Parse(dgv_calam.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_Maca.Text = dgv_calam.Rows[e.RowIndex].Cells[0].Value.ToString();
                nud_giobd.Value = int.Parse(tgBatdau.Hours.ToString());
                nud_phutbd.Value = int.Parse(tgBatdau.Minutes.ToString());
                nud_giokt.Value = int.Parse(tgKetthuc.Hours.ToString());
                nud_phutkt.Value = int.Parse(tgKetthuc.Minutes.ToString());
                dtp_ngayLamViec.Text = DateTime.Parse(dgv_calam.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("MM-dd-yyyy");
                cb_cManv.Text = dgv_calam.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        //Luong -------------------------------------------------------------------------------
        LuongServices _luongServices = new LuongServices();
        PhucapServices _phucapServices = new PhucapServices();
        int luongtheogio;
        int sotienpc;
        private void btn_themphucap_Click(object sender, EventArgs e)
        {
            QL_Phucap qL_Phucap = new QL_Phucap();
            qL_Phucap.Show();
            qL_Phucap.FormClosed += QL_Phucap_FormClosed;
        }

        private void QL_Phucap_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadListView();
        }

        public void LoadLuong()
        {
            var dataLuong = (from l in _luongServices.GetAllLuong()
                             select new
                             {
                                 Maluong = l.Maluong,
                                 Manv = l.Manv,
                                 Sotien = l.Sotien,
                                 Ngaytra = l.Ngaytra?.ToString("MM-dd-yyyy"),
                             }).ToList();
            dgv_bangLuong.DataSource = dataLuong;
        }
        public void LoadListView()
        {
            lv_phucap.Items.Clear();
            foreach (var item in _phucapServices.GetAllPhucap())
            {
                lv_phucap.Items.Add(item.Tenphucap.ToString());
            }
        }
        public bool validate()
        {
            if (dtp_Ngaytra.Value < DateTime.Now)
            {
                MessageBox.Show("Không thể chọn ngày trong quá khứ!");
            }
            return true;
        }
        private void btn_Lthem_Click(object sender, EventArgs e)
        {
            var calam = _caLamServices.GetAllCalam().Where(cl => cl.Manv == cb_lManv.SelectedValue.ToString()).ToList();
            int thoigianlam = 0;
            foreach (var item in calam)
            {
                thoigianlam = thoigianlam + (
                    (int.Parse(item.Giokt.Hours.ToString()) * 60 + int.Parse(item.Giokt.Minutes.ToString())) -
                    (int.Parse(item.Giobd.Hours.ToString()) * 60 + int.Parse(item.Giobd.Minutes.ToString()))
                    );
            }
            int sogiolam = thoigianlam / 60;
            int Luongtheogio = sogiolam * 30000;
            Luong luong = new Luong()
            {
                Maluong = Guid.NewGuid(),
                Manv = cb_cManv.SelectedValue.ToString(),
                Ngaytra = dtp_Ngaytra.Value,
                Sotien = decimal.Parse(txt_tienluong.Text),
            };
            _luongServices.AddLuong(luong);
            LoadLuong();
        }
        private void cb_lManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var calam = _caLamServices.GetAllCalam().Where(cl => cl.Manv == cb_lManv.SelectedValue.ToString()).ToList();
            int thoigianlam = 0;
            foreach (var item in calam)
            {
                thoigianlam = thoigianlam + (
                    (int.Parse(item.Giokt.Hours.ToString()) * 60 + int.Parse(item.Giokt.Minutes.ToString())) -
                    (int.Parse(item.Giobd.Hours.ToString()) * 60 + int.Parse(item.Giobd.Minutes.ToString()))
                    );
            }
            int sogiolam = thoigianlam / 60;
            luongtheogio = sogiolam * 30000;
            LoadListView();
            txt_tienluong.Text = luongtheogio.ToString();
        }

        private void txt_tienluong_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txt_tienluong.Text, NumberStyles.AllowThousands);
            txt_tienluong.Text = String.Format(culture, "{0:N0}", value);
            txt_tienluong.Select(txt_tienluong.Text.Length, 0);
        }

        private void lv_phucap_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var selectedTags = lv_phucap.CheckedItems
                                 .Cast<ListViewItem>()
                                 .Select(x => x.Text);
            sotienpc = 0;
            if (selectedTags.Count() > 0)
            {
                foreach (var item in selectedTags)
                {
                    sotienpc = sotienpc + (int)_phucapServices.GetAllPhucap().Where(pc => pc.Tenphucap.Equals(item)).First().Sotienphucap;
                }
            }
            txt_tienluong.Text = int.Parse((luongtheogio + sotienpc).ToString()).ToString();
        }

        private void dgv_bangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                LoadListView();
                txt_Maluong.Text = dgv_bangLuong.Rows[e.RowIndex].Cells[0].Value.ToString();
                decimal sotien = decimal.Parse(dgv_bangLuong.Rows[e.RowIndex].Cells[2].Value.ToString());
                cb_lManv.Text = dgv_bangLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_tienluong.Text = (int.Parse(((int)sotien).ToString())).ToString();
                dtp_Ngaytra.Text = DateTime.Parse(dgv_bangLuong.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("MM-dd-yyyy");
            }
        }

        private void btn_Lsua_Click(object sender, EventArgs e)
        {
            var calam = _caLamServices.GetAllCalam().Where(cl => cl.Manv == cb_lManv.SelectedValue.ToString()).ToList();
            int thoigianlam = 0;
            foreach (var item in calam)
            {
                thoigianlam = thoigianlam + (
                    (int.Parse(item.Giokt.Hours.ToString()) * 60 + int.Parse(item.Giokt.Minutes.ToString())) -
                    (int.Parse(item.Giobd.Hours.ToString()) * 60 + int.Parse(item.Giobd.Minutes.ToString()))
                    );
            }
            int sogiolam = thoigianlam / 60;
            int Luongtheogio = sogiolam * 30000;
            if (!string.IsNullOrWhiteSpace(txt_Maluong.Text))
            {
                if (_luongServices.GetAllLuong().Where(l => l.Maluong == Guid.Parse(txt_Maluong.Text)).Any())
                {
                    Luong luong = new Luong();
                    luong = _luongServices.GetAllLuong().Where(l => l.Maluong == Guid.Parse(txt_Maluong.Text)).First();
                    luong.Maluong = Guid.NewGuid();
                    luong.Manv = cb_cManv.SelectedValue.ToString();
                    luong.Ngaytra = dtp_Ngaytra.Value;
                    luong.Sotien = decimal.Parse(txt_tienluong.Text);
                    _luongServices.UpdateLuong(luong); 
                }
                else MessageBox.Show("Dữ liệu về lương này không tồn tại", "Error");
            }
            else MessageBox.Show("Vui lòng chọn mã lương!", "Missing");
            LoadLuong();
        }

        private void btn_Lxoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Maluong.Text))
            {
                if (_luongServices.GetAllLuong().Where(l => l.Maluong == Guid.Parse(txt_Maluong.Text)).Any())
                {
                    if (MessageBox.Show("Bạn có muốn xoá dữ liệu về lương này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        _luongServices.DeleteLuong(Guid.Parse(txt_Maluong.Text));
                    } 
                }else MessageBox.Show("Dữ liệu về lương này không tồn tại", "Error");
            }
            else MessageBox.Show("Vui lòng chọn mã lương!", "Missing");
            LoadLuong();
        }
    }
}
