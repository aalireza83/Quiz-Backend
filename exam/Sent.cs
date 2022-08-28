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
    public partial class Sent : Form
    {
        public Sent()
        {
            InitializeComponent();
        }
        StreamReader sr;
        string[] Messag;
        int f = 0;

        private void Sent_Load(object sender, EventArgs e)
        {
            #region list
            List<string> list = new List<string>();
            StringReader stringr;
            list.Clear();
            Uri uri = new Uri("http://quiz24exam.parsaspace.com/");
            var client = new RestClient("http://api.parsaspace.com/v1/files/list");
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("Domain", uri.Host);
            request.AddParameter("path", "/UsersMessages");
            IRestResponse response = client.Execute(request);
            var json = JsonConvert.DeserializeObject(response.Content).ToString();
            stringr = new StringReader(json);
            string line = stringr.ReadLine(); ;
            while (line != null)
            {
                if (line.Contains("Name"))
                {
                    list.Add(line.Replace('"', ' ').Replace(',', ' ').Split(':')[1].Trim().ToString());
                }
                line = stringr.ReadLine();
            }
            stringr.Close();
            #endregion
            string[] MessagesU = list.ToArray();
            string[] Messages = Directory.GetFiles(@"C:\ex\SentMessages");
            for (int i = 0; i < Messages.Count(); i++)
            {
                string script = Messages[i].Replace(@"C:\ex\SentMessages\", string.Empty);
                if (Array.FindIndex(MessagesU, row => row.Equals(script)) < 0)
                {
                    File.Delete(Messages[i]);
                }
            }
            for (int i = 0; i < MessagesU.Count(); i++)
            {
                if (Array.FindIndex(Messages, row => row.EndsWith(MessagesU[i])) < 0)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("http://quiz24exam.parsaspace.com/UsersMessages/" + MessagesU[i], @"C:\ex\SentMessages\" + MessagesU[i]);
                }
            }
            loader();
            Counter();
        }

        private void loader()
        {
            Messag = Directory.GetFiles(@"C:\ex\SentMessages");
            if (Messag.Count() != 0)
            {
                sr = new StreamReader(Messag[f]);
                DateTime date = DateTime.Parse(sr.ReadLine().Split('=')[1].Trim());
                PersianCalendar pc = new PersianCalendar();
                txt_Date.Text = date.ToString("HH:mm:ss") + "  " + pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" + pc.GetDayOfMonth(date);
                txt_code.Text = sr.ReadLine().Split('=')[1].Trim();
                string from = sr.ReadLine().Split('=')[1].Trim();
                if (from == "Admin")
                {
                    txt_From.Text = "ادمین";
                }
                else
                {
                    txt_From.Text = from;
                }
                string to = sr.ReadLine().Split('=')[1].Trim();
                if (to == "All")
                {
                    txt_Type.Text = "پیام همگانی";
                }
                else
                {
                    txt_Type.Text = to;
                }
                txt_Message.Text = sr.ReadLine().Split('=')[1].Trim();
                sr.Close();

            }
            else
            {
                MessageBox.Show("پیامی یافت نشد", "یافت نشد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void bnt_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف این پیام اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/remove");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("path", "/UsersMessages/" + Messag[f].Replace(@"C:\ex\SentMessages\",string.Empty));
                IRestResponse response = client.Execute(request);
                File.Delete(@"C:\ex\SentMessages" + Messag[f].Replace(@"C:\ex\SentMessages\", string.Empty));
                if (response.IsSuccessful)
                    MessageBox.Show("عملیات حذف فایل با موفقیت انجام شد", "حذف شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
