namespace exam
{
    partial class linke
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
            this.txt_addres = new System.Windows.Forms.TextBox();
            this.btn_addres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblex = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_links = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.rb_extract = new System.Windows.Forms.RadioButton();
            this.rb_download = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_addres
            // 
            this.txt_addres.Location = new System.Drawing.Point(12, 12);
            this.txt_addres.Name = "txt_addres";
            this.txt_addres.ReadOnly = true;
            this.txt_addres.Size = new System.Drawing.Size(420, 23);
            this.txt_addres.TabIndex = 0;
            this.txt_addres.TabStop = false;
            // 
            // btn_addres
            // 
            this.btn_addres.Location = new System.Drawing.Point(436, 8);
            this.btn_addres.Name = "btn_addres";
            this.btn_addres.Size = new System.Drawing.Size(138, 31);
            this.btn_addres.TabIndex = 2;
            this.btn_addres.Text = "انتخاب فایل مبدأ";
            this.btn_addres.UseVisualStyleBackColor = true;
            this.btn_addres.Click += new System.EventHandler(this.btn_addres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(417, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "تعداد لینک های استخراج شده :";
            // 
            // lblex
            // 
            this.lblex.AutoSize = true;
            this.lblex.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblex.Location = new System.Drawing.Point(395, 460);
            this.lblex.Name = "lblex";
            this.lblex.Size = new System.Drawing.Size(16, 18);
            this.lblex.TabIndex = 3;
            this.lblex.Text = "0";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 46);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 29);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "شروع";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_links
            // 
            this.txt_links.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_links.Location = new System.Drawing.Point(12, 81);
            this.txt_links.Multiline = true;
            this.txt_links.Name = "txt_links";
            this.txt_links.ReadOnly = true;
            this.txt_links.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_links.Size = new System.Drawing.Size(564, 333);
            this.txt_links.TabIndex = 5;
            this.txt_links.TabStop = false;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(122, 420);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(104, 54);
            this.btn_Copy.TabIndex = 5;
            this.btn_Copy.Text = "کپی";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(12, 420);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(104, 54);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "شروع دوباره";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(93, 49);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.ReadOnly = true;
            this.txt_folder.Size = new System.Drawing.Size(339, 23);
            this.txt_folder.TabIndex = 0;
            this.txt_folder.TabStop = false;
            this.txt_folder.Visible = false;
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(438, 45);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(138, 31);
            this.btn_folder.TabIndex = 3;
            this.btn_folder.Text = "انتخاب پوشه مقصد";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Visible = false;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // rb_extract
            // 
            this.rb_extract.AutoSize = true;
            this.rb_extract.Location = new System.Drawing.Point(357, 426);
            this.rb_extract.Name = "rb_extract";
            this.rb_extract.Size = new System.Drawing.Size(128, 21);
            this.rb_extract.TabIndex = 1;
            this.rb_extract.Text = "استخراج لینک ها";
            this.rb_extract.UseVisualStyleBackColor = true;
            // 
            // rb_download
            // 
            this.rb_download.AutoSize = true;
            this.rb_download.Location = new System.Drawing.Point(480, 426);
            this.rb_download.Name = "rb_download";
            this.rb_download.Size = new System.Drawing.Size(110, 21);
            this.rb_download.TabIndex = 0;
            this.rb_download.Text = "دانلود لینک ها";
            this.rb_download.UseVisualStyleBackColor = true;
            this.rb_download.CheckedChanged += new System.EventHandler(this.rb_download_CheckedChanged);
            // 
            // linke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 486);
            this.Controls.Add(this.rb_extract);
            this.Controls.Add(this.rb_download);
            this.Controls.Add(this.txt_links);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lblex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.btn_addres);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.txt_addres);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "linke";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استخراج و دانلود لینک ها";
            this.Load += new System.EventHandler(this.linke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_addres;
        private System.Windows.Forms.Button btn_addres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblex;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_links;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.RadioButton rb_extract;
        private System.Windows.Forms.RadioButton rb_download;
    }
}