using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.GUI
{
    public partial class SellForm : Form
    {
        List<Table> tables = new List<Table>();
        List<Category> categories = new List<Category>();
        List<Drink> drinks = new List<Drink>();
        Button pointer = new Button();


        public SellForm()
        {
            InitializeComponent();
            for (int i = 1; i < 26; i++)
            {
                tables.Add(new Table(i, "Table" + i));
            }
            categories = new List<Category>()
            {
                new Category(){IdCategory = 1, NameCategory = "Cafe"},
                new Category(){IdCategory = 2, NameCategory = "Juice"}
            };
            drinks = new List<Drink>()
            {
                new Drink(1,"Milk Cafe",30000),
                new Drink(2,"Black Cafe",20000),
                new Drink(3,"Apple juice",40000),
                new Drink(4,"Mango juice",50000),
            };
            pointer = null;
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            InitialTableList();
            ComboxCategory.DataSource = categories;
            ComboxDrink.DataSource = drinks;
            ComboxTable.DataSource = tables;
            ConfigSetting();
        }
        private void InitialTableList()
        {
            int x = 74; int y = 39; int i = 1;
            foreach (Table table in tables)
            {
                DrawTable(x,y,table);
                
                if (i++ %5==0)
                {
                    x = 74;
                    y += 150;
                }
                x += 150;
            }
        }

        private void DrawTable(int x, int y, Table table)
        {
            Button btn = new Button();
            btn.Text = table.name_table;
            btn.Tag = table.id_table;
            btn.Size = new Size(60,60);
            btn.Location = new Point(x,y);
            btn.BackColor = Color.White;
            TableList.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 
            if(pointer == null)
            {
                pointer = btn;
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
        private void ConfigSetting()
        {
            ComboxCategory.DisplayMember = "NameCategory";
            ComboxCategory.ValueMember = "IdCategory";
            ComboxCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboxDrink.DisplayMember = "nameDrink";
            ComboxDrink.ValueMember = "idDrink";
            ComboxDrink.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboxTable.DisplayMember = "id_table";
            ComboxTable.DropDownStyle = ComboBoxStyle.DropDownList;
        }




    }
}
