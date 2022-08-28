namespace exam
{
    partial class Uploader
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
            this.dg_exam = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_upload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_uploads = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_exam)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_uploads)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_exam);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست آزمون ها";
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
            this.dg_exam.Size = new System.Drawing.Size(313, 168);
            this.dg_exam.TabIndex = 0;
            this.dg_exam.TabStop = false;
            // 
            // Names
            // 
            this.Names.HeaderText = "نام آزمون";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(577, 214);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(91, 41);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "آپلود";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_uploads);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 196);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست آپلود ها";
            // 
            // dg_uploads
            // 
            this.dg_uploads.AllowUserToAddRows = false;
            this.dg_uploads.AllowUserToDeleteRows = false;
            this.dg_uploads.AllowUserToResizeColumns = false;
            this.dg_uploads.AllowUserToResizeRows = false;
            this.dg_uploads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_uploads.ColumnHeadersHeight = 29;
            this.dg_uploads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_uploads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Uploaded});
            this.dg_uploads.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_uploads.Location = new System.Drawing.Point(6, 22);
            this.dg_uploads.Name = "dg_uploads";
            this.dg_uploads.ReadOnly = true;
            this.dg_uploads.RowHeadersVisible = false;
            this.dg_uploads.RowHeadersWidth = 51;
            this.dg_uploads.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_uploads.RowTemplate.Height = 24;
            this.dg_uploads.Size = new System.Drawing.Size(313, 168);
            this.dg_uploads.TabIndex = 0;
            this.dg_uploads.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "نام آزمون";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "فایل آپلود شده";
            this.Uploaded.MinimumWidth = 6;
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(246, 214);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 41);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 267);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_upload);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Uploader";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آپلود سوالات";
            this.Load += new System.EventHandler(this.Uploader_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_exam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_uploads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_uploads;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.Button btn_delete;
    }
}