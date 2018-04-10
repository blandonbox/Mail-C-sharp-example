using System;
using System.Windows.Forms;
using MailExample.Mail;

namespace MailExample
{
    public partial class Form1 : Form
    {
        MailSender mail;

        public Form1()
        {
            InitializeComponent();
            mail = new MailSender();
        }
        
        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ans = -1;
                if (Int32.TryParse(Porttxt.Text, out int port))
                {
                    mail.ConfigMailSender(servertxt.Text, SenderMailtxt.Text, port, Usertxt.Text, Passwordtxt.Text);
                    if (Attachmentchk.Checked) ans = mail.SendMail(Mailtxt.Text, Subjecttxt.Text, Messagetxt.Text, Attachmenttxt.Text);
                    else ans = mail.SendMail(Mailtxt.Text, Subjecttxt.Text, Messagetxt.Text);

                }
                if (ans == 0) MessageBox.Show("Mail sended");
                else MessageBox.Show("Mail failed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Attachmentchk_CheckedChanged(object sender, EventArgs e)
        {
            if(Attachmentchk.Checked)
            {
                Attachmenttxt.Enabled = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Attachmenttxt.Text = openFileDialog1.FileName;
                }
                else
                {
                    Attachmentchk.Checked = false;
                }
            }
            else
            {
                Attachmenttxt.Enabled = false;
            }
        }
    }
}
