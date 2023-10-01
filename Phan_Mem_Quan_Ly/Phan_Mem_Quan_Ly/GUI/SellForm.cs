using Phan_Mem_Quan_Ly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.GUI
{
    public partial class SellForm : Form
    {


        public SellForm()
        {
            InitializeComponent();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            InitialTableList();
            using(var dbContext = new Manager())
            {
                ComboxCategory.DataSource = dbContext.Danh_Mucs.Select(c => new {c.Ten,c.Ma}).ToList();

            }
/*            ConfigSetting();*/
        }
        private void InitialTableList()
        {
            int x = 74; int y = 39; int i = 1;
            using (var dbContext = new Manager())
            {
                foreach (var table in dbContext.Bans.Select(c => new {c.Ten, c.Ma }).ToList())
                {
                    DrawTable(x, y, table.Ma);

                    if (i++ % 5 == 0)
                    {
                        x = 74;
                        y += 150;
                    }
                    x += 150;
                }
            }
                
        }

        private void DrawTable(int x, int y, int table)
        {
            Button btn = new Button();
            btn.Text = table.ToString();
            btn.Tag = table.ToString();
            btn.Size = new Size(60,60);
            btn.Location = new Point(x,y);
            btn.BackColor = Color.White;
            TableList.Controls.Add(btn);
/*            btn.Click += Btn_Click;*/
        }
/*        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            using (var dbContext = new Manager())
            {
                foreach(var table in dbContext.Bans.Select(c => new { c.Ma, c.Ten }).ToList())
                {
                    if (table == null)
                    {
                        table = btn;
                        pointer.BackColor = Color.Yellow;
                    }
                    else if (pointer != btn)
                    {
                        pointer.BackColor = Color.White;
                        pointer = btn;
                        pointer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        pointer.BackColor = Color.Yellow;
                        pointer = null;
                    }
                }
            }
                
        }*/
        private void ConfigSetting()
        {
            using (var dbContext = new Manager())
            {
                foreach (var category in dbContext.Danh_Mucs.Select(c => new { c.Ten, c.Ma }).ToList())
                {
                    ComboxCategory.DisplayMember = category.Ten.ToString();
                    ComboxCategory.ValueMember = category.Ma.ToString();
                    ComboxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
/*            ComboxCategory.DisplayMember = "NameCategory";
            ComboxCategory.ValueMember = "IdCategory";
            ComboxCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboxDrink.DisplayMember = "nameDrink";
            ComboxDrink.ValueMember = "idDrink";
            ComboxDrink.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboxTable.DisplayMember = "id_table";
            ComboxTable.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }




    }
}
