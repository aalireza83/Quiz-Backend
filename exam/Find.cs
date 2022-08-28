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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            if (create.ShowDialog() == DialogResult.OK)
            {
                dg_load();
                MessageBox.Show("آزمون ایجاد شد");
            }
        }

        private void Find_Load(object sender, EventArgs e)
        {
            dg_load();
        }

        private void dg_load()
        {
            dg_exam.Rows.Clear();
            List<string> Names = new List<string>(Directory.GetDirectories(@"C:\ex\quiz"));
            foreach (string folder in Names)
            {
                dg_exam.Rows.Add(folder.Replace("C:\\ex\\quiz\\", string.Empty));
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_exam.CurrentCell.Value != null)
            {
                var Directory = new DirectoryInfo("C:\\ex\\quiz\\" + dg_exam.CurrentCell.Value);
                if (MessageBox.Show(this, "ایا از حذف آزمون " + dg_exam.CurrentCell.Value + " اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.Delete(true);
                    dg_load();
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (dg_exam.CurrentRow != null)
            {
                Login login = new Login();
                login.exName = dg_exam.CurrentCell.Value.ToString();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ آزمونی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
