using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.MainForms
{
    public partial class QL_HoaDon : Form
    {
        public QL_HoaDon()
        {
            InitializeComponent();
        }

        HoadonServices _hoadonServices = new HoadonServices();
        HoadonchitietServices _hoadonchitietServices = new HoadonchitietServices();
        SanphamServices _sanphamServices = new SanphamServices();
        Duan1Context _duan1Context = new Duan1Context();
        public void LoadDgv()
        {
            var dgv_source = (from hd in _hoadonServices.GetHoadonAll()
                              orderby hd.Ngaytaohd ascending
                              select new
                              {
                                  Mahd = hd.Mahd,
                                  Ngaytaohd = hd.Ngaytaohd.ToString("MM-dd-yyyy"),
                                  Ngaythanhtoan = hd.Ngaythanhtoan?.ToString("MM-dd-yyyy"),
                                  Tongtien = hd.Tongtien,
                                  Trangthai = hd.Trangthai,
                                  Manv = hd.Manv,
                                  Makm = hd.Makm,
                              }
                ).ToList();
            dgv_hoadon.DataSource = dgv_source;
        }

        private void QL_HoaDon_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var r = dgv_hoadon.Rows[e.RowIndex];
                txt_mahd.Text = r.Cells[0].Value.ToString();
                dtp_ngaytao.Text = DateTime.Parse(r.Cells[1].Value.ToString()).ToString();
                dtp_ngaythanhtoan.Text = r.Cells[2].Value == null ? DateTime.Today.ToString() : DateTime.Parse(r.Cells[2].Value.ToString()).ToString();
                cb_trangthai.Text = r.Cells[4].Value.ToString();
                txt_manv.Text = r.Cells[5].Value.ToString();
                txt_makm.Text = r.Cells[6].Value == null ? "" : r.Cells[6].Value.ToString();
                if (lv_sanpham.Items.Count > 0)
                {
                    lv_sanpham.Items.Clear();
                }
                if (_hoadonchitietServices.GetAllHoadonchitet().Where(hdtct => hdtct.Mahd == Guid.Parse(r.Cells[0].Value.ToString())).Any())
                {
                    foreach (var item in _hoadonchitietServices.GetAllHoadonchitet().Where(hdtct => hdtct.Mahd == Guid.Parse(r.Cells[0].Value.ToString())))
                    {
                        Sanpham sanpham = new Sanpham();
                        sanpham = _sanphamServices.GetSanphamById(item.Masp);
                        CultureInfo culture = new CultureInfo("en-US");
                        decimal value = decimal.Parse(((int)item.Dongia).ToString(), NumberStyles.AllowThousands);
                        var gia = String.Format(culture, "{0:N0}", value);
                        lv_sanpham.Items.Add($"{sanpham.Tensp} - SL : {item.Soluong} - Giá: {gia}");
                    }
                }
                txt_tongtien.Text = ((int)Math.Round((decimal)r.Cells[3].Value)).ToString();
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_tongtien.Text))
            {
                CultureInfo culture = new CultureInfo("en-US");
                decimal value = decimal.Parse(txt_tongtien.Text, NumberStyles.AllowThousands);
                txt_tongtien.Text = String.Format(culture, "{0:N0}", value);
                txt_tongtien.Select(txt_tongtien.Text.Length, 0);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mahd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn", "Missing");
                return;
            }
            Guid Mahoadon;
            if (Guid.TryParse(txt_mahd.Text, out Mahoadon))
            {
                if (_hoadonServices.GetHoadonById(Mahoadon) != null)
                {
                    var hoadon = _hoadonServices.GetHoadonById(Mahoadon);
                    hoadon.Ngaytaohd = hoadon.Ngaytaohd;
                    hoadon.Tongtien = hoadon.Tongtien;
                    hoadon.Trangthai = cb_trangthai.SelectedItem == null ? hoadon.Trangthai : cb_trangthai.SelectedItem.ToString();
                    if (hoadon.Trangthai.ToString() == "Đã thanh toán")
                    {
                        hoadon.Ngaythanhtoan = dtp_ngaytao.Value < dtp_ngaythanhtoan.Value ? dtp_ngaythanhtoan.Value : DateTime.Today;
                    }
                    else
                    {
                        hoadon.Ngaythanhtoan = null;
                    }
                    hoadon.Makm = hoadon.Makm;
                    hoadon.Manv = hoadon.Manv;
                    _hoadonServices.UpdateHoadon(hoadon);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hoá đơn!", "Error");
                }
            }
            LoadDgv();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mahd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn", "Missing");
                return;
            }
            Guid Mahoadon;
            if (Guid.TryParse(txt_mahd.Text, out Mahoadon))
            {
                if (_hoadonServices.GetHoadonById(Mahoadon) != null)
                {
                    foreach (var item in _hoadonchitietServices.GetAllHoadonchitet().Where(hdct => hdct.Mahd == Mahoadon))
                    {
                        _hoadonchitietServices.DeleteHoadonchitiet(item.Mahd, item.Masp);
                    }
                    _hoadonServices.DeleteHoadon(Mahoadon);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hoá đơn!", "Error");
                }
            }
            LoadDgv();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Guid defaultGuid;
            string mahd, ngaytao, ngaythanhtoan, tongtien, trangthai, makm, manv;
            if (!string.IsNullOrWhiteSpace(txt_mahd.Text) && Guid.TryParse(txt_mahd.Text, out defaultGuid))
            {
                mahd = $"mahd = '{defaultGuid.ToString()}' and ";
            }
            else mahd = "";
            if (dtp_ngaytao.Value > DateTime.Today)
            {
                ngaytao = $" ngaytaohd = '{DateTime.Today.ToString("MM-dd-yyyy")}' and ";
            }
            else ngaytao = $" ngaytaohd = '{dtp_ngaytao.Value.ToString("MM-dd-yyyy")}' and ";
            if (dtp_ngaythanhtoan.Value < DateTime.Today)
            {
                ngaythanhtoan = "";
            }
            else ngaythanhtoan = $" Ngaythanhtoan = '{dtp_ngaythanhtoan.Value.ToString("MM-dd-yyyy")}' and ";
            if (string.IsNullOrWhiteSpace(txt_tongtien.Text))
            {
                tongtien = "";
            }
            else tongtien = $" tongtien = {decimal.Parse(txt_tongtien.Text).ToString()} and ";
            if (cb_trangthai.SelectedItem == null)
            {
                trangthai = "";
            }
            else trangthai = $" trangthai = N'{cb_trangthai.SelectedItem.ToString()}' and ";
            if (string.IsNullOrWhiteSpace(txt_makm.Text))
            {
                makm = "";
            }
            else makm = $" makm = '{txt_makm.Text}' and ";
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                manv = "";
            }
            else manv = $" manv = '{txt_manv.Text}' and ";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_duan1Context.connectiongString()))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from hoadon "
                    + "Where " + mahd + ngaytao + ngaythanhtoan + tongtien + trangthai + makm + manv + " Mahd = Mahd");
                MessageBox.Show("select * from hoadon "
                    + "Where " + mahd + ngaytao + ngaythanhtoan + tongtien + trangthai + makm + manv + " Mahd = Mahd");
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
            List<Hoadon> hoadons = new List<Hoadon>();
            foreach (DataRow? row in dt.Rows)
            {
                Hoadon hoadon = new Hoadon();
                hoadon.Mahd = Guid.Parse(row["Mahd"].ToString());
                hoadon.Ngaytaohd = DateTime.Parse(row["Ngaytaohd"].ToString());
                hoadon.Ngaythanhtoan = row["Ngaythanhtoan"].ToString() != "" ? DateTime.Parse(row["Ngaythanhtoan"].ToString()) : null;
                hoadon.Tongtien = decimal.Parse(row["Tongtien"].ToString());
                hoadon.Trangthai = row["Trangthai"].ToString();
                hoadon.Makm = row["Makm"].ToString();
                hoadon.Manv = row["Manv"].ToString();
                hoadons.Add(hoadon);
            }
            var hdAfter = (from hd in hoadons
                           orderby hd.Ngaytaohd ascending
                           select new
                           {
                               Mahd = hd.Mahd,
                               Ngaytaohd = hd.Ngaytaohd.ToString("MM-dd-yyyy"),
                               Ngaythanhtoan = hd.Ngaythanhtoan?.ToString("MM-dd-yyyy"),
                               Tongtien = hd.Tongtien,
                               Trangthai = hd.Trangthai,
                               Manv = hd.Manv,
                               Makm = hd.Makm,
                           }).ToList();
            dgv_hoadon.DataSource = hdAfter;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }
    }
}
