using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }
        List<int> ids = new List<int>();
        public string exname;
        StreamReader sr;
        int count = 0;
        private void Viewer_Load(object sender, EventArgs e)
        {
            stream();
            string line = sr.ReadLine();
            txt_name.Text = exname;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains("ID"))
                {
                    ids.Add(int.Parse(line.Split('=')[1]));
                }
            }
            ids.Sort();
            txt_Count.Text = ids.Count().ToString();
            sr.Close();
            loader();
            count++;
            counter();
        }

        private void counter()
        {
            if (count == 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
            if (count == int.Parse(txt_Count.Text))
            {
                btn_next.Enabled = false;
            }
            else if (count < int.Parse(txt_Count.Text))
            {
                btn_next.Enabled = true;
            }
        }
        int i = 0;
        private void loader()
        {
            stream();
            while (!sr.EndOfStream)
            {
                string line2 = sr.ReadLine();
                if (line2.Contains("ID") && int.Parse(line2.Split('=')[1]) == int.Parse(ids[i].ToString()))
                {
                    txt_Id.Text = line2.Split('=')[1];
                    txt_hard.Text = sr.ReadLine().Split('=')[1];
                    txt_key.Text = sr.ReadLine().Split('=')[1];
                    Uri QuestionImagename = new Uri(sr.ReadLine().Split('=')[1]);
                    pb_question.Image = Image.FromFile(@"C:\ex\quiz\" + txt_name.Text + "\\" + Path.GetFileName(QuestionImagename.LocalPath));
                    Uri AnswerImagename = new Uri(sr.ReadLine().Split('=')[1]);
                    pb_answer.Image = Image.FromFile(@"C:\ex\quiz\" + txt_name.Text + "\\" + Path.GetFileName(AnswerImagename.LocalPath));
                    break;
                }
            }
            sr.Close();
        }

        private void stream()
        {
            FileStream file = new FileStream(@"C:\ex\quiz\" + exname + "\\Questions.txt", FileMode.Open);
            sr = new StreamReader(file);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            i--;
            loader();
            count--;
            counter();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            i++;
            loader();
            count++;
            counter();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "آیا از حذف این سوال اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                stream();
                string text = sr.ReadLine() + Environment.NewLine;
                Login login = new Login();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("ID") && line.Split('=')[1] == txt_Id.Text)
                    {
                        sr.ReadLine();
                        sr.ReadLine();
                        Uri QuestionImagename = new Uri(sr.ReadLine().Split('=')[1]);
                        Uri AnswerImagename = new Uri(sr.ReadLine().Split('=')[1]);
                        File.WriteAllText(@"C:\ex\quiz\" + txt_name.Text + "\\" + "remove.txt",
                            @"C:\ex\quiz\" + txt_name.Text + "\\" + Path.GetFileName(QuestionImagename.LocalPath) + Environment.NewLine +
                            @"C:\ex\quiz\" + txt_name.Text + "\\" + Path.GetFileName(AnswerImagename.LocalPath) + Environment.NewLine);
                    }
                    else
                    {
                        text += line + Environment.NewLine;
                    }
                }
                sr.Close();
                File.WriteAllText(@"C:\ex\quiz\" + exname + "\\Questions.txt", text);
                this.DialogResult = DialogResult.Yes;
            }
        }
    }

}


