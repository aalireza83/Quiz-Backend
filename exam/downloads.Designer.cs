namespace exam
{
    partial class downloads
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_downloads = new System.Windows.Forms.DataGridView();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quizname = new System.Windows.Forms.TextBox();
            this.btn_showinfo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_downloads)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_downloads);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dg_downloads
            // 
            this.dg_downloads.AllowUserToAddRows = false;
            this.dg_downloads.AllowUserToDeleteRows = false;
            this.dg_downloads.AllowUserToResizeColumns = false;
            this.dg_downloads.AllowUserToResizeRows = false;
            this.dg_downloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_downloads.ColumnHeadersHeight = 29;
            this.dg_downloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_downloads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uploaded,
            this.dataGridViewTextBoxColumn1,
            this.Fullname});
            this.dg_downloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_downloads.Location = new System.Drawing.Point(6, 22);
            this.dg_downloads.Name = "dg_downloads";
            this.dg_downloads.ReadOnly = true;
            this.dg_downloads.RowHeadersVisible = false;
            this.dg_downloads.RowHeadersWidth = 51;
            this.dg_downloads.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_downloads.RowTemplate.Height = 24;
            this.dg_downloads.Size = new System.Drawing.Size(379, 221);
            this.dg_downloads.TabIndex = 0;
            this.dg_downloads.TabStop = false;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "کد آزمون";
            this.Uploaded.MinimumWidth = 6;
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "کد کاربر";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام آزمون :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_quizname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_date
            // 
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(6, 74);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(293, 23);
            this.txt_date.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(6, 45);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(293, 23);
            this.txt_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاریخ دانلود :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام کاربر :";
            // 
            // txt_quizname
            // 
            this.txt_quizname.Enabled = false;
            this.txt_quizname.Location = new System.Drawing.Point(6, 16);
            this.txt_quizname.Name = "txt_quizname";
            this.txt_quizname.Size = new System.Drawing.Size(293, 23);
            this.txt_quizname.TabIndex = 2;
            // 
            // btn_showinfo
            // 
            this.btn_showinfo.Location = new System.Drawing.Point(239, 267);
            this.btn_showinfo.Name = "btn_showinfo";
            this.btn_showinfo.Size = new System.Drawing.Size(164, 33);
            this.btn_showinfo.TabIndex = 5;
            this.btn_showinfo.Text = "نمایش مشخصات کامل";
            this.btn_showinfo.UseVisualStyleBackColor = true;
            this.btn_showinfo.Click += new System.EventHandler(this.btn_showinfo_Click);
            // 
            // downloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 422);
            this.Controls.Add(this.btn_showinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "downloads";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دانلود شده ها";
            this.Load += new System.EventHandler(this.downloads_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_downloads)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_downloads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_quizname;
        private System.Windows.Forms.Button btn_showinfo;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
    }
}