using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        List<Person> customers = new List<Person>();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person Hung = new Person("2180607588", "Nguyễn Hưng", "Hà Nội", 5000000000);
            Person Huy = new Person("2180607599", "Nguyễn Mai Bảo Huy", "Đắk Lắk", 3000000000);
            Person Dung = new Person("2180607500", "Nguyễn Tấn Dũng", "Đắk Lắk", 2000000000);
            Person Khai = new Person("2180607577", "Nguyễn Anh Khải", "Khánh Hòa", 10000000000);
            customers.Add(Hung);
            customers.Add(Huy);
            customers.Add(Khai);
            customers.Add(Dung);
            double sum = 0;
            for(int i = 0; i < customers.Count; i++)
            {
                customerList.Rows.Add();
                customerList.Rows[i].Cells[0].Value = i+1;
                customerList.Rows[i].Cells[1].Value = customers[i].Id;
                customerList.Rows[i].Cells[2].Value = customers[i].Name;
                customerList.Rows[i].Cells[3].Value = customers[i].Address;
                customerList.Rows[i].Cells[4].Value = customers[i].Asset;
                sum += customers[i].Asset;
            }
            textSumAsset.Text = sum.ToString();
        }
        private int GetSelectedRow(string Id)
        {
            for (int i = 0; i < customerList.Rows.Count; i++)
            {
                if (customerList.Rows[i].Cells[1].Value.ToString() == Id)
                {
                    return i;
                }
            }
            return -1;
        }
        void InsertUpdate(int selectedRow)
        {
                Person person = new Person(textId.Text, textName.Text, textAddress.Text, double.Parse(textAsset.Text));
                customerList.Rows[selectedRow].Cells[0].Value = customerList.RowCount + 1;
                customerList.Rows[selectedRow].Cells[1].Value = textId.Text;
                customerList.Rows[selectedRow].Cells[2].Value = textName.Text;
                customerList.Rows[selectedRow].Cells[3].Value = textAddress.Text;
                customerList.Rows[selectedRow].Cells[4].Value = textAsset.Text;
        }
        private void buttonInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = -1;

                if (textId.Text == "" || textName.Text == "" || textAddress.Text == "" || textAsset.Text == "")
                {
                    throw new Exception("vui lòng nhập lại đầy đủ thông tin khách hàng");
                }
                else
                {
                    selectedRow = GetSelectedRow(textId.Text);
                    if (selectedRow == -1)
                    {
                        selectedRow = customerList.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Đã cập nhật lại dữ liệu!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            textId.Text = customerList.Rows[index].Cells[1].Value.ToString();
            textName.Text = customerList.Rows[index].Cells[2].Value.ToString();
            textAddress.Text = customerList.Rows[index].Cells[3].Value.ToString();
            textAsset.Text = customerList.Rows[index].Cells[4].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(textId.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy khách hàng cần xóa!");
                }
                else
                {
                    customerList.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    
}
