namespace exam
{
    partial class send_message
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Date = new System.Windows.Forms.MaskedTextBox();
            this.txt_messagecode = new System.Windows.Forms.NumericUpDown();
            this.cb_sender = new System.Windows.Forms.CheckBox();
            this.cb_messagecode = new System.Windows.Forms.CheckBox();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Sender = new System.Windows.Forms.TextBox();
            this.cb_code = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_messagecode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 476);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 36);
            this.btn_send.TabIndex = 38;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Message.Location = new System.Drawing.Point(12, 208);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(464, 262);
            this.txt_Message.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "متن پیام :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.txt_messagecode);
            this.groupBox1.Controls.Add(this.cb_sender);
            this.groupBox1.Controls.Add(this.cb_messagecode);
            this.groupBox1.Controls.Add(this.cb_date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Sender);
            this.groupBox1.Controls.Add(this.cb_code);
            this.groupBox1.Controls.Add(this.cb_type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 173);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(120, 80);
            this.txt_Date.Mask = "90:00:00 0000/00/00";
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(223, 23);
            this.txt_Date.TabIndex = 52;
            // 
            // txt_messagecode
            // 
            this.txt_messagecode.Location = new System.Drawing.Point(120, 23);
            this.txt_messagecode.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txt_messagecode.Name = "txt_messagecode";
            this.txt_messagecode.Size = new System.Drawing.Size(223, 23);
            this.txt_messagecode.TabIndex = 51;
            // 
            // cb_sender
            // 
            this.cb_sender.AutoSize = true;
            this.cb_sender.Location = new System.Drawing.Point(51, 53);
            this.cb_sender.Name = "cb_sender";
            this.cb_sender.Size = new System.Drawing.Size(63, 21);
            this.cb_sender.TabIndex = 46;
            this.cb_sender.Text = "ادمین";
            this.cb_sender.UseVisualStyleBackColor = true;
            this.cb_sender.CheckedChanged += new System.EventHandler(this.cb_sender_CheckedChanged);
            // 
            // cb_messagecode
            // 
            this.cb_messagecode.AutoSize = true;
            this.cb_messagecode.Location = new System.Drawing.Point(46, 26);
            this.cb_messagecode.Name = "cb_messagecode";
            this.cb_messagecode.Size = new System.Drawing.Size(68, 21);
            this.cb_messagecode.TabIndex = 47;
            this.cb_messagecode.Text = "خودکار";
            this.cb_messagecode.UseVisualStyleBackColor = true;
            this.cb_messagecode.CheckedChanged += new System.EventHandler(this.cb_messagecode_CheckedChanged);
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Location = new System.Drawing.Point(6, 82);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(108, 21);
            this.cb_date.TabIndex = 48;
            this.cb_date.Text = "زمان سیستم";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "کد پیام :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "زمان ارسال پیام :";
            // 
            // txt_Sender
            // 
            this.txt_Sender.Location = new System.Drawing.Point(120, 51);
            this.txt_Sender.Name = "txt_Sender";
            this.txt_Sender.Size = new System.Drawing.Size(223, 23);
            this.txt_Sender.TabIndex = 41;
            // 
            // cb_code
            // 
            this.cb_code.FormattingEnabled = true;
            this.cb_code.Items.AddRange(new object[] {
            "همگانی",
            "شخصی"});
            this.cb_code.Location = new System.Drawing.Point(120, 139);
            this.cb_code.Name = "cb_code";
            this.cb_code.Size = new System.Drawing.Size(223, 24);
            this.cb_code.TabIndex = 39;
            this.cb_code.Visible = false;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "همگانی",
            "شخصی"});
            this.cb_type.Location = new System.Drawing.Point(120, 109);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(223, 24);
            this.cb_type.TabIndex = 40;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "فرستنده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "نوع پیام :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "کد کاربر :";
            this.label3.Visible = false;
            // 
            // send_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "send_message";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "زمان ارسال پیام :";
            this.Load += new System.EventHandler(this.send_message_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_messagecode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_sender;
        private System.Windows.Forms.CheckBox cb_messagecode;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Sender;
        private System.Windows.Forms.ComboBox cb_code;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_messagecode;
        private System.Windows.Forms.MaskedTextBox txt_Date;
    }
}