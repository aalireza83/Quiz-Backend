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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string exName;
        StreamReader sr;
        public string RemoveQuestion;
        public string RemoveAnswer;
        private void Login_Load(object sender, EventArgs e)
        {
            this.Name = "آزمون " + exName;
            txt_exName.Text = exName;
            load();
        }

        private void load()
        {
            FileStream fileStream = new FileStream(@"C:\ex\quiz\" + exName + "\\Questions.txt", FileMode.Open);
            sr = new StreamReader(fileStream);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            int count = 0;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                if (line.Contains("ID"))
                {
                    count++;
                }
            }
            txt_count.Text = count.ToString();
            sr.Close();
        }

        private void btn_addQuestions_Click(object sender, EventArgs e)
        {
            while (true)
            {
                AddQuestionscs addQuestionscs = new AddQuestionscs();
                addQuestionscs.exName = exName;
                if (addQuestionscs.ShowDialog() == DialogResult.OK)
                {
                    load();
                    MessageBox.Show("سوال جدید با موفقیت ثبت شد");
                }
                else
                {
                    break;
                }
            }
        }

        private void btn_Questions_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Viewer viewer = new Viewer();
                viewer.exname = exName;
                if (viewer.ShowDialog() == DialogResult.OK)
                {
                    load();
                    break;
                }
                else if (viewer.DialogResult == DialogResult.Yes)
                {
                    viewer.exname = exName;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
