using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using C_PRL.MainForms;
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

namespace C_PRL.SubForms
{
    public partial class Sanpham_OnDisplay : Form
    {
        public string masp;
        public string tensp;
        public byte[] image;
        public decimal giaban;
        HoadonchitietServices hoadonchitietServices = new HoadonchitietServices();
        public Sanpham_OnDisplay(string inMasp, byte[] inImage, string inTensp, decimal giatien, HoadonchitietServices xhoadonchitietServices)
        {
            masp = inMasp;
            tensp = inTensp;
            image = inImage;
            giaban = giatien;
            hoadonchitietServices = xhoadonchitietServices;
            InitializeComponent();
        }

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

        private void Sanpham_OnDisplay_Load(object sender, EventArgs e)
        {
            lb_tensp.Text = tensp;
            lb_giatien.Text = ((int)giaban).ToString();
            pb_image.Image = ConvertBytesToImage(image);
        }
        private void lb_giatien_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(lb_giatien.Text, NumberStyles.AllowThousands);
            lb_giatien.Text = String.Format(culture, "{0:N0}", value);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!hoadonchitietServices.GetAllHoadonchitet().Where(sp => sp.Mahd == BanHang.MaHD() && sp.Masp == masp).Any())
            {
                Hoadonchitiet hoadonchitiet = new Hoadonchitiet()
                {
                    Mahd = BanHang.MaHD(),
                    Masp = masp,
                    Soluong = (int)nud_Soluong.Value,
                    Dongia = nud_Soluong.Value * giaban,
                };
                hoadonchitietServices.AddHoadonchitiet(hoadonchitiet);
            }
            else
            {
                Hoadonchitiet hoadonchitiet = new Hoadonchitiet();
                hoadonchitiet = hoadonchitietServices.GetAllHoadonchitet().Where(sp => sp.Mahd == BanHang.MaHD() && sp.Masp == masp).First();
                hoadonchitiet.Masp = masp;
                hoadonchitiet.Soluong = hoadonchitiet.Soluong + (int)nud_Soluong.Value;
                hoadonchitiet.Dongia = hoadonchitiet.Soluong * giaban;
                hoadonchitietServices.UpdateHoadonchitiet(hoadonchitiet);
            }
            BanHang.load_hoadonchitet();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (hoadonchitietServices.GetAllHoadonchitet().Where(sp => sp.Mahd == BanHang.MaHD() && sp.Masp == masp).Any())
            {
                hoadonchitietServices.DeleteHoadonchitiet(BanHang.MaHD(), masp);
                BanHang.load_hoadonchitet();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong hoá đơn");
            }
        }
    }
}
