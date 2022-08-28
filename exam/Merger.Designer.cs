namespace exam
{
    partial class Merger
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_megexams = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dg_exam = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_megexams)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_exam);
            this.groupBox1.Location = new System.Drawing.Point(505, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "آزمون ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_megexams);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "آزمون های ادغام شده";
            // 
            // dg_megexams
            // 
            this.dg_megexams.AllowUserToAddRows = false;
            this.dg_megexams.AllowUserToDeleteRows = false;
            this.dg_megexams.AllowUserToResizeColumns = false;
            this.dg_megexams.AllowUserToResizeRows = false;
            this.dg_megexams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_megexams.ColumnHeadersHeight = 29;
            this.dg_megexams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_megexams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exrow,
            this.Exname,
            this.Excount,
            this.Exnumber});
            this.dg_megexams.Location = new System.Drawing.Point(12, 22);
            this.dg_megexams.Name = "dg_megexams";
            this.dg_megexams.ReadOnly = true;
            this.dg_megexams.RowHeadersVisible = false;
            this.dg_megexams.RowHeadersWidth = 51;
            this.dg_megexams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_megexams.RowTemplate.Height = 24;
            this.dg_megexams.Size = new System.Drawing.Size(469, 256);
            this.dg_megexams.TabIndex = 0;
            this.dg_megexams.TabStop = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(12, 371);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(97, 37);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "ثبت";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام آزمون :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(6, 16);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(581, 23);
            this.txt_Name.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(581, 371);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "افزودن";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dg_exam
            // 
            this.dg_exam.AllowUserToAddRows = false;
            this.dg_exam.AllowUserToDeleteRows = false;
            this.dg_exam.AllowUserToResizeColumns = false;
            this.dg_exam.AllowUserToResizeRows = false;
            this.dg_exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_exam.ColumnHeadersHeight = 29;
            this.dg_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names});
            this.dg_exam.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_exam.Location = new System.Drawing.Point(6, 22);
            this.dg_exam.Name = "dg_exam";
            this.dg_exam.ReadOnly = true;
            this.dg_exam.RowHeadersVisible = false;
            this.dg_exam.RowHeadersWidth = 51;
            this.dg_exam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_exam.RowTemplate.Height = 24;
            this.dg_exam.Size = new System.Drawing.Size(161, 256);
            this.dg_exam.TabIndex = 1;
            this.dg_exam.TabStop = false;
            // 
            // Names
            // 
            this.Names.HeaderText = "نام آزمون";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Exrow
            // 
            this.Exrow.HeaderText = "ردیف";
            this.Exrow.MinimumWidth = 6;
            this.Exrow.Name = "Exrow";
            this.Exrow.ReadOnly = true;
            // 
            // Exname
            // 
            this.Exname.HeaderText = "نام آزمون";
            this.Exname.MinimumWidth = 6;
            this.Exname.Name = "Exname";
            this.Exname.ReadOnly = true;
            // 
            // Excount
            // 
            this.Excount.HeaderText = "تعداد سوالات";
            this.Excount.MinimumWidth = 6;
            this.Excount.Name = "Excount";
            this.Excount.ReadOnly = true;
            // 
            // Exnumber
            // 
            this.Exnumber.HeaderText = "شماره سوالات";
            this.Exnumber.MinimumWidth = 6;
            this.Exnumber.Name = "Exnumber";
            this.Exnumber.ReadOnly = true;
            // 
            // Merger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Merger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادغام";
            this.Load += new System.EventHandler(this.Merger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_megexams)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_exam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_megexams;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dg_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Excount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exnumber;
    }
}