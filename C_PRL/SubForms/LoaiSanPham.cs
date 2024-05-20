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

namespace C_PRL.SubForms
{
    public partial class LoaiSanPham : Form
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }
        LoaisanphamServices _LoaisanphamServices = new LoaisanphamServices();
        Guid idloaiSp;
        public void loadData()
        {
            dgv_loaisanpham.DataSource = _LoaisanphamServices.GetAllLoaisanpham();
            dgv_loaisanpham.Columns[0].Visible = false;
            dgv_loaisanpham.Columns[3].Visible = false;
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                A_DAL.Models.Loaisanpham loaisanpham = new A_DAL.Models.Loaisanpham()
                {
                    Maloaisp = Guid.NewGuid(),
                    Tenloaisp = txt_tenLoaisp.Text,
                    Mota = txt_mota.Text
                };
                _LoaisanphamServices.AddLoaisanpham(loaisanpham);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm loại sản phẩm\n\n" + ex, "Error");
            }
            loadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            _LoaisanphamServices.DeleteLoaisanpham(idloaiSp);
            loadData();
        }

        private void dgv_loaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idloaiSp = Guid.Parse(dgv_loaisanpham.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_tenLoaisp.Text = dgv_loaisanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_mota.Text = dgv_loaisanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
