using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class linke : Form
    {
        string line;
        StreamReader sr;
        public linke()
        {
            InitializeComponent();
        }

        private void btn_addres_Click(object sender, EventArgs e)
        {
            if (sr != null)
            {
                sr.Close();
            }
            OpenFileDialog openaddres = new OpenFileDialog();
            openaddres.Filter = "Text files (*.txt)|*.txt";
            if (openaddres.ShowDialog() == DialogResult.OK)
            {
                txt_addres.Text = openaddres.FileName;
                FileStream fileStream = new FileStream(txt_addres.Text, FileMode.Open);
                sr = new StreamReader(fileStream);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
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
        private bool checkstart()
        {
            if (!IsConnectedToInternet())
            {
                MessageBox.Show(this, "اتصال اینترنت خود را بررسی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_addres.Text == "")
            {
                MessageBox.Show(this, "لطفا یک فایل را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!File.Exists(txt_addres.Text))
                {
                    MessageBox.Show(this, "چنین فایلی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (rb_download.Checked)
            {
                if (txt_folder.Text == "")
                {
                    MessageBox.Show(this, "لطفا یک پوشه را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (!Directory.Exists(txt_folder.Text))
                    {
                        MessageBox.Show(this, "چنین پوشه ای وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkstart())
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line.Contains("http"))
                        {
                            string[] fields = line.Split('"');
                            for (int i = 0; i > -1; i++)
                            {
                                if (fields[i].Contains("http"))
                                {
                                    Uri uri1 = new Uri(fields[i]);
                                    string site = uri1.Scheme + "://" + uri1.Host + uri1.LocalPath;
                                    int count = int.Parse(lblex.Text);
                                    if (!rb_download.Checked)
                                    {
                                        txt_links.AppendText(site + Environment.NewLine);
                                    }
                                    else
                                    {
                                        Uri uri = new Uri(site);
                                        string filename = Path.GetFileName(uri.LocalPath);
                                        WebClient webClient = new WebClient();
                                        webClient.DownloadFile(site, txt_folder.Text + "\\" + filename);
                                        int comp = count + 1;
                                        txt_links.AppendText("دانلود " + comp + " فایل تکمیل شد" + Environment.NewLine);
                                    }
                                    count++;
                                    lblex.Text = count.ToString();
                                    i = -2;
                                }
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show(this, "خطا در انجام کار", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            txt_links.SelectAll();
            txt_links.Copy();
            MessageBox.Show("لینک ها کپی شد");
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            line = null;
            sr = null;
            txt_links.Text = "";
            txt_addres.Text = "";
            lblex.Text = "0";
            txt_folder.Text = "";

        }

        private void rb_download_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_download.Checked)
            {
                txt_folder.Visible = true;
                btn_folder.Visible = true;
                btn_Copy.Visible = false;
                btn_addres.Text = "انتخاب فایل مبدأ";
                label1.Text = "تعداد لینک های دانلود شده :";
            }
            else
            {
                txt_folder.Visible = false;
                btn_folder.Visible = false;
                btn_Copy.Visible = true;
                btn_addres.Text = "انتخاب فایل";
                label1.Text = "تعداد لینک های استخراج شده :";
            }
        }

        private void linke_Load(object sender, EventArgs e)
        {
            rb_download.Checked = true;
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = folderBrowserDialog.SelectedPath;

            }

        }
    }
}

