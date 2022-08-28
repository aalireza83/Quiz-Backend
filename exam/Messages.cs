using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }
        StreamReader sr;
        string[] Messag;
        int f = 0;
        bool finished = false;

        private void Messages_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            StringReader stringr;
            list.Clear();
            Uri uri = new Uri("http://quiz24exam.parsaspace.com/");
            var client = new RestClient("http://api.parsaspace.com/v1/files/list");
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("Domain", uri.Host);
            request.AddParameter("path", "/Messages");
            IRestResponse response = client.Execute(request);
            var json = JsonConvert.DeserializeObject(response.Content).ToString();
            stringr = new StringReader(json);
            string line = stringr.ReadLine(); ;
            while (line != null)
            {
                if (line.Contains("Name"))
                {
                    list.Add(line.Replace('"', ' ').Replace(',', ' ').Trim().ToString());
                }
                line = stringr.ReadLine();
            }
            string[] MessagesU = list.ToArray();
            string[] Messages = Directory.GetFiles(@"C:\ex\Messages");
            for (int i = 0; i < MessagesU.Count(); i++)
            {
                if (Array.FindIndex(Messages, row => row.EndsWith(MessagesU[i].Split(':')[1].Trim())) < 0)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("http://quiz24exam.parsaspace.com/Messages/" + MessagesU[i].Split(':')[1].Trim(), @"C:\ex\Messages\N-" + MessagesU[i].Split(':')[1].Trim());
                }
            }
            messagereader();
            loader();
            Counter();
        }
        private void messagereader()
        {
            string[] AMessages = Directory.GetFiles(@"C:\ex\Messages");
            List<string> ReadM = new List<string>();
            List<string> UReadM = new List<string>();
            for (int i = 0; i < AMessages.Count(); i++)
            {
                if (AMessages[i].Replace("C:\\ex\\Messages\\", string.Empty).StartsWith("N-"))
                {
                    ReadM.Add(AMessages[i].Replace("C:\\ex\\Messages\\", string.Empty));
                }
                else
                {
                    UReadM.Add(AMessages[i].Replace("C:\\ex\\Messages\\", string.Empty));
                }
            }
            Messag = new string[ReadM.ToArray().Length + UReadM.ToArray().Length];
            Array.Copy(ReadM.ToArray(), Messag, ReadM.ToArray().Length);
            Array.Copy(UReadM.ToArray(), 0, Messag, ReadM.ToArray().Length, UReadM.ToArray().Length);
        }
        private void loader()
        {
            try
            {
                if (Messag.Count() != 0)
                {
                    sr = new StreamReader("C:\\ex\\Messages\\" + Messag[f]);
                    DateTime date = DateTime.Parse(sr.ReadLine().Split('=')[1].Trim());
                    PersianCalendar pc = new PersianCalendar();
                    txt_Date.Text = date.ToString("HH:mm:ss") + "  " + pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" + pc.GetDayOfMonth(date);
                    txt_code.Text = sr.ReadLine().Split('=')[1].Trim();
                    txt_From.Text = sr.ReadLine().Split('=')[1].Trim();
                    txt_fromcode.Text = sr.ReadLine().Split('=')[1].Trim();
                    txt_Message.Text = sr.ReadLine().Split('=')[1].Trim();
                    txt_Id.Text = sr.ReadLine().Split('=')[1].Trim();
                    if (txt_Id.Text == "")
                    {
                        txt_Id.Visible = false;
                        label3.Visible = false;
                    }
                    else
                    {
                        txt_Id.Visible = true;
                        label3.Visible = true;
                    }
                    finished = false;
                    if (Messag[f].StartsWith("N-"))
                    {
                        cb_read.Checked = false;
                    }
                    else
                    {
                        cb_read.Checked = true;
                    }
                    finished = true;
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("پیامی یافت نشد", "یافت نشد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("خطا در خواندن پیام", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Counter()
        {
            if (f == 0)
            {
                btn_Previous.Enabled = false;
            }
            else
            {
                btn_Previous.Enabled = true;
            }
            if (Messag.Count() > f + 1)
            {
                btn_next.Enabled = true;
            }
            else
            {
                btn_next.Enabled = false;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            f++;
            Counter();
            loader();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            f--;
            Counter();
            loader();
        }

        private void cb_read_CheckedChanged(object sender, EventArgs e)
        {
            if (finished)
            {
                if (cb_read.Checked)
                {
                    File.Move(@"C:\ex\Messages\" + Messag[f], @"C:\ex\Messages\" + Messag[f].Replace("N-", string.Empty));
                }
                else
                {
                    File.Move(@"C:\ex\Messages\" + Messag[f], @"C:\ex\Messages\N-" + Messag[f]);
                }
                messagereader();
                f = Array.FindIndex(Messag, row => row.EndsWith(txt_code.Text + ".txt"));
                loader();
                Counter();
            }
        }
    }
}

