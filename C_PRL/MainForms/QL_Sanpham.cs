using System;
using B_BUS.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Models;
using C_PRL.SubForms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.Data.SqlClient;

namespace C_PRL.MainForms
{
    public partial class QL_Sanpham : Form
    {
        public QL_Sanpham()
        {
            InitializeComponent();
        }
        SanphamServices _sanphamServices = new SanphamServices();
        LoaisanphamServices _loaisanphamServices = new LoaisanphamServices();
        Duan1Context _duan1Context = new Duan1Context();
        byte[] hinhAnh;
        public void LoadData()
        {
            var sp_loaisp = (from sp in _sanphamServices.GetAllSanpham()
                             join lsp in _loaisanphamServices.GetAllLoaisanpham() on sp.Maloaisp equals lsp.Maloaisp
                             select new
                             {
                                 Masp = sp.Masp,
                                 Tensp = sp.Tensp,
                                 Mota = sp.Mota,
                                 Hinhanh = sp.Hinhanh,
                                 Giaban = sp.Giaban,
                                 Trangthai = sp.Trangthai,
                                 Tenloaisp = lsp.Tenloaisp
                             }).ToList();
            dgv_sanpham.DataSource = sp_loaisp;
        }
        public void LoadLoaiSP()
        {
            cb_Loaisp.DataSource = _loaisanphamServices.GetAllLoaisanpham();
            cb_Loaisp.DisplayMember = "TenloaiSp";
            cb_Loaisp.ValueMember = "Maloaisp";
            cb_tkLoaisp.DataSource = _loaisanphamServices.GetAllLoaisanpham();
            cb_tkLoaisp.DisplayMember = "TenloaiSp";
            cb_tkLoaisp.ValueMember = "Maloaisp";
        }
        public void Insert(string masp, string tensp, string mota, byte[] hinhanh, decimal giaban, string trangthai, Guid maloaisp)
        {
            Sanpham sanpham = new Sanpham()
            {
                Masp = masp,
                Tensp = tensp,
                Mota = mota,
                Hinhanh = hinhanh,
                Giaban = giaban,
                Trangthai = trangthai,
                Maloaisp = maloaisp,
            };
            _sanphamServices.AddSanpham(sanpham);
        }
        public void Update(string masp, string tensp, string mota, byte[] hinhanh, decimal giaban, string trangthai, Guid maloaisp)
        {
            Sanpham sanpham = _sanphamServices.GetSanphamById(masp);
            sanpham.Tensp = tensp;
            sanpham.Mota = mota;
            sanpham.Hinhanh = hinhanh;
            sanpham.Giaban = giaban;
            sanpham.Trangthai = trangthai;
            sanpham.Maloaisp = maloaisp;
            if (!_sanphamServices.UpdateSanpham(sanpham)) { MessageBox.Show("Bug"); };
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        //public Image ConvertBytesToImage(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
        public Image ConvertBytesToImage(byte[] byteArrayIn)
        {
            try
            {
                var ms = new MemoryStream(byteArrayIn); ;
                return Image.FromStream(ms);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
            return null;
        }


        private void QL_Sanpham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLoaiSP();
        }

        private void btn_themHinhAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                var result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    hinhAnh = ConvertImageToBytes(pictureBox1.Image);
                }
                else if (result == DialogResult.Cancel)
                {
                    pictureBox1.Image = null;
                    hinhAnh = null;
                }

            }
        }

        private void btn_themLoaisp_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            loaiSanPham.Show();
            loaiSanPham.FormClosed += LoadLoaiSP;
        }

        private void LoadLoaiSP(object? sender, FormClosedEventArgs e)
        {
            LoadLoaiSP();
        }
        public bool IsNulOrEmty(string masp, string tensp, string giaban, object trangthai)
        {
            int x;
            if (string.IsNullOrWhiteSpace(masp))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
                return false;
            }
            else if (!Regex.IsMatch(masp, @"^[a-z0-9]{1,10}$"))
            {
                MessageBox.Show("Mã sản phẩm không dài quá 10 kí tự | Chỉ chứa kí tự a-z, 0-9");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tensp))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(giaban.ToString()))
            {
                MessageBox.Show("Giá bán không được để trống");
                return false;
            }
            else if (!int.TryParse(giaban, out x))
            {

                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            else if (int.Parse(giaban) % 1000 != 0)
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            else if (trangthai == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cb_Loaisp.SelectedValue?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm");
                return false;
            }
            return true;
        }
        private void btn_themSp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsNulOrEmty(txt_masp.Text, txt_tensp.Text, txt_giaban.Text, cb_Trangthai.SelectedItem))
                {

                }
                else if (!string.IsNullOrWhiteSpace(_sanphamServices.GetSanphamById(txt_masp.Text)?.Masp))
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!\nVui lòng sử dụng mã sản phẩm khác", "Error");
                }
                else
                {
                    Insert(
                    txt_masp.Text,
                    txt_tensp.Text,
                    txt_mota.Text,
                    hinhAnh,
                    decimal.Parse(txt_giaban.Text),
                    cb_Trangthai.SelectedItem.ToString(),
                    Guid.Parse(cb_Loaisp.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bug : \n\n" + ex);
            }
            LoadData();
        }

        private void btn_xoaSp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_sanphamServices.GetSanphamById(txt_masp.Text)?.Masp))
                {
                    MessageBox.Show("Sản phẩm không tồn tại!\nVui lòng sử dụng mã sản phẩm khác", "Error");
                }
                else
                {
                    _sanphamServices.DeleteSanpham(txt_masp.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bug : \n\n" + ex);
            }
            LoadData();
        }

        private void btn_chinhSuaSp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsNulOrEmty(txt_masp.Text, txt_tensp.Text, txt_giaban.Text, cb_Trangthai.SelectedItem))
                {

                }
                else if (string.IsNullOrWhiteSpace(_sanphamServices.GetSanphamById(txt_masp.Text)?.Masp))
                {
                    MessageBox.Show("Sản phẩm không tồn tại!\nVui lòng sử dụng mã sản phẩm khác", "Error");
                }
                else
                {
                    Update(
                    txt_masp.Text,
                    txt_tensp.Text,
                    txt_mota.Text,
                    hinhAnh,
                    decimal.Parse(txt_giaban.Text),
                    cb_Trangthai.SelectedItem.ToString(),
                    Guid.Parse(cb_Loaisp.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bug : \n\n" + ex);
            }
            LoadData();
        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_masp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tensp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_mota.Text = dgv_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
                pictureBox1.Image = ConvertBytesToImage((byte[])dgv_sanpham.Rows[e.RowIndex].Cells[3].Value);
                txt_giaban.Text = dgv_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString();
                cb_Trangthai.Text = dgv_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_Loaisp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            decimal r;
            string? masp, tensp, giaban, trangthai, loaisp;
            if (!string.IsNullOrWhiteSpace(txt_tkMasp.Text) && Regex.IsMatch(txt_tkMasp.Text, @"^[a-z0-9]{1,10}$"))
            {
                masp = $" Masp = '{txt_tkMasp.Text}' and ";
            }
            else masp = "";
            if (!string.IsNullOrWhiteSpace(txt_tkTensp.Text))
            {
                tensp = $" Tensp = N'{txt_tkTensp.Text}' and ";
            }
            else tensp = "";
            if (!string.IsNullOrWhiteSpace(txt_tkGiaban.Text) && decimal.TryParse(txt_tkGiaban.Text, out r))
            {
                giaban = $"Giaban = {txt_tkGiaban.Text} and ";
            }
            else giaban = "";
            if (cb_tkTrangthai.SelectedItem != null)
            {
                trangthai = $" Trangthai = N'{cb_tkTrangthai.SelectedItem.ToString()}' and ";
            }
            else trangthai = "";
            if (cb_tkLoaisp.SelectedValue == null)
            {
                loaisp = "";
            }
            else loaisp = $" Maloaisp = N'{cb_tkLoaisp.SelectedValue}' and ";
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_duan1Context.connectiongString()))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from sanpham "
                    + "Where " +  masp + tensp + giaban + trangthai + loaisp + " masp = masp" );
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
            List<Sanpham> sanphams = new List<Sanpham>();
            foreach (DataRow row in dt.Rows)
            {
                Sanpham sanpham = new Sanpham();
                sanpham.Masp = row["Masp"].ToString();
                sanpham.Tensp = row["Tensp"].ToString();
                sanpham.Mota = row["Mota"].ToString();
                if (!Convert.IsDBNull(row["Hinhanh"]))
                {
                    sanpham.Hinhanh = (byte[]?)row["Hinhanh"];
                }
                else sanpham.Hinhanh = null;
                sanpham.Giaban = (decimal)row["Giaban"];
                sanpham.Trangthai = row["Trangthai"].ToString();
                sanpham.Maloaisp = Guid.Parse(row["Maloaisp"].ToString());
                sanphams.Add(sanpham);
            }
            var spAfter = (from sp in sanphams
                           join lsp in _loaisanphamServices.GetAllLoaisanpham() on sp.Maloaisp equals lsp.Maloaisp
                           select new
                           {
                               Masp = sp.Masp,
                               Tensp = sp.Tensp,
                               Mota = sp.Mota,
                               Hinhanh = sp.Hinhanh,
                               Giaban = sp.Giaban,
                               Trangthai = sp.Trangthai,
                               Tenloaisp = lsp.Tenloaisp
                           }).ToList();
            dgv_sanpham.DataSource = spAfter;
        }
    }
}
