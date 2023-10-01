using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Phan_Mem_Quan_Ly.View_Models
{
    internal class Drink
    {
        private int id;
        private string name;
        private int price;
        private string id_category;
        public Drink(int id, string name, int price, string id_category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.id_category = id_category;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Id_category { get => id_category; set => id_category = value; }
    }
}
