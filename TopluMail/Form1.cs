using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TopluMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            foreach(string sentMail in Emails.Items)
            {
                SendMail(tbxSenderMail.Text, tbxSenderPassword.Text, sentMail, tbxTitle.Text, tbxMessage.Text);
            }

            MessageBox.Show("Mail Gönderilmiştir");
        }

        public void SendMail(string senderMail,string senderPassword,string eposta,string title,string message)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress(senderMail);
            mesaj.To.Add(eposta);
            mesaj.Subject = title;
            mesaj.Body = message;

            SmtpClient a = new SmtpClient("outlook.com");
            a.Credentials = new System.Net.NetworkCredential(senderMail, senderPassword);
            a.Port = 587;
            a.EnableSsl = true;

            try
            {
                a.SendAsync(mesaj,(object)mesaj);
            }

            catch (SmtpException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emails.Items.Add(tbxAddEmail.Text);
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            Emails.Items.Remove(Emails.SelectedItem);
        }
    }
}
