using System;
using System.Windows.Forms;
using System.Net.Mail;
namespace SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage Email = new MailMessage();
                SmtpClient SmtpClient = new SmtpClient("smtp.gmail.com");


                Email.From = new MailAddress(txt_From.Text);
                Email.To.Add(txt_To.Text);
                Email.Subject = txt_Subject.Text ;
                Email.Body = txt_Mail.Text;

                SmtpClient.Port = 587;
                SmtpClient.Credentials = new System.Net.NetworkCredential(txt_From.Text,txt_Password.Text);
                SmtpClient.EnableSsl = true;

                SmtpClient.Send(Email);
                MessageBox.Show("E-Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
