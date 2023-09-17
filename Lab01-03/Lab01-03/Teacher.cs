using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Teacher : Person
    {
        private double salary;
        private string address;
        public Teacher() { }
        public Teacher(string id, string name, long salary,string address) : base(id,name) { 
            this.salary = salary;
            this.address = address;
        }
        public double Salary { get => salary; set => salary = value; }
        public string Address { get => address; set => address = value; }

        public override void Input()
        {
            Console.WriteLine("Enter teacher ID: ");
            Id = Console.ReadLine();
            Console.WriteLine("Enter teacher name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter teacher salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher address: ");
            Address = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine("ID:{0} Name: {1} Faculity: {2} GPA: {3}", Id, Name, this.salary, this.address);
        }
    }
}
