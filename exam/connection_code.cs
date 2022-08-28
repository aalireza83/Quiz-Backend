using Newtonsoft.Json;
using RestSharp;
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
    public partial class connection_code : Form
    {
        public connection_code()
        {
            InitializeComponent();
        }
        public string exname;
        StringReader stringr;
        StreamReader sr;
        bool repet = false;
        private void btn_upload_Click(object sender, EventArgs e)
        {
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
                    if (line.Replace('"', ' ').Replace(',', ' ').Split(':')[1].Replace(".txt", " ").Trim().ToString() == txt_code.Value.ToString())
                    {
                        MessageBox.Show("کد تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        repet = true;
                    }
                }
                line = stringr.ReadLine();
            }
            stringr.Close();
            if (!repet)
            {
                upload();
            }
        }

        private void upload()
        {
            filemacker();
            var client = new RestClient("http://api.parsaspace.com/v1/files/upload");
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
            request.AddHeader("content-type", "multipart/form-data");
            request.AddParameter("domain", "quiz24exam.parsaspace.com");
            request.AddParameter("path", "/Exams/");
            request.AddFile("file", @"C:\ex\quiz\" + exname + "\\" + txt_code.Value.ToString() + ".txt");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful == true)
            {
                using (StreamWriter sw = File.AppendText(@"C:\ex\uploads.txt"))
                {
                    sw.WriteLine(txt_code.Value.ToString() + '=' + exname);
                    sw.Close();
                }
                MessageBox.Show("آپلود با موفقیت انجام شد", "آپلود شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            File.Delete(@"C:\ex\\quiz\" + exname + "\\" + txt_code.Value.ToString() + ".txt");
            this.DialogResult = DialogResult.OK;
        }

        private void filemacker()
        {
            File.Copy(@"C:\ex\quiz\" + exname + "\\Questions.txt", @"C:\ex\quiz\" + exname + "\\" + txt_code.Value.ToString() + ".txt");
            //FileStream fileStream = new FileStream(@"C:\ex\quiz\" + exname + "\\" + txt_code.Value.ToString() + ".txt", FileMode.Open);
            //sr = new StreamReader(fileStream);
            //sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //string text = sr.ReadLine() + Environment.NewLine;
            //while (!sr.EndOfStream)
            //{
            //    string line = sr.ReadLine();
            //    if (line.Split('=')[0].Trim() == "AnswerImage")
            //    {

            //    }
            //    else
            //    {
            //        text += line + Environment.NewLine;
            //    }
            //}
            //sr.Close();
            //File.WriteAllText(@"C:\ex\quiz\" + exname + "\\" + txt_code.Value.ToString() + ".txt", text);
        }
    }
}
