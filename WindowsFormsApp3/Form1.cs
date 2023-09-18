using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnChooseASeat(object  sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Blue;
            else if (btn.BackColor == Color.Blue)
                btn.BackColor = Color.White;
            else if(btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được bán");
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int count_1 = 0;
            if (button1.BackColor == Color.Blue)
            {
                count_1++;
                button1.BackColor = Color.Yellow;
            }
            if (button2.BackColor == Color.Blue)
            {
                count_1++;
                button2.BackColor = Color.Yellow;
            }
            if (button3.BackColor == Color.Blue)
            {
                count_1++;
                button3.BackColor = Color.Yellow;
            }
            if (button4.BackColor == Color.Blue)
            {
                count_1++;
                button4.BackColor = Color.Yellow;
            }
            if (button5.BackColor == Color.Blue)
            {
                count_1++;
                button5.BackColor = Color.Yellow;
            }
            int count_2 = 0;
            if (button6.BackColor == Color.Blue)
            {
                count_2++;
                button6.BackColor = Color.Yellow;
            }
            if (button7.BackColor == Color.Blue)
            {
                count_2++;
                button7.BackColor = Color.Yellow;
            }
            if (button8.BackColor == Color.Blue)
            {
                count_2++;
                button8.BackColor = Color.Yellow;
            }
            if (button9.BackColor == Color.Blue)
            {
                count_2++;
                button9.BackColor = Color.Yellow;
            }
            if (button10.BackColor == Color.Blue)
            {
                count_2++;
                button10.BackColor = Color.Yellow;
            }
            int count_3 = 0;
            if (button11.BackColor == Color.Blue)
            {
                count_3++;
                button11.BackColor = Color.Yellow;
            }
            if (button12.BackColor == Color.Blue)
            {
                count_3++;
                button12.BackColor = Color.Yellow;
            }
            if (button13.BackColor == Color.Blue)
            {
                count_3++;
                button13.BackColor = Color.Yellow;
            }
            if (button14.BackColor == Color.Blue)
            {
                count_3++;
                button14.BackColor = Color.Yellow;
            }
            if (button15.BackColor == Color.Blue)
            {
                count_3++;
                button15.BackColor = Color.Yellow;
            }
            int count_4 = 0;
            if (button16.BackColor == Color.Blue)
            {
                count_4++;
                button16.BackColor = Color.Yellow;
            }
            if (button17.BackColor == Color.Blue)
            {
                count_4++;
                button17.BackColor = Color.Yellow;
            }
            if (button18.BackColor == Color.Blue)
            {
                count_4++;
                button18.BackColor = Color.Yellow;
            }
            if (button19.BackColor == Color.Blue)
            {
                count_4++;
                button19.BackColor = Color.Yellow;
            }
            if (button20.BackColor == Color.Blue)
            {
                count_4++;
                button20.BackColor = Color.Yellow;
            }
            int money = 30000 * count_1 + 40000 * count_2 + 50000 * count_3 + 80000 * count_4;
            textBox1.Text = money.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
