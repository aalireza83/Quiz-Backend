namespace exam
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_exName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_Questions = new System.Windows.Forms.Button();
            this.btn_addQuestions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_count);
            this.groupBox1.Controls.Add(this.txt_exName);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.lbl_count);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(6, 22);
            this.txt_count.Name = "txt_count";
            this.txt_count.ReadOnly = true;
            this.txt_count.Size = new System.Drawing.Size(120, 23);
            this.txt_count.TabIndex = 7;
            this.txt_count.TabStop = false;
            // 
            // txt_exName
            // 
            this.txt_exName.Location = new System.Drawing.Point(269, 21);
            this.txt_exName.Name = "txt_exName";
            this.txt_exName.ReadOnly = true;
            this.txt_exName.Size = new System.Drawing.Size(225, 23);
            this.txt_exName.TabIndex = 5;
            this.txt_exName.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(500, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(71, 17);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "نام آزمون : ";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(132, 25);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(131, 17);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "تعداد سوالات آزمون : ";
            // 
            // btn_Questions
            // 
            this.btn_Questions.Location = new System.Drawing.Point(281, 79);
            this.btn_Questions.Name = "btn_Questions";
            this.btn_Questions.Size = new System.Drawing.Size(151, 42);
            this.btn_Questions.TabIndex = 2;
            this.btn_Questions.Text = "مشاهده سوالات";
            this.btn_Questions.UseVisualStyleBackColor = true;
            this.btn_Questions.Click += new System.EventHandler(this.btn_Questions_Click);
            // 
            // btn_addQuestions
            // 
            this.btn_addQuestions.Location = new System.Drawing.Point(438, 79);
            this.btn_addQuestions.Name = "btn_addQuestions";
            this.btn_addQuestions.Size = new System.Drawing.Size(151, 42);
            this.btn_addQuestions.TabIndex = 2;
            this.btn_addQuestions.Text = "افزودن سوال جدید";
            this.btn_addQuestions.UseVisualStyleBackColor = true;
            this.btn_addQuestions.Click += new System.EventHandler(this.btn_addQuestions_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 133);
            this.Controls.Add(this.btn_addQuestions);
            this.Controls.Add(this.btn_Questions);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_exName;
        private System.Windows.Forms.Button btn_Questions;
        private System.Windows.Forms.Button btn_addQuestions;
        private System.Windows.Forms.TextBox txt_count;
    }
}