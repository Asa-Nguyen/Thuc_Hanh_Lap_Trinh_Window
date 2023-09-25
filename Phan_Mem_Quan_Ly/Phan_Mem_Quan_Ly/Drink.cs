using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Mem_Quan_Ly
{
    internal class Drink
    {
        public int IdDrink {  get; set; }
        public string NameDrink { get; set; }
        public float price {  get; set; }
        public Drink() { }
        public Drink(int idDrink, string nameDrink, float price)
        {
            IdDrink = idDrink;
            NameDrink = nameDrink;
            this.price = price;
        }
    }
}
