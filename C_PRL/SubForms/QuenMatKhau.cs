using A_DAL.Models;
using A_DAL.Respositorys;
using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace C_PRL.SubForms
{
    public partial class QuenMatKhau : Form
    {
        int otp = 0;
        Random rd = new Random();
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        NhanvienServices nhanvienServices = new NhanvienServices();
        private void btn_gui_Click(object sender, EventArgs e)
        {
            Nhanvien nv = nhanvienServices.GetNhanvienList().Where(nv => nv.Email == txt_Emailkp.Text).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Không có tài khoản nào liên kết với email này.");
            }
            else
            {
                try
                {
                    otp = rd.Next(100000, 1000000);
                    var fromadress = new MailAddress("giaptdph37640@fpt.edu.vn");
                    var toaddress = new MailAddress(txt_Emailkp.ToString());
                    const string frompass = "aqnm srtk jpcq pmsj";
                    const string subject = "Mã xác thực";
                    string body = otp.ToString();
                    var stmp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromadress.Address, frompass),
                        Timeout = 20000,
                    };
                    using (
                        var message = new MailMessage(fromadress, toaddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                    {
                        stmp.Send(message);
                    }
                    MessageBox.Show($"Mã xác thực OTP đã được gửi tới email: {txt_Emailkp.Text}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            Nhanvien nv = nhanvienServices.GetNhanvienList().Where(nv => nv.Email == txt_Emailkp.Text).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(txt_maxn.Text))
            {
                int x;
                if (int.TryParse(txt_maxn.Text, out x))
                {
                    if (otp != Convert.ToInt32(txt_maxn.Text))
                    {
                        MessageBox.Show("Mã OTP không chính xác");
                    }
                    else
                    {
                        MessageBox.Show("Xác thực thành công");
                        DoiMatKhau subFrm_DoiMatKhau = new DoiMatKhau();
                        subFrm_DoiMatKhau._nv = nv;
                        subFrm_DoiMatKhau.Show();
                        subFrm_DoiMatKhau.Closed += (s, args) => this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác");
                }
            }
        }
    }
}
