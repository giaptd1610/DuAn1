using A_DAL.Models;
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
    public partial class QL_Phucap : Form
    {
        public QL_Phucap()
        {
            InitializeComponent();
        }
        PhucapServices _phucapServices = new PhucapServices();

        public void loadData()
        {
            var pclist = (from pc in _phucapServices.GetAllPhucap()
                          select new
                          {
                              Tenpc = pc.Tenphucap,
                              Sotienphucap = Convert.ToInt32(pc.Sotienphucap),
                          }).ToList();
            dgv_phucap.DataSource = pclist;
        }

        public bool validate()
        {
            int x;
            if (string.IsNullOrWhiteSpace(txt_tenpc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phụ cấp");
                return false;
            }
            if (_phucapServices.GetAllPhucap().Where(pc => txt_tenpc.Text == pc.Tenphucap).Any())
            {
                MessageBox.Show("Phụ cấp đã tồn tại!");
            }
            if (string.IsNullOrWhiteSpace(txt_tenpc.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền phụ cấp");
                return false;
            }
            if (!int.TryParse(txt_sotienpc.Text, out x))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            if (int.Parse(txt_sotienpc.Text) % 1000 != 0)
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }
            return true;
        }

        private void QL_Phucap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_thempc_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Phucap phucap = new Phucap()
                {
                    Mapc = Guid.NewGuid(),
                    Tenphucap = txt_tenpc.Text,
                    Sotienphucap = decimal.Parse(txt_sotienpc.Text)
                };
                _phucapServices.AddPhucap(phucap);
            }
            loadData();
        }

        private void dgv_phucap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_tenpc.Text = dgv_phucap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_sotienpc.Text = dgv_phucap.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_suapc_Click(object sender, EventArgs e)
        {
            if (_phucapServices.GetAllPhucap().Where(pc => txt_tenpc.Text == pc.Tenphucap).Any())
            {
                Phucap phucap = new Phucap();
                phucap = _phucapServices.GetAllPhucap().Where(pc => pc.Tenphucap == txt_tenpc.Text).FirstOrDefault();
                phucap.Sotienphucap = decimal.Parse(txt_sotienpc.Text);
            }
            else
            {
                MessageBox.Show("Phụ cấp không tồn tại!");
            }
            loadData();
        }

        private void btn_xoapc_Click(object sender, EventArgs e)
        {
            if (_phucapServices.GetAllPhucap().Where(pc => txt_tenpc.Text == pc.Tenphucap).Any())
            {
                _phucapServices.DeletePhucap(_phucapServices.GetAllPhucap().Where(pc => txt_tenpc.Text == pc.Tenphucap).FirstOrDefault().Mapc);
            }
            else
            {
                MessageBox.Show("Phụ cấp không tồn tại!");
            }
            loadData();
        }
    }
}
