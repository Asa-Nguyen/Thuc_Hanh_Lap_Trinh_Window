
namespace Lab03_03
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
            this.studentList = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faculity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.AllowUserToAddRows = false;
            this.studentList.AllowUserToDeleteRows = false;
            this.studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mssv,
            this.ten,
            this.faculity,
            this.gpa});
            this.studentList.Location = new System.Drawing.Point(-1, 129);
            this.studentList.Name = "studentList";
            this.studentList.ReadOnly = true;
            this.studentList.Size = new System.Drawing.Size(801, 322);
            this.studentList.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "số thứ tự";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "Mã số sinh viên";
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.HeaderText = "Họ tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // faculity
            // 
            this.faculity.HeaderText = "Khoa";
            this.faculity.Name = "faculity";
            this.faculity.ReadOnly = true;
            // 
            // gpa
            // 
            this.gpa.HeaderText = "điểm tb";
            this.gpa.Name = "gpa";
            this.gpa.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 72);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(459, 72);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(100, 20);
            this.textBoxFind.TabIndex = 2;
            this.textBoxFind.Text = "Tìm kiếm theo tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpa;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBoxFind;
    }
}

