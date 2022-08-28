using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_meger_Click(object sender, EventArgs e)
        {
            Merger merger = new Merger();
            this.Hide();
            merger.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linke linke = new linke();
            this.Hide();
            linke.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\ex"))
                Directory.CreateDirectory(@"C:\ex");
            if (!Directory.Exists(@"C:\ex\Messages"))
                Directory.CreateDirectory(@"C:\ex\Messages");
            if (!Directory.Exists(@"C:\ex\SentMessages"))
                Directory.CreateDirectory(@"C:\ex\SentMessages");
        }

        private void btn_Messages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            this.Hide();
            messages.ShowDialog();
            this.Show();
        }

        private void btn_downloads_Click(object sender, EventArgs e)
        {
            downloads downloads = new downloads();
            this.Hide();
            downloads.ShowDialog();
            this.Show();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.ShowDialog();
            this.Show();
        }

        private void btn_questions_Click(object sender, EventArgs e)
        {
            Find find = new Find();
            this.Hide();
            find.ShowDialog();
            this.Show();
        }

        private void btn_upload_questions_Click(object sender, EventArgs e)
        {
            Uploader uploader = new Uploader();
            this.Hide();
            uploader.ShowDialog();
            this.Show();
        }

        private void btn_SentMessages_Click(object sender, EventArgs e)
        {
            Sent sent = new Sent();
            this.Hide();
            sent.ShowDialog();
            this.Show();
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            send_message send_Message = new send_message();
            this.Hide();
            send_Message.ShowDialog();
            this.Show();
        }
    }
}
