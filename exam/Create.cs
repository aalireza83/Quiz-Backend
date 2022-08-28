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
    public partial class Create : Form
    {
        StreamReader sr;
        public Create()
        {
            InitializeComponent();
        }

        private bool valid()
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show(this, "لطفا یک نام برای آزمون خود انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Directory.Exists(@"C:\ex\quiz\" + txt_Name.Text))
            {
                MessageBox.Show(this, "این نام آزمون تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_File.Text == "")
            {
                MessageBox.Show(this, "لطفا یک فایل را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (sr != null)
            {
                sr.Close();
            }
            OpenFileDialog openaddres = new OpenFileDialog();
            openaddres.Filter = "Text files (*.txt)|*.txt";
            if (openaddres.ShowDialog() == DialogResult.OK)
            {
                txt_File.Text = openaddres.FileName;
                FileStream fileStream = new FileStream(txt_File.Text, FileMode.Open);
                sr = new StreamReader(fileStream);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
            }
        }
        string hard = "Null";
        string key = "Null";
        string question = "Null";
        string answer = "Null";
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                MessageBox.Show("این کار ممکن است چمد دقیقه ای زمان ببرد" + Environment.NewLine + "لطفا تا اتمام کار با نرم افزار کار نکنید");
                string line = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    if (line.Contains("HardLevel"))
                    {
                        hard = "HardLevel = " + line.Split(':')[1].Replace(',', ' ').Trim();
                    }
                    if (line.Contains("Key"))
                    {
                        key = "Key = " + line.Split(':')[1].Replace(',', ' ').Trim();
                    }
                    if (line.Contains("QuestionImage"))
                    {
                        string[] fields = line.Split('"');
                        for (int i = 0; i > -1; i++)
                        {
                            if (fields[i].Contains("http"))
                            {
                                Uri uri1 = new Uri(fields[i]);
                                question = "QuestionImage = " + uri1.Scheme + "://" + uri1.Host + uri1.LocalPath;
                                i = -2;
                            }
                        }
                    }
                    if (line.Contains("AnswerImage"))
                    {
                        string[] fields = line.Split('"');
                        for (int i = 0; i > -1; i++)
                        {
                            if (fields[i].Contains("http"))
                            {
                                Uri uri1 = new Uri(fields[i]);
                                answer = "AnswerImage = " + uri1.Scheme + "://" + uri1.Host + uri1.LocalPath;
                                i = -2;
                            }
                        }
                    }
                    line = sr.ReadLine();
                    if (line.Contains("HardLevel") && hard != "Null")
                    {
                        insert();
                    }
                    else if (line.Contains("Key") && key != "Null")
                    {
                        insert();
                    }
                    else if (line.Contains("QuestionImage") && question != "Null")
                    {
                        insert();
                    }
                    else if (line.Contains("AnswerImage") && answer != "Null")
                    {
                        insert();
                    }
                }
                insert2();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string Bank;
        private void insert()
        {
            Bank += hard + Environment.NewLine + key + Environment.NewLine + question + Environment.NewLine + answer + Environment.NewLine + "-----" + Environment.NewLine;
            hard = "Null";
            key = "Null";
            question = "Null";
            answer = "Null";
        }
        private void insert2()
        {
            Directory.CreateDirectory(@"C:\ex\quiz\" + txt_Name.Text);
            var file = File.Create(@"C:\ex\quiz\" + txt_Name.Text + "\\Bank.txt");
            file.Close();
            var file2  = File.Create(@"C:\ex\quiz\" + txt_Name.Text + "\\Questions.txt");
            file2.Close();
            File.WriteAllText(@"C:\ex\quiz\" + txt_Name.Text + "\\Questions.txt",$"Name={txt_Name.Text + Environment.NewLine}");
            File.WriteAllText(@"C:\ex\quiz\" + txt_Name.Text + "\\Bank.txt", Bank);
            sr.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
