using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Student
    {
        private string id;
        private string name;
        private string gender;
        private float gpa;
        private string faculity;

        public Student(string id, string name, string gender, float gpa, string faculity)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Gpa = gpa;
            this.Faculity = faculity;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        public string Faculity { get => faculity; set => faculity = value; }
    }

}
