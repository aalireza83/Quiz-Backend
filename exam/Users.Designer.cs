namespace exam
{
    partial class Users
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
            this.dg_Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_showinfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_userst = new System.Windows.Forms.TextBox();
            this.txt_lastversion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_deleteuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Users
            // 
            this.dg_Users.AllowUserToAddRows = false;
            this.dg_Users.AllowUserToDeleteRows = false;
            this.dg_Users.AllowUserToResizeColumns = false;
            this.dg_Users.AllowUserToResizeRows = false;
            this.dg_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Users.ColumnHeadersHeight = 29;
            this.dg_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Uploaded,
            this.Column1});
            this.dg_Users.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_Users.Location = new System.Drawing.Point(12, 12);
            this.dg_Users.Name = "dg_Users";
            this.dg_Users.ReadOnly = true;
            this.dg_Users.RowHeadersVisible = false;
            this.dg_Users.RowHeadersWidth = 51;
            this.dg_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_Users.RowTemplate.Height = 24;
            this.dg_Users.Size = new System.Drawing.Size(391, 226);
            this.dg_Users.TabIndex = 1;
            this.dg_Users.TabStop = false;
            this.dg_Users.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dg_Users_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "کد کاربر";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "وضعیت اعتبار سنجی";
            this.Uploaded.MinimumWidth = 6;
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btn_showinfo
            // 
            this.btn_showinfo.Location = new System.Drawing.Point(239, 244);
            this.btn_showinfo.Name = "btn_showinfo";
            this.btn_showinfo.Size = new System.Drawing.Size(164, 33);
            this.btn_showinfo.TabIndex = 7;
            this.btn_showinfo.Text = "نمایش مشخصات کامل";
            this.btn_showinfo.UseVisualStyleBackColor = true;
            this.btn_showinfo.Click += new System.EventHandler(this.btn_showinfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_userst);
            this.groupBox1.Controls.Add(this.txt_lastversion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_userc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_usern);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txt_userst
            // 
            this.txt_userst.Enabled = false;
            this.txt_userst.Location = new System.Drawing.Point(6, 74);
            this.txt_userst.Name = "txt_userst";
            this.txt_userst.Size = new System.Drawing.Size(232, 23);
            this.txt_userst.TabIndex = 2;
            // 
            // txt_lastversion
            // 
            this.txt_lastversion.Enabled = false;
            this.txt_lastversion.Location = new System.Drawing.Point(6, 103);
            this.txt_lastversion.Name = "txt_lastversion";
            this.txt_lastversion.Size = new System.Drawing.Size(161, 23);
            this.txt_lastversion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "وضعیت اعتبار سنجی :";
            // 
            // txt_userc
            // 
            this.txt_userc.Enabled = false;
            this.txt_userc.Location = new System.Drawing.Point(6, 45);
            this.txt_userc.Name = "txt_userc";
            this.txt_userc.Size = new System.Drawing.Size(311, 23);
            this.txt_userc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "آخرین ورژن نصب شده توسط کاربر :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "کد کاربر :";
            // 
            // txt_usern
            // 
            this.txt_usern.Enabled = false;
            this.txt_usern.Location = new System.Drawing.Point(6, 16);
            this.txt_usern.Name = "txt_usern";
            this.txt_usern.Size = new System.Drawing.Size(311, 23);
            this.txt_usern.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کاربر :";
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(209, 421);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(185, 33);
            this.btn_one.TabIndex = 7;
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Visible = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(18, 421);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(185, 33);
            this.btn_two.TabIndex = 7;
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Visible = false;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_deleteuser
            // 
            this.btn_deleteuser.Location = new System.Drawing.Point(12, 244);
            this.btn_deleteuser.Name = "btn_deleteuser";
            this.btn_deleteuser.Size = new System.Drawing.Size(97, 33);
            this.btn_deleteuser.TabIndex = 7;
            this.btn_deleteuser.Text = "حذف کاربر";
            this.btn_deleteuser.UseVisualStyleBackColor = true;
            this.btn_deleteuser.Click += new System.EventHandler(this.btn_deleteuser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 463);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_deleteuser);
            this.Controls.Add(this.btn_showinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_Users);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Users;
        private System.Windows.Forms.Button btn_showinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_lastversion;
        private System.Windows.Forms.TextBox txt_userc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_deleteuser;
    }
}