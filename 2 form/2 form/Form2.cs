using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_form
{
    public partial class Form2 : Form
    {
        Form1 Form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.Form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.dataGridView1.Rows.Add(textBox1,textBox2,textBox3);
        }
    }
}
