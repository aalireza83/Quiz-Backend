using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace exam
{
    public partial class Uploader : Form
    {
        public Uploader()
        {
            InitializeComponent();
        }
        StringReader stringr;
        StreamReader sr;
        List<string> list = new List<string>();
        private void Uploader_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\ex\\uploads.txt"))
            {
                var file = File.Create("C:\\ex\\uploads.txt");
                file.Close();
            }
            examloader();
            uploades();
        }

        public void uploades()
        {
            if (IsConnectedToInternet())
            {
                dg_uploads.Rows.Clear();
                list.Clear();
                Uri uri = new Uri("http://quiz24exam.parsaspace.com/");
                var client = new RestClient("http://api.parsaspace.com/v1/files/list");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("Domain", uri.Host);
                request.AddParameter("path", "/Exams/");
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
                    FileStream fileStream = new FileStream("C:\\ex\\uploads.txt", FileMode.Open);
                    sr = new StreamReader(fileStream);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (!sr.EndOfStream)
                    {
                        string line2 = sr.ReadLine();
                        if (line2.Split('=')[0] == Name.Split(':')[1].Replace(".txt", " ").Trim())
                        {
                            dg_uploads.Rows.Add(line2.Split('=')[1], line2.Split('=')[0]);
                            break;
                        }
                    }
                    sr.Close();
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

        private void examloader()
        {
            dg_exam.Rows.Clear();
            List<string> Names = new List<string>(Directory.GetDirectories(@"C:\ex\quiz"));
            foreach (string folder in Names)
            {
                dg_exam.Rows.Add(folder.Replace("C:\\ex\\quiz\\", string.Empty));
            }
        }

        private void btn_upload_Click_1(object sender, EventArgs e)
        {
            if (dg_exam.CurrentRow != null)
            {
                connection_code connection_Code = new connection_code();
                connection_Code.exname = dg_exam.CurrentCell.Value.ToString();
                if (connection_Code.ShowDialog() == DialogResult.OK)
                {
                    uploades();
                }
            }
            else
            {
                MessageBox.Show("هیچ آزمونی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"آیا از حذف {dg_uploads.CurrentRow.Cells[1].Value} ({dg_uploads.CurrentRow.Cells[0].Value}) مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/remove");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("path", "/Exams/" + dg_uploads.CurrentRow.Cells[1].Value + ".txt");
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    FileStream fileStream = new FileStream("C:\\ex\\uploads.txt", FileMode.Open);
                    sr = new StreamReader(fileStream);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    string text = sr.ReadLine() + Environment.NewLine;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Split('=')[0].ToString() == dg_uploads.CurrentRow.Cells[1].Value.ToString())
                        {
                            line = sr.ReadLine();
                        }
                        else
                        {
                            text += line + Environment.NewLine;
                        }
                    }
                    sr.Close();
                    File.WriteAllText("C:\\ex\\uploads.txt", text);
                    MessageBox.Show("عملیات حذف فایل با موفقیت انجام شد", "حذف شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uploades();
                }
            }
        }

        private void btn_Downloaded_Click(object sender, EventArgs e)
        {

        }
    }
}
