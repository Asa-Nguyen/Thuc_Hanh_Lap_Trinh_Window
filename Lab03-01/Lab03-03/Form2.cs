using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab03_03
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.form1 = f;
        }

        public int GetSelectedRow(string Id)
        {
            for (int i = 0; i < form1.studentList.Rows.Count; i++)
            {
                if (form1.studentList.Rows[i].Cells[1].Value.ToString() == Id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void InsertUpdate(int selectedRow)
        {
            form1.studentList.Rows[selectedRow].Cells[0].Value = form1.studentList.RowCount;
            form1.studentList.Rows[selectedRow].Cells[1].Value = textBoxId.Text;
            form1.studentList.Rows[selectedRow].Cells[2].Value = textBoxName.Text;
            form1.studentList.Rows[selectedRow].Cells[3].Value = comboBoxFaculity.Text;
            form1.studentList.Rows[selectedRow].Cells[4].Value = textBoxGpa.Text;
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRow = -1;

                if (textBoxId.Text == "" || textBoxName.Text == "" || comboBoxFaculity.Text == "" || textBoxGpa.Text == "")
                {
                    throw new Exception("vui lòng nhập lại đầy đủ thông tin sinh vien");
                }
                else
                {
                        selectedRow = form1.studentList.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
