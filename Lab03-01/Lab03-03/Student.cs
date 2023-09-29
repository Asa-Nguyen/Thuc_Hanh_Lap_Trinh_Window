using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_03
{
    class Student
    {
        private string id;
        private string name;
        private string faculity;
        private double gpa;

        public Student(string id, string name, string faculity, double gpa)
        {
            this.id = id;
            this.name = name;
            this.faculity = faculity;
            this.gpa = gpa;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Faculity { get => faculity; set => faculity = value; }
        public double Gpa { get => gpa; set => gpa = value; }
    }
}
