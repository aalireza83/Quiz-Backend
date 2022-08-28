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
    public partial class send_message : Form
    {
        public send_message()
        {
            InitializeComponent();
        }
        StringReader stringr;
        List<string> list = new List<string>();

        private void send_message_Load(object sender, EventArgs e)
        {
            cb_type.SelectedIndex = 0;
            cb_messagecode.Checked = true;
            cb_sender.Checked = true;
            cb_date.Checked = true;
            cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_code.DropDownStyle = ComboBoxStyle.DropDownList;
            if (IsConnectedToInternet())
            {
                cb_code.Items.Clear();
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
                    if (status == "Verified")
                    {
                        cb_code.Items.Add(Name.Split(':')[1].Replace(".txt", " ").Trim().Split('=')[0]);
                    }
                }
            }

            if (cb_code.Items.Count == 0)
            {
                cb_type.Items.RemoveAt(1);
            }
            else
            {
                cb_code.SelectedIndex = 0;
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

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == 0)
            {
                cb_code.Visible = false;
                label3.Visible = false;
            }
            if (cb_type.SelectedIndex == 1)
            {
                cb_code.Visible = true;
                label3.Visible = true;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                try
                {
                    string mdate = "Date = ";
                    string mcode = "Code = " + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string mfrom = "From = ";
                    string mto = "To = ";
                    string message = "Message = " + txt_Message.Text;
                    if (cb_date.Checked)
                    {
                        mdate += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    else
                    {
                        try
                        {
                            mdate += DateTime.Parse(txt_Date.Text).ToString("yyyy/MM/dd HH:mm:ss");
                        }
                        catch
                        {
                            MessageBox.Show("خطا در فرمت ساعت وارد شده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (cb_messagecode.Checked)
                    {
                        Random rd = new Random();
                        mcode += rd.Next(10000, 99999);
                    }
                    else
                    {
                        mcode += txt_messagecode.Value;
                    }
                    if (cb_sender.Checked)
                    {
                        mfrom += "Admin";
                    }
                    else
                    {
                        mfrom += txt_Sender.Text;
                    }
                    if (cb_type.SelectedIndex == 0)
                    {
                        mto += "All";
                    }
                    else if (cb_type.SelectedIndex == 1)
                    {
                        mto += cb_code.SelectedItem.ToString();
                    }
                    string messagescript = mdate + Environment.NewLine + mcode + Environment.NewLine + mfrom + Environment.NewLine + mto + Environment.NewLine + message;
                    File.WriteAllText(@"C:\ex\SentMessages\" + mto.Split('=')[1].Trim() + "-" + mcode.Split('=')[1].Trim() + ".txt", messagescript);
                    var client = new RestClient("http://api.parsaspace.com/v1/files/upload");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6Im1vdXNpYW5pMTM4M0BnbWFpbC5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3VzZXJkYXRhIjoiNTA5OTIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIyIiwiaXNzIjoiaHR0cDovL2FwaS5wYXJzYXNwYWNlLmNvbS8iLCJhdWQiOiJBbnkiLCJleHAiOjE2NDE4MjM0OTAsIm5iZiI6MTYxMDI4NzQ5MH0.uymAXmDRqrc60FupQAwzQhMdUMTdE4_oa1qhmNt7Du8");
                    request.AddHeader("content-type", "multipart/form-data");
                    request.AddParameter("Domain", "quiz24exam.parsaspace.com");
                    request.AddParameter("path", "/UsersMessages/");
                    request.AddFile("file", @"C:\ex\SentMessages\" + mto.Split('=')[1].Trim() + "-" + mcode.Split('=')[1].Trim() + ".txt");
                    IRestResponse response = client.Execute(request);
                    if (response.IsSuccessful == true)
                    {
                        File.Delete(@"C:\ex\SentMessages\" + mto.Split('=')[1].Trim() + "-" + mcode.Split('=')[1].Trim() + ".txt");
                        MessageBox.Show("پیام با موفقیت ارسال شد", "ارسال شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("خطا در ارسال پیام", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        bool isvalid()
        {
            if (!IsConnectedToInternet())
            {
                return false;
            }
            else if (txt_Message.Text == "")
            {
                MessageBox.Show("پیام خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cb_messagecode_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_messagecode.Checked)
            {
                txt_messagecode.Enabled = false;
                txt_messagecode.Minimum = 0;
                txt_messagecode.Value = 0;
            }
            else
            {
                txt_messagecode.Enabled = true;
                txt_messagecode.Minimum = 10000;
            }
        }

        private void cb_sender_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sender.Checked)
            {
                txt_Sender.Enabled = false;
                txt_Sender.Text = "";
            }
            else
            {
                txt_Sender.Enabled = true;
            }
        }

        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_date.Checked)
            {
                txt_Date.Enabled = false;
                txt_Date.Text = null;
            }
            else
            {
                txt_Date.Enabled = true;
                txt_Date.Text = DateTime.Now.ToString("HH:mm:ss yyyy/MM/dd");
            }
        }
    }
}
