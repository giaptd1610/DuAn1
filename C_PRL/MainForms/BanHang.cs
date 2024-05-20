using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using C_PRL.SubForms;
using Microsoft.EntityFrameworkCore.Query;
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

namespace C_PRL.MainForms
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        static SanphamServices _sanphamServices = new SanphamServices();
        static HoadonServices _hoadonServices = new HoadonServices();
        static HoadonchitietServices _hoadonchitietServices = new HoadonchitietServices();
        KhuyenmaiServices? khuyenmaiServices = new KhuyenmaiServices();
        static Guid Mahoadon;
        static decimal tongtien = 0;
        static List<Hoadonchitiet> spDachon = new List<Hoadonchitiet>();
        static int? soptgiam;
        static decimal? sotiengiam;
        public static Guid MaHD()
        {
            return Mahoadon;
        }
        public void load_form(Form form)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.None;
            form.FormBorderStyle = FormBorderStyle.None;
            pn_spShow.Controls.Add(form);
        }
        public void LoadSp()
        {
            pn_spShow.Controls.Clear();
            if (_sanphamServices.GetAllSanpham() != null)
            {
                foreach (var item in _sanphamServices.GetAllSanpham())
                {
                    Sanpham_OnDisplay sanpham_OnDisplay = new Sanpham_OnDisplay(item.Masp, item.Hinhanh, item.Tensp, item.Giaban, _hoadonchitietServices);
                    load_form(sanpham_OnDisplay);
                };
            }
        }

        static public void AfterKm(decimal? tongtien)
        {
            if (txt_tongsotien.Text != "0")
            {
                if (soptgiam > 0)
                {
                    tongtien = (decimal.Parse(tongtien.ToString()) - (decimal.Parse(tongtien.ToString()) * soptgiam) / 100);
                }
                if (tongtien != 0 && tongtien > sotiengiam)
                {
                    if (sotiengiam > 0 && soptgiam > 0)
                    {
                        tongtien = tongtien - sotiengiam;
                    }
                    else if (sotiengiam > 0 && soptgiam <= 0)
                    {
                        tongtien = tongtien - sotiengiam;
                    }
                }
            }
            else
            {
                tongtien = 0;
            }
            txt_tiensaukm.Text = ((int)tongtien).ToString();
        }
        public void loadKm()
        {
            if (khuyenmaiServices.GetAllKhuyenmai() != null)
            {
                var kmAvaiable = khuyenmaiServices.GetAllKhuyenmai().ToList().Where(km => km.Ngaybd.Value < DateTime.Today && km.Ngaykt.Value > DateTime.Today).ToList();
                cb_makm.DataSource = kmAvaiable;
                cb_makm.DisplayMember = "Tenkm";
                cb_makm.ValueMember = "Makm";
                cb_makm_SelectedIndexChanged(null, null);
            }
        }

        public bool validate()
        {
            if (cb_trangthai == null || string.IsNullOrWhiteSpace(cb_trangthai.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái của hoá đơn");
                return false;
            }
            return true;
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            loadKm();
            lv_spdachon.MultiSelect = false;
            cb_trangthai.SelectedItem = cb_trangthai.Items[1];
            btn_luuhoadon.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv = DangNhap.Role();
            LoadSp();
            if (validate())
            {
                Hoadon hoadon = new Hoadon()
                {
                    Mahd = Guid.NewGuid(),
                    Ngaytaohd = DateTime.Today,
                    Ngaythanhtoan = null,
                    Trangthai = cb_trangthai.SelectedItem.ToString(),
                    Tongtien = decimal.Parse(txt_tiensaukm.Text),
                    Manv = nv.Manv,
                    Makm = cb_makm.SelectedValue == null ? null : cb_makm.SelectedValue.ToString(),
                };
                _hoadonServices.AddHoadon(hoadon);
                Mahoadon = hoadon.Mahd;
                txt_mahd.Text = hoadon.Mahd.ToString();
                cb_trangthai.Text = hoadon.Trangthai.ToString();
                txt_tongsotien.Text = hoadon.Tongtien.ToString();
                load_hoadonchitet();
            }
            btn_taohoadon.Enabled = false;
            btn_luuhoadon.Enabled = true;
        }

        static public void load_hoadonchitet()
        {
            if (lv_spdachon.Items.Count > 0)
            {
                lv_spdachon.Items.Clear();
                spDachon.Clear();
                tongtien = 0;
            }
            if (_hoadonchitietServices.GetAllHoadonchitet().Where(hdtct => hdtct.Mahd == Mahoadon).Any())
            {
                foreach (var item in _hoadonchitietServices.GetAllHoadonchitet().Where(hdtct => hdtct.Mahd == Mahoadon))
                {
                    Sanpham sanpham = new Sanpham();
                    sanpham = _sanphamServices.GetSanphamById(item.Masp);
                    CultureInfo culture = new CultureInfo("en-US");
                    decimal value = decimal.Parse(((int)item.Dongia).ToString(), NumberStyles.AllowThousands);
                    var gia = String.Format(culture, "{0:N0}", value);
                    lv_spdachon.Items.Add($"{sanpham.Tensp} - SL : {item.Soluong} - Giá: {gia}");
                    tongtien = tongtien + item.Dongia;
                    spDachon.Add(item);
                }
                txt_tongsotien.Text = ((int)tongtien).ToString();
                AfterKm(tongtien);
            }
            else
            {
                tongtien = 0;
                txt_tongsotien.Text = ((int)tongtien).ToString();
                AfterKm(tongtien);
            }
        }
        private void txt_tongsotien_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txt_tongsotien.Text, NumberStyles.AllowThousands);
            txt_tongsotien.Text = String.Format(culture, "{0:N0}", value);
            txt_tongsotien.Select(txt_tongsotien.Text.Length, 0);
        }

        private void txt_tiensaukm_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txt_tiensaukm.Text, NumberStyles.AllowThousands);
            txt_tiensaukm.Text = String.Format(culture, "{0:N0}", value);
            txt_tiensaukm.Select(txt_tiensaukm.Text.Length, 0);
        }

        private void btn_XoaSpDachon(object sender, EventArgs e)
        {
            if (lv_spdachon.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xoá", "Missing");

            }
            else
            {
                var index = lv_spdachon.FocusedItem.Index;
                _hoadonchitietServices.DeleteHoadonchitiet(Mahoadon, spDachon[index].Masp);
                load_hoadonchitet();
            }
        }

        private void btn_Luuhoadon_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv = DangNhap.Role();
            if (_hoadonServices.GetHoadonById(MaHD()) != null)
            {
                Hoadon hoadon = new Hoadon();
                hoadon = _hoadonServices.GetHoadonById(MaHD());
                hoadon.Ngaytaohd = DateTime.Today;
                if (cb_trangthai.SelectedItem.ToString() == "Đã thanh toán")
                {
                    hoadon.Ngaythanhtoan = DateTime.Today;
                }
                else
                {
                    hoadon.Ngaythanhtoan = null;
                }
                hoadon.Trangthai = cb_trangthai.SelectedItem.ToString();
                hoadon.Tongtien = decimal.Parse(txt_tiensaukm.Text);
                hoadon.Manv = nv.Manv;
                if (cb_makm.SelectedValue == null)
                {
                    hoadon.Makm = null;
                }
                else { hoadon.Makm = cb_makm.SelectedValue.ToString(); }
                _hoadonServices.UpdateHoadon(hoadon);
                if(MessageBox.Show("Bạn có muốn thêm hoá đơn này vào bàn nào không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Ban_Hoadon ban_Hoadon = new Ban_Hoadon();
                    ban_Hoadon.ShowDialog();
                }
                Mahoadon = new Guid();
                txt_mahd.Text = null;
                cb_trangthai.Text = hoadon.Trangthai.ToString();
                tongtien = 0;
                txt_tongsotien.Text = ((int)tongtien).ToString();
                txt_tiensaukm.Text = ((int)tongtien).ToString();
                pn_spShow.Controls.Clear();
                lv_spdachon.Items.Clear();
                lv_spdachon.Refresh();
            }
            btn_luuhoadon.Enabled = false;
            btn_taohoadon.Enabled = true;
        }

        private void cb_makm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_makm.Text == null || cb_makm.SelectedValue == null)
            {
                sotiengiam = 0;
                soptgiam = 0;
            }
            else
            {
                if (khuyenmaiServices.GetAllKhuyenmai().ToList().Where(km => km.Makm == cb_makm.SelectedValue.ToString()).Any())
                {
                    var km = khuyenmaiServices.GetAllKhuyenmai().ToList().Where(km => km.Makm == cb_makm.SelectedValue.ToString()).First();
                    sotiengiam = km.Sotiengiam;
                    soptgiam = km.Soptgiam;
                    load_hoadonchitet();

                }
            }
        }

        private void cb_makm_SelectedTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_makm.Text))
            {
                cb_makm.SelectedValue = "";
                sotiengiam = 0;
                soptgiam = 0;
                load_hoadonchitet();
            }
        }
        private void btn_clear_km_Click(object sender, EventArgs e)
        {
            cb_makm.Text = "";
            cb_makm.SelectedValue = "";
        }

        private void btn_CheckBan_Click(object sender, EventArgs e)
        {
            Ban_Hoadon ban_hoadon = new Ban_Hoadon();
            ban_hoadon.Show();
        }
    }
}
