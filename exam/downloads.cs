using Newtonsoft.Json;
using RestSharp;
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
    public partial class downloads : Form
    {
        public downloads()
        {
            InitializeComponent();
        }
        StringReader stringr;
        StreamReader sr;
        List<string> list = new List<string>();

        private void downloads_Load(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                dg_downloads.Rows.Clear();
                list.Clear();
                Uri uri = new Uri("http://quiz24exam.parsaspace.com/");
                var client = new RestClient("http://api.parsaspace.com/v1/files/list");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("Domain", uri.Host);
                request.AddParameter("path", "/Download/");
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
                stringr.Close();
                string[] Names = list.ToArray();
                foreach (string Name in Names)
                {
                    dg_downloads.Rows.Add(Name.Split(':')[1].Replace(".txt", " ").Trim().Split('-')[0], Name.Split(':')[1].Replace(".txt", " ").Trim().Split('-')[1], Name.Split(':')[1].Replace(".txt", " ").Trim());
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
                MessageBox.Show(this, "اتصال اینترنت خود را بررسی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_showinfo_Click(object sender, EventArgs e)
        {
            if (dg_downloads.CurrentRow != null)
            {
                WebClient webClient = new WebClient();
                Uri url = new Uri("http://quiz24exam.parsaspace.com/Download/" + dg_downloads.CurrentRow.Cells[2].Value + ".txt");
                webClient.DownloadFile(url, @"C:\ex\" + Path.GetFileName(url.LocalPath));
                sr = new StreamReader(@"C:\ex\" + Path.GetFileName(url.LocalPath));
                txt_quizname.Text = sr.ReadLine().Replace("ExamName=", string.Empty);
                sr.ReadLine();
                txt_username.Text = sr.ReadLine().Replace("Name=", string.Empty);
                sr.ReadLine();
                txt_date.Text = sr.ReadLine().Replace("Date=", string.Empty);
                sr.Close();
                File.Delete(@"C:\ex\" + Path.GetFileName(url.LocalPath));
            }
            else
            {
                MessageBox.Show("هیچ سطری انتخاب نشده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
