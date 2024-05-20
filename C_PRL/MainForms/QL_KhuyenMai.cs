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
    public partial class QL_KhuyenMai : Form
    {
        public QL_KhuyenMai()
        {
            InitializeComponent();
            dgv_KhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_KhuyenMai.ColumnCount = 9;
            dgv_KhuyenMai.Columns[0].Name = "Mã khuyến mãi";
            dgv_KhuyenMai.Columns[1].Name = "Tên khuyến mãi";
            dgv_KhuyenMai.Columns[2].Name = "Ngày tạo";
            dgv_KhuyenMai.Columns[3].Name = "Ngày bắt đầu";
            dgv_KhuyenMai.Columns[4].Name = "Ngày kết thúc";
            dgv_KhuyenMai.Columns[5].Name = "Mô tả";
            dgv_KhuyenMai.Columns[6].Name = "Số phần trăm";
            dgv_KhuyenMai.Columns[7].Name = "Số tiền giảm";
            dgv_KhuyenMai.Columns[8].Name = "Điều kiện khuyến mãi";
            dgv_KhuyenMai.AllowUserToAddRows = false;
            LoadData(_khuyenmaiServices.GetAllKhuyenmai());

        }
        KhuyenmaiServices _khuyenmaiServices = new KhuyenmaiServices();
        public void LoadData(List<Khuyenmai> list)
        {
            
            dgv_KhuyenMai.Rows.Clear();
            foreach (var item in list)
            {
                dgv_KhuyenMai.Rows.Add(item.Makm, item.Tenkm, item.Ngaytao, item.Ngaybd, item.Ngaykt, item.Mota
                    , item.Soptgiam, item.Sotiengiam, item.Dkgiam);
            }
        }
        private bool IsMaKhuyenMaiExists(string maKhuyenMai)
        {
            using (Duan1Context _dbContext = new Duan1Context())
            {
                return _dbContext.Khuyenmais.Any(ban => ban.Makm == maKhuyenMai);
            }
        }
        public bool CheckMakm()
        {
            if (IsMaKhuyenMaiExists(txt_makhuyenmai.Text))
            {
                MessageBox.Show("Mã khuyến mãi đã tồn tại");
                return false;
            }
            return true;
        }
        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txt_makhuyenmai.Text))
            {
                MessageBox.Show("Mã khuyến mãi không được để trống");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txt_tenkhuyenmai.Text))
            {

                MessageBox.Show("Tên khuyến mãi không được để trống");
                return false;
            }
            DateTime ngayBatDau = dtp_Ngaybatdau.Value;
            DateTime ngayKetThuc = dtp_NgayKt.Value;

            if (ngayKetThuc <= ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Phantram.Text))
            {
                MessageBox.Show("Số phần trăm không được để trống");
                return false;
            }

            if (!int.TryParse(txt_Phantram.Text, out int phanTram) || (phanTram < 0 && phanTram >= 100))
            {
                MessageBox.Show("Số phần trăm phải là một số nguyên dương");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Sotien.Text))
            {

                MessageBox.Show("Số tiền không được để trống");
                return false;
            }
            if (!decimal.TryParse(txt_Sotien.Text, out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền phải là một số nguyên dương");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Dieukien.Text))
            {
                MessageBox.Show("Điều kiện khuyến mãi không được để trống");
                return false;
            }
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            if (ValidateData())
            {
                if (CheckMakm())
                {
                    var add = new Khuyenmai()
                    {
                        Makm = txt_makhuyenmai.Text,
                        Tenkm = txt_tenkhuyenmai.Text,
                        Ngaytao = dtp_ngaytao.Value,
                        Ngaybd = dtp_Ngaybatdau.Value,
                        Ngaykt = dtp_NgayKt.Value,
                        Mota = txt_mota.Text,
                        Soptgiam = Convert.ToInt32(txt_Phantram.Text),
                        Sotiengiam = Convert.ToDecimal(txt_Sotien.Text),
                        Dkgiam = txt_Dieukien.Text
                    };
                    if (_khuyenmaiServices.AddKhuyenmai(add))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadData(_khuyenmaiServices.GetAllKhuyenmai());
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
            }
        }

        private void dgv_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_KhuyenMai.Rows.Count)
            {
                int index = e.RowIndex;
                var cellclicks = dgv_KhuyenMai.Rows[index];
                txt_makhuyenmai.Text = cellclicks.Cells[0].Value.ToString();
                txt_tenkhuyenmai.Text = cellclicks.Cells[1].Value.ToString();
                dtp_ngaytao.Text = cellclicks.Cells[2].Value.ToString();
                dtp_Ngaybatdau.Text = cellclicks.Cells[3].Value.ToString();
                dtp_NgayKt.Text = cellclicks.Cells[4].Value.ToString();
                txt_mota.Text = cellclicks.Cells[5].Value.ToString();
                txt_Phantram.Text = cellclicks.Cells[6].Value.ToString();
                txt_Sotien.Text = cellclicks.Cells[7].Value.ToString();
                txt_Dieukien.Text = cellclicks.Cells[8].Value.ToString();
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var sua = _khuyenmaiServices.GetAllKhuyenmai().ToList().Where(km => km.Makm.Contains(txt_makhuyenmai.Text)).FirstOrDefault() != null;
            try
            {
                if (ValidateData())
                {
                    if (sua)
                    {
                        var khuyenmai = _khuyenmaiServices.GetKhuyenmaiById(txt_makhuyenmai.Text);
                        khuyenmai.Tenkm = txt_tenkhuyenmai.Text;
                        khuyenmai.Ngaytao = DateTime.Today;
                        khuyenmai.Ngaybd = dtp_Ngaybatdau.Value;
                        khuyenmai.Ngaykt = dtp_NgayKt.Value;
                        khuyenmai.Mota = txt_mota.Text;
                        khuyenmai.Soptgiam = Convert.ToInt32(txt_Phantram.Text);
                        khuyenmai.Sotiengiam = Convert.ToDecimal(txt_Sotien.Text);
                        khuyenmai.Dkgiam = txt_Dieukien.Text;
                        if (_khuyenmaiServices.UpdateKhuyenmai(khuyenmai))
                        {
                            MessageBox.Show("Sửa thành công!");
                            LoadData(_khuyenmaiServices.GetAllKhuyenmai());
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành công!");
                        }

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_khuyenmaiServices.GetAllKhuyenmai().ToList().Where(km => km.Makm.Contains(txt_makhuyenmai.Text)).FirstOrDefault() != null)
            {
                if (MessageBox.Show("Bạn có muốn xoá khuyến mãi  này không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _khuyenmaiServices.DeleteKhuyenmai(txt_makhuyenmai.Text);
                    LoadData(_khuyenmaiServices.GetAllKhuyenmai());
                }
                
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_makhuyenmai.Text = "";
            txt_tenkhuyenmai.Text = "";
            dtp_ngaytao.Text = "";
            dtp_Ngaybatdau.Text = "";
            dtp_NgayKt.Text = "";
            txt_mota.Text = "";
            txt_Phantram.Text = "";
            txt_Sotien.Text = "";
            txt_Dieukien.Text = "";
        }
        public List<Khuyenmai> FindName()
        {
            var timkiem = _khuyenmaiServices.GetAllKhuyenmai().Where(p => p.Tenkm.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            return timkiem;
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadData(FindName());
        }

    }
}
