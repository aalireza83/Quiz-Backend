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
    public partial class Merger : Form
    {
        public Merger()
        {
            InitializeComponent();
        }
        int totalcount = 0;
        int count = 0;
        int row = 0;
        string Mergered;
        string newMergered;
        string bankmergered;
        StreamReader sr;
        string line;
        private void Merger_Load(object sender, EventArgs e)
        {
            dg_exam.Rows.Clear();
            List<string> Names = new List<string>(Directory.GetDirectories(@"C:\ex\quiz"));
            foreach (string folder in Names)
            {
                dg_exam.Rows.Add(folder.Replace("C:\\ex\\quiz\\", string.Empty));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dg_exam.CurrentRow != null)
            {
                FileStream file = new FileStream(@"C:\ex\quiz\" + dg_exam.CurrentCell.Value.ToString() + "\\Questions.txt", FileMode.Open);
                sr = new StreamReader(file);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.StartsWith("ID = "))
                    {
                        count++;
                        int idc = totalcount + count;
                        newMergered += "ID = " + idc + Environment.NewLine;
                    }
                    else if (line.StartsWith("Name="))
                    {

                    }
                    else
                    {
                        newMergered += line + Environment.NewLine;
                    }
                }
                sr.Close();
                if (count != 0)
                {
                    row++;
                    int newcount = totalcount + count;
                    dg_megexams.Rows.Add(row, dg_exam.CurrentCell.Value.ToString(), count, totalcount + 1 + " - " + newcount);
                    totalcount += count;
                    count = 0;
                    Mergered += newMergered;
                    bankmergered += File.ReadAllText(@"C:\ex\quiz\" + dg_exam.CurrentCell.Value.ToString() + "\\Bank.txt");
                    dg_exam.Rows.RemoveAt(dg_exam.CurrentRow.Index);
                    newMergered = string.Empty;
                }
                else
                {
                    newMergered = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("هیچ آزمونی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (totalcount != 0)
            {
                Directory.CreateDirectory(@"C:\ex\quiz\" + txt_Name.Text);
                File.WriteAllText(@"C:\ex\quiz\" + txt_Name.Text + "\\Questions.txt", "Name=" + txt_Name.Text + Environment.NewLine + Mergered);
                File.WriteAllText(@"C:\ex\quiz\" + txt_Name.Text + "\\Bank.txt", bankmergered);
                for (int i = 0; dg_megexams.Rows.Count > i; i++)
                {
                    string exnameM = dg_megexams.Rows[i].Cells[1].Value.ToString();
                    List<string> files = Directory.GetFiles(@"C:\ex\quiz\" + exnameM).ToList();
                    files.Remove(@"C:\ex\quiz\" + exnameM + "\\Questions.txt");
                    files.Remove(@"C:\ex\quiz\" + exnameM + "\\Bank.txt");
                    foreach (string filess in files)
                    {
                        Uri uri = new Uri(filess);
                        string filename = Path.GetFileName(uri.LocalPath);
                        File.Copy(filess, @"C:\ex\quiz\" + txt_Name.Text + "\\" + filename);
                    }
                }
                Mergered = string.Empty;
                MessageBox.Show("ادغام با موقیت انجام شد");
                this.Close();
            }
            else
            {
                MessageBox.Show("آزمونی برای ادغام انتخاب نشده");
            }
        }
    }
}
