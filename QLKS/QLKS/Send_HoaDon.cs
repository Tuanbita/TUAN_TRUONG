using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace QLKS
{
    public partial class Send_HoaDon : Form
    {
        public Send_HoaDon()
        {
            InitializeComponent();
        }

        private void Send_HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    //Thêm các file đã chọn vào listBox1
                    lstB.Items.Add(filename.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                SmtpClient client = new SmtpClient(txtSmtp.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(txtUserName.Text, txtPass.Text);
                client.EnableSsl = true;
                if (lstB.Items.Count > 0)
                {
                    foreach (var filename in lstB.Items)
                    {
                        //Kiểm tra file có tồn tại trong ổ đĩa không
                        if (File.Exists(filename.ToString()))
                        {
                            //Thêm file đính kèm vào tin nhắn
                            mail.Attachments.Add(new Attachment(filename.ToString()));
                        }
                    }
                }

                client.Send(mail);
                MessageBox.Show("Gửi Thành Công!");

            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi '"+ex.Message+"'");
            }

        }
    }
}
