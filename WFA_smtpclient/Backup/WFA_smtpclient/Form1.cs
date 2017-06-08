using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WFA_smtpclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress MailFrom = new MailAddress(this.tB_From.Text);
            MailAddress MailTo = new MailAddress(this.tB_To.Text);
            MailAddress MailCc = new MailAddress(this.tB_cc.Text);
            MailMessage myEmail = new MailMessage(MailFrom, MailTo);
            
            string host = this.tB_Smtp_server.Text.Trim();
            string username = this.tB_Uid.Text.Trim();
            string password = this.tB_Pwd.Text.Trim();
            int port = Convert.ToInt32(this.tB_Port.Text);
            myEmail.CC.Add(MailCc);
            myEmail.Subject = this.tB_subject.Text;
            if(this.tB_attachment.Text.Trim().Length>0)
            {
            Attachment myAttachment = new Attachment(this.tB_attachment.Text); 
            myEmail.Attachments.Add(myAttachment);
            }
            
            myEmail.Body = this.tB_Body.Text;
            this.sc = new SmtpClient(host);
            this.sc.UseDefaultCredentials = false;
            this.sc.EnableSsl = this.ck_ssl.Checked;
            this.sc.Port = port;
            this.sc.Credentials = new NetworkCredential(username, password);

            try
            {
                this.sc.Send(myEmail);
                MessageBox.Show("邮件已发送!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "发送出现异常！");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tB_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_Smtp_server_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_attachment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.tB_attachment.Text = this.openFileDialog1.FileName;
        }
    }
}
