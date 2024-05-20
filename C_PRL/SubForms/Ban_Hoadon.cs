using A_DAL.Models;
using B_BUS.Services;
using C_PRL.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.SubForms
{
    public partial class Ban_Hoadon : Form
    {
        public Ban_Hoadon()
        {
            InitializeComponent();
        }
        BanHoadonServices _banHoadonServices = new BanHoadonServices();
        BanServices _banServices = new BanServices();
        string maBan = "";
        string mabanKnguoi;
        public void LoadDgv()
        {
            if (!_banHoadonServices.GetAllBanHoadon().Any())
            {
                var coNguoi = (from ban in _banServices.GetAllBan().Where(ban => ban.Trangthai == "Dùng được")
                               join banHoadon in _banHoadonServices.GetAllBanHoadon() on ban.Maban equals banHoadon.Maban
                               select new
                               {
                                   Mahd = banHoadon.Mahd,
                                   Maban = banHoadon.Maban,
                                   Trangthai = banHoadon.Trangthai
                               }
                ).ToList();
                dgv_coNguoi.DataSource = coNguoi;
                var khongNguoi = (from ban in _banServices.GetAllBan().Where(ban => ban.Trangthai == "Dùng được")
                                  select new
                                  {
                                      Maban = ban.Maban,
                                      Tenban = ban.Tenban,
                                      Trangthai = ban.Trangthai
                                  }
                    ).ToList();
                dgv_khongCoNguoi.DataSource = khongNguoi;
                dgv_khongCoNguoi.Columns[0].Visible = false;
            }
            else
            {
                var coNguoi = (from ban in _banServices.GetAllBan().Where(ban => ban.Trangthai == "Dùng được")
                               join banHoadon in _banHoadonServices.GetAllBanHoadon() on ban.Maban equals banHoadon.Maban
                               select new
                               {
                                   Mahd = banHoadon.Mahd,
                                   Maban = banHoadon.Maban,
                                   Trangthai = banHoadon.Trangthai
                               }
                ).ToList();
                dgv_coNguoi.DataSource = coNguoi;
                var khongNguoi = (from ban in _banServices.GetAllBan().Where(ban => ban.Trangthai == "Dùng được")
                                  select new
                                  {
                                      Maban = ban.Maban,
                                      Tenban = ban.Tenban,
                                      Trangthai = ban.Trangthai,
                                  }
                    ).ToList();
                foreach (var ban in coNguoi)
                {
                    if (khongNguoi.Where(b => b.Maban == ban.Maban).Any())
                    {
                        khongNguoi.Remove(khongNguoi.Where(b => b.Maban == ban.Maban).First());
                    }
                }
                dgv_khongCoNguoi.DataSource = khongNguoi;
                dgv_khongCoNguoi.Columns[0].Visible = false;
            }
        }
        private void Ban_Hoadon_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BanHang.MaHD() != new Guid())
            {
                if (!string.IsNullOrWhiteSpace(mabanKnguoi))
                {
                    BanHoadon banHoadon = new BanHoadon()
                    {
                        Maban = mabanKnguoi,
                        Mahd = BanHang.MaHD(),
                        Trangthai = "Có người"
                    };
                    _banHoadonServices.AddBanHoadon(banHoadon);
                }
                else
                {
                    MessageBox.Show("Chọn 1 bàn để thêm hoá đơn vào");
                }
            }
            else
            {
                MessageBox.Show("Bạn đang trong chế độ xem bàn!");
            }
            LoadDgv();
        }

        private void dgv_khongCoNguoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                mabanKnguoi = dgv_khongCoNguoi.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgv_coNguoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                maBan = dgv_coNguoi.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_XoaBanHd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maBan))
            {
                if (_banHoadonServices.GetAllBanHoadon().Where(banhd => banhd.Maban == maBan).Any())
                {
                    _banHoadonServices.DeleteBanHoadon(maBan);
                    maBan = " ";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn này!");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 bàn để chuyển về bàn không có người!");
            }
            LoadDgv();
        }
    }
}
