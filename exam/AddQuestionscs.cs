using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class AddQuestionscs : Form
    {
        public AddQuestionscs()
        {
            InitializeComponent();
        }
        public string exName;
        StreamReader sr;
        private void AddQuestionscs_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                txt_ID.Items.Add(i);
            }
            FileStream fileStream = new FileStream(@"C:\ex\quiz\" + exName + "\\Questions.txt", FileMode.Open);
            sr = new StreamReader(fileStream);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains("ID"))
                {
                    txt_ID.Items.Remove(int.Parse(line.Split('=')[1]));
                }
            }
            sr.Close();
            txt_ID.SelectedIndex = 0;
        }
        string HardLevel;
        string Key;
        string QuestionImage;
        string AnswerImage;
        string line;
        string link;
        private bool linkvalid()
        {
            if (!IsConnectedToInternet())
            {
                MessageBox.Show(this, "اتصال اینترنت خود را بررسی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                Uri uri = new Uri(txt_link.Text);
                link = uri.Scheme + "://" + uri.Host + uri.LocalPath;
            }
            catch
            {
                MessageBox.Show(this, "لطفا یک لینک معتبر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_link.Text = "";
                return false;
            }
            FileStream fileStream = new FileStream(@"C:\ex\quiz\" + exName + "\\Questions.txt", FileMode.Open);
            sr = new StreamReader(fileStream);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Uri uri = new Uri(txt_link.Text);
                if (line == $"QuestionImage = {uri.Scheme + "://" + uri.Host + uri.LocalPath}")
                {
                    MessageBox.Show(this, "لینک تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.Close();
                    txt_link.Text = "";
                    return false;
                }
            }
            sr.Close();
            return true;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (linkvalid())
            {
                FileStream fileStream = new FileStream(@"C:\ex\quiz\" + exName + "\\Bank.txt", FileMode.Open);
                sr = new StreamReader(fileStream);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.Contains("HardLevel"))
                    {
                        HardLevel = line;
                    }
                    else if (line.Contains("Key"))
                    {
                        Key = line;
                    }
                    else if (line.Contains(link))
                    {
                        QuestionImage = line;
                        AnswerImage = sr.ReadLine();
                        sr.Close();
                        break;
                    }
                    else if (line.Contains("-----"))
                    {
                        HardLevel = null;
                        Key = null;
                    }

                }
                if (QuestionImage == null)
                {
                    MessageBox.Show(this, "چنین سوالی در بانک سوال یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.Close();
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(@"C:\ex\quiz\" + exName + "\\Questions.txt"))
                    {
                        sw.WriteLine("ID = " + txt_ID.Text);
                        sw.WriteLine(HardLevel);
                        sw.WriteLine(Key);
                        sw.WriteLine(QuestionImage);
                        sw.WriteLine(AnswerImage);
                        sw.WriteLine("-----");
                        sw.Close();
                    }
                    WebClient webClient = new WebClient();
                    Uri QuestionImagename = new Uri(QuestionImage.Split('=')[1]);
                    webClient.DownloadFile(QuestionImage.Split('=')[1], @"C:\ex\quiz\" + exName + "\\" + Path.GetFileName(QuestionImagename.LocalPath));
                    WebClient webClient1 = new WebClient();
                    Uri AnswerImagename = new Uri(AnswerImage.Split('=')[1]);
                    webClient1.DownloadFile(AnswerImage.Split('=')[1], @"C:\ex\quiz\" + exName + "\\" + Path.GetFileName(AnswerImagename.LocalPath));
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        public bool IsConnectedToInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
