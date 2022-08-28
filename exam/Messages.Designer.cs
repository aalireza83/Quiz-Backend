namespace exam
{
    partial class Messages
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.cb_read = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fromcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "فرستنده :";
            // 
            // txt_From
            // 
            this.txt_From.Enabled = false;
            this.txt_From.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_From.Location = new System.Drawing.Point(12, 12);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(193, 28);
            this.txt_From.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "آیدی و یا ایمیل فرستنده :";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Id.Location = new System.Drawing.Point(12, 80);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(193, 28);
            this.txt_Id.TabIndex = 29;
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_code.Location = new System.Drawing.Point(285, 46);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(216, 28);
            this.txt_code.TabIndex = 30;
            // 
            // txt_Date
            // 
            this.txt_Date.Enabled = false;
            this.txt_Date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Date.Location = new System.Drawing.Point(12, 46);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(193, 28);
            this.txt_Date.TabIndex = 31;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(519, 367);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 33);
            this.btn_next.TabIndex = 26;
            this.btn_next.Text = "بعدی";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(438, 367);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 33);
            this.btn_Previous.TabIndex = 27;
            this.btn_Previous.Text = "قبلی";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // cb_read
            // 
            this.cb_read.AutoSize = true;
            this.cb_read.Location = new System.Drawing.Point(10, 374);
            this.cb_read.Name = "cb_read";
            this.cb_read.Size = new System.Drawing.Size(100, 21);
            this.cb_read.TabIndex = 25;
            this.cb_read.Text = "خوانده شده";
            this.cb_read.UseVisualStyleBackColor = true;
            this.cb_read.CheckedChanged += new System.EventHandler(this.cb_read_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "کد پیام : ";
            // 
            // txt_Message
            // 
            this.txt_Message.Enabled = false;
            this.txt_Message.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Message.Location = new System.Drawing.Point(10, 136);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(584, 225);
            this.txt_Message.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "تاریخ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "متن پیام :";
            // 
            // txt_fromcode
            // 
            this.txt_fromcode.Enabled = false;
            this.txt_fromcode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_fromcode.Location = new System.Drawing.Point(285, 12);
            this.txt_fromcode.Name = "txt_fromcode";
            this.txt_fromcode.Size = new System.Drawing.Size(216, 28);
            this.txt_fromcode.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "کد فرستنده :";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fromcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.cb_read);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Messages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام ها";
            this.Load += new System.EventHandler(this.Messages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.CheckBox cb_read;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fromcode;
        private System.Windows.Forms.Label label6;
    }
}