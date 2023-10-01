using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
namespace Lab03_03
{

    public partial class Form1 : Form
    {
        bool start = false;
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Student Hung = new Student("2180607588", "Nguyen Hung", "CNTT", 4.0);
            students.Add(Hung);
            for(int i = 0; i < students.Count; i++)
            {
                studentList.Rows.Add();
                studentList.Rows[i].Cells[0].Value = i+1;
                studentList.Rows[i].Cells[1].Value = students[i].Id;
                studentList.Rows[i].Cells[2].Value = students[i].Name;
                studentList.Rows[i].Cells[3].Value = students[i].Faculity;
                studentList.Rows[i].Cells[4].Value = students[i].Gpa;
            }
        }





        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string searchText = textBoxFind.Text.Trim().ToLower();

            foreach (DataGridViewRow row in studentList.Rows)
            {
                string cellValue = row.Cells["ten"].Value.ToString().ToLower();

                if (cellValue.Contains(searchText))
                {
                    // Change the background color of the matching row to yellow
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    // Reset the background color to the default
                    row.DefaultCellStyle.BackColor = studentList.DefaultCellStyle.BackColor;
                }
            }
        }

    }
}
