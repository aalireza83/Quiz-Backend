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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        StringReader stringr;
        StreamReader sr;
        List<string> list = new List<string>();

        private void Users_Load(object sender, EventArgs e)
        {
            userload();
        }

        private void userload()
        {
            if (IsConnectedToInternet())
            {
                txt_lastversion.Text = "";
                txt_userc.Text = "";
                txt_usern.Text = "";
                txt_userst.Text = "";
                dg_Users.Rows.Clear();
                list.Clear();
                Uri uri = new Uri("http://quiz24exam.parsaspace.com/");
                var client = new RestClient("http://api.parsaspace.com/v1/files/list");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("Domain", uri.Host);
                request.AddParameter("path", "/Users/");
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
                    string status = Name.Split(':')[1].Replace(".txt", " ").Trim().Split('=')[1].Trim();
                    string statusPersian = null;
                    if (status == "Verified")
                        statusPersian = "تایید شده";
                    else if (status == "Blocked")
                        statusPersian = "بلاک شده";
                    else if (status == "")
                        statusPersian = "تایید نشده";
                    dg_Users.Rows.Add(Name.Split(':')[1].Replace(".txt", " ").Trim().Split('=')[0], statusPersian, Name.Split(':')[1].Replace(".txt", " ").Trim());
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
            if (dg_Users.CurrentRow != null)
            {
                WebClient webClient = new WebClient();
                Uri url = new Uri("http://quiz24exam.parsaspace.com/Users/" + dg_Users.CurrentRow.Cells[2].Value + ".txt");
                webClient.DownloadFile(url, @"C:\ex\" + Path.GetFileName(url.LocalPath));
                sr = new StreamReader(@"C:\ex\" + Path.GetFileName(url.LocalPath));
                txt_usern.Text = sr.ReadLine().Replace("Name=", string.Empty);
                txt_userc.Text = sr.ReadLine().Replace("UserName=", string.Empty);
                txt_userst.Text = dg_Users.CurrentRow.Cells[1].Value.ToString();
                txt_lastversion.Text = sr.ReadLine();
                sr.Close();
                File.Delete(@"C:\ex\" + Path.GetFileName(url.LocalPath));
                if (txt_userst.Text == "تایید شده")
                {
                    btn_one.Text = "تغییر وضعیت به بلاک شده";
                    btn_two.Text = "تعغییر وضعیت به تایید نشده";
                }
                if (txt_userst.Text == "بلاک شده")
                {
                    btn_one.Text = "تغییر وضعیت به تایید شده";
                    btn_two.Text = "تعغییر وضعیت به تایید نشده";
                }
                if (txt_userst.Text == "تایید نشده")
                {
                    btn_one.Text = "تغییر وضعیت به تایید شده";
                    btn_two.Text = "تغییر وضعیت به بلاک شده";
                }
                btn_one.Visible = true;
                btn_two.Visible = true;
            }
            else
            {
                MessageBox.Show("هیچ سطری انتخاب نشده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_Users_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btn_one.Text = "";
            btn_one.Text = "";
            btn_one.Visible = false;
            btn_two.Visible = false;
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف این کاربر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/remove");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("path", "/Users/" + dg_Users.CurrentRow.Cells[2].Value + ".txt");
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                    MessageBox.Show("عملیات حذف فایل با موفقیت انجام شد", "حذف شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userload();
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            change(btn_one.Text);
        }

        private void change(string text)
        {
            if (text == "تغییر وضعیت به تایید شده")
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/rename");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("source", "/Users/" + dg_Users.CurrentRow.Cells[2].Value + ".txt");
                request.AddParameter("destination", "/Users/" + dg_Users.CurrentRow.Cells[0].Value + "=Verified.txt");
                IRestResponse response = client.Execute(request);
            }
            else if (text == "تعغییر وضعیت به تایید نشده")
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/rename");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("source", "/Users/" + dg_Users.CurrentRow.Cells[2].Value + ".txt");
                request.AddParameter("destination", "/Users/" + dg_Users.CurrentRow.Cells[0].Value + "=.txt");
                IRestResponse response = client.Execute(request);
            }
            else if (text == "تغییر وضعیت به بلاک شده")
            {
                var client = new RestClient("https://api.parsaspace.com/v2/files/rename");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("domain", "quiz24exam.parsaspace.com");
                request.AddParameter("source", "/Users/" + dg_Users.CurrentRow.Cells[2].Value + ".txt");
                request.AddParameter("destination", "/Users/" + dg_Users.CurrentRow.Cells[0].Value + "=Blocked.txt");
                IRestResponse response = client.Execute(request);
            }
            MessageBox.Show("عملیات با موفقیت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userload();
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            change(btn_two.Text);
        }
    }
}
