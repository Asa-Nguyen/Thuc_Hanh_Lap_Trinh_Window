using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public Student() { }

        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa: ");
            Faculty = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine("MSSV:{0} Ho Ten: {1} Khoa: {2} Diem trung binh: {3}",this.StudentID,this.fullName,this.faculty,this.averageScore);
        }

    }
}
