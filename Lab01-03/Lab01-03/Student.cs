using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Student : Person
    {
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        private float averageScore;
        private string faculty;
        public Student() { }

        public Student(string id, string name, float averageScore, string faculty) : base(name,id)
        {
            this.AverageScore = averageScore;
            this.Faculty = faculty;
        }

        public override void Input()
        {
            Console.Write("Enter ID: ");
            Id = Console.ReadLine();
            Console.WriteLine("Enter student name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa: ");
            Faculty = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine("ID:{0} Name: {1} Faculity: {2} GPA: {3}",  Id, Name, this.faculty, this.averageScore);
        }
    }
}
