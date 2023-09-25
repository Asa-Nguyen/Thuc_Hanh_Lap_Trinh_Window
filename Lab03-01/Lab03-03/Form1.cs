using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
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
            
        }
    }
}
