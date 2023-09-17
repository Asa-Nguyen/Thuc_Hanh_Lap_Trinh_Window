using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    abstract class Person
    {
        private  string name;
        private string id;
        public Person() { }
        public Person(string name, string id)
        {
            this.name = name;
            this.Id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        abstract public void Input();
        abstract public void Output();

    }
}
