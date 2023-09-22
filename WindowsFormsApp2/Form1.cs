using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int GetSelectedRow(string studentId)
        {
            for(int i = 0; i < studentList.Rows.Count; i++)
            {
                if(studentList.Rows[i].Cells[0].Value.ToString() == studentId)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            studentList.Rows[selectedRow].Cells[0].Value = txtId.Text;

            studentList.Rows[selectedRow].Cells[1].Value = txtName.Text;
            if(radioMale.Checked == true)
            {
                studentList.Rows[selectedRow].Cells[2].Value = radioMale.Text;
            }
            if(radioFemale.Checked==true)
            {
                studentList.Rows[selectedRow].Cells[2].Value = radioFemale.Text;
            }
            
            studentList.Rows[selectedRow].Cells[3].Value = float.Parse(txtGpa.Text).ToString();
            studentList.Rows[selectedRow].Cells[4].Value = comboFaculity.Text;
        }
        //task là có labelID, thì làm xóa cái label
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = -1;

                    if (txtName.Text == "" || txtId.Text == "" || txtGpa.Text == "" || comboFaculity.Text == "")
                    {
                        throw new Exception("vui lòng nhập lại đầy đủ thông tin sinh viên");
                    }
                    else
                    {
                        selectedRow = GetSelectedRow(txtId.Text);
                        if(selectedRow == -1)
                        {
                            selectedRow = studentList.Rows.Add();
                            InsertUpdate(selectedRow);
                            MessageBox.Show("Thêm dữ liệu thành công!","Thông báo",MessageBoxButtons.OK);
                        }
                        else
                        {
                            InsertUpdate(selectedRow);
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                Analyst();
                }

                
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtId.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy sinh viên cần xóa!");
                }
                else
                {
                    studentList.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                Analyst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void studentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtId.Text = studentList.Rows[index].Cells[0].Value.ToString();
            txtName.Text = studentList.Rows[index].Cells[1].Value.ToString();
            if (studentList.Rows[index].Cells[2].Value.ToString().Equals("Nam")){
                radioMale.Checked = true;
                radioFemale.Checked = false;
            }
            else
            {
                radioMale.Checked = false;
                radioFemale.Checked = true ;
            }
            txtGpa.Text = studentList.Rows[index].Cells[3].Value.ToString();
            comboFaculity.Text = studentList.Rows[index].Cells[4].Value.ToString();
        }
        private void Analyst()
        {
            int count_male = 0;
            int count_female = 0;
            for (int i = 0; i < studentList.Rows.Count; i++)
            {
                if (studentList.Rows[i].Cells[2].Value.ToString().Equals("Nam"))
                {
                    count_male++;
                }
                if (studentList.Rows[i].Cells[2].Value.ToString().Equals("Nữ"))
                {
                    count_female++;
                }
            }
            countMale.Text = count_male.ToString();
            countFemale.Text = count_female.ToString();
        }
    }
}
