using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
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
    public partial class QL_Ban : Form
    {
        BanServices _banServices;
        public QL_Ban()
        {
            InitializeComponent();
            _banServices = new BanServices();
            dgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ban.ColumnCount = 3;
            dgv_ban.Columns[0].Name = "Mã bàn";
            dgv_ban.Columns[1].Name = "Tên bàn";
            dgv_ban.Columns[2].Name = "Trạng thái";
            dgv_ban.AllowUserToAddRows = false;
            LoadData(_banServices.GetAllBan());
        }
        public bool IsMaKhuyenMaiExists(string maBan)
        {
            using (Duan1Context _dbContext = new Duan1Context())
            {
                return _dbContext.Bans.Any(ban => ban.Maban == maBan);
            }
        }
        public bool CheckMaban()
        {
            if (IsMaKhuyenMaiExists(txt_maban.Text))
            {
                MessageBox.Show("Mã bàn đã tồn tại");
                return false;
            }
            return true;
        }
        public bool ValidateBan()
        {
            if (string.IsNullOrWhiteSpace(txt_maban.Text))
            {
                MessageBox.Show("Mã bàn không được để trống");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_tenban.Text))
            {

                MessageBox.Show("Tên bàn không được để trống");
                return false;
            }

            return true;
        }
        public void LoadData(List<Ban> list)
        {
            dgv_ban.Rows.Clear();
            foreach (Ban ban in list)
            {
                dgv_ban.Rows.Add(ban.Maban, ban.Tenban, ban.Trangthai);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ValidateBan())
            {
                if (CheckMaban())
                {
                    var add = new Ban()
                    {
                        Maban = txt_maban.Text,
                        Tenban = txt_tenban.Text,
                        Trangthai = cb_trangthai.Text
                    };
                    if (_banServices.AddBan(add))
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        LoadData(_banServices.GetAllBan());
                    }
                    else
                    {
                        MessageBox.Show("Thêm bàn thất bại");
                    }
                }
            }

        }

        private void dgv_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_ban.Rows.Count)
            {
                int index = e.RowIndex;
                var cellclicks = dgv_ban.Rows[index];
                txt_maban.Text = cellclicks.Cells[0].Value.ToString();
                txt_tenban.Text = cellclicks.Cells[1].Value.ToString();
                cb_trangthai.Text = cellclicks.Cells[2].Value.ToString();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_maban.Text = "";
            txt_tenban.Text = "";
            cb_trangthai.Text = "Dùng được";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sua = _banServices.GetAllBan().ToList().Where(km => km.Maban.Contains(txt_maban.Text)).FirstOrDefault() != null;
            if (ValidateBan())
            {
                try
                {
                    if (sua)
                    {
                        var ban = _banServices.GetBanById(txt_maban.Text);
                        ban.Tenban = txt_tenban.Text;
                        ban.Trangthai = cb_trangthai.Text;

                        if (_banServices.UpdateBan(ban))
                        {
                            MessageBox.Show("Sửa thành công!");
                            LoadData(_banServices.GetAllBan());
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_banServices.GetAllBan().ToList().Where(km => km.Maban.Contains(txt_maban.Text)).FirstOrDefault() != null)
            {
                if (MessageBox.Show("Bạn có muốn xoá Bàn này không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _banServices.DeleteBan(txt_maban.Text);
                    LoadData(_banServices.GetAllBan());
                }

            }
        }
        public List<Ban> FindName()
        {
            var timkiem = _banServices.GetAllBan().Where(p => p.Tenban.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            return timkiem;

        }
        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(FindName());
        }
    }
}
