namespace exam
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_questions = new System.Windows.Forms.Button();
            this.btn_meger = new System.Windows.Forms.Button();
            this.btn_upload_questions = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_downloads = new System.Windows.Forms.Button();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.btn_SentMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 87);
            this.button2.TabIndex = 2;
            this.button2.Text = "استخراج لینک ها از بانک سوال";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_questions
            // 
            this.btn_questions.Location = new System.Drawing.Point(168, 12);
            this.btn_questions.Name = "btn_questions";
            this.btn_questions.Size = new System.Drawing.Size(150, 87);
            this.btn_questions.TabIndex = 0;
            this.btn_questions.Text = "پیدا کردن سوالات";
            this.btn_questions.UseVisualStyleBackColor = true;
            this.btn_questions.Click += new System.EventHandler(this.btn_questions_Click);
            // 
            // btn_meger
            // 
            this.btn_meger.Location = new System.Drawing.Point(168, 105);
            this.btn_meger.Name = "btn_meger";
            this.btn_meger.Size = new System.Drawing.Size(150, 87);
            this.btn_meger.TabIndex = 1;
            this.btn_meger.Text = "ادغام آزمون ها";
            this.btn_meger.UseVisualStyleBackColor = true;
            this.btn_meger.Click += new System.EventHandler(this.btn_meger_Click);
            // 
            // btn_upload_questions
            // 
            this.btn_upload_questions.Location = new System.Drawing.Point(12, 12);
            this.btn_upload_questions.Name = "btn_upload_questions";
            this.btn_upload_questions.Size = new System.Drawing.Size(150, 87);
            this.btn_upload_questions.TabIndex = 0;
            this.btn_upload_questions.Text = "آپلود سوالات";
            this.btn_upload_questions.UseVisualStyleBackColor = true;
            this.btn_upload_questions.Click += new System.EventHandler(this.btn_upload_questions_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.Location = new System.Drawing.Point(12, 105);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(150, 87);
            this.btn_Users.TabIndex = 2;
            this.btn_Users.Text = "کاربران";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Messages
            // 
            this.btn_Messages.Location = new System.Drawing.Point(12, 198);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Size = new System.Drawing.Size(150, 87);
            this.btn_Messages.TabIndex = 1;
            this.btn_Messages.Text = "یپام های دریافتی";
            this.btn_Messages.UseVisualStyleBackColor = true;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // btn_downloads
            // 
            this.btn_downloads.Location = new System.Drawing.Point(168, 198);
            this.btn_downloads.Name = "btn_downloads";
            this.btn_downloads.Size = new System.Drawing.Size(150, 87);
            this.btn_downloads.TabIndex = 2;
            this.btn_downloads.Text = "سوالات دانلود شده";
            this.btn_downloads.UseVisualStyleBackColor = true;
            this.btn_downloads.Click += new System.EventHandler(this.btn_downloads_Click);
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(168, 291);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(150, 87);
            this.btn_SendMessage.TabIndex = 1;
            this.btn_SendMessage.Text = "ارسال پیام";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // btn_SentMessages
            // 
            this.btn_SentMessages.Location = new System.Drawing.Point(12, 291);
            this.btn_SentMessages.Name = "btn_SentMessages";
            this.btn_SentMessages.Size = new System.Drawing.Size(150, 87);
            this.btn_SentMessages.TabIndex = 1;
            this.btn_SentMessages.Text = "پیام های ارسال شده";
            this.btn_SentMessages.UseVisualStyleBackColor = true;
            this.btn_SentMessages.Click += new System.EventHandler(this.btn_SentMessages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.btn_SentMessages);
            this.Controls.Add(this.btn_Messages);
            this.Controls.Add(this.btn_meger);
            this.Controls.Add(this.btn_upload_questions);
            this.Controls.Add(this.btn_questions);
            this.Controls.Add(this.btn_downloads);
            this.Controls.Add(this.btn_Users);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کمک یار quiz 24";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_questions;
        private System.Windows.Forms.Button btn_meger;
        private System.Windows.Forms.Button btn_upload_questions;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_downloads;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.Button btn_SentMessages;
    }
}

