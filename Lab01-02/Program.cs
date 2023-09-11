using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static void Filter(List<Student> students)
        {
            foreach(Student student in students)
            {
                switch ((int)student.AverageScore)
                {
                    case 1:

                    case 2:

                    case 3:

                        student.show();
                        Console.WriteLine("Hoc luc: Kem");
                        break;

                    case 4:

                        student.show();
                        Console.WriteLine("Hoc luc: Yeu");
                        break;

                    case 5:

                    case 6:

                        student.show();
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;

                    case 7:

                        student.show();
                        Console.WriteLine("Hoc luc: Kha");
                        break;

                    case 8:

                        student.show();                       
                        Console.WriteLine("Hoc luc: Gioi");
                        break;

                    case 9:
                    case 10:
                        student.show();
                        Console.WriteLine("Hoc luc: Xuat sac");
                        break;
                    default:
                        Console.WriteLine("Loi Diem !!!");
                        break;
                }
            }
        }
        static void DisplayStudentListByMaxScore(List<Student> students, string check)
        {
            bool condition = false;
            foreach (Student student in students)
            {
                if (student.Faculty == check)
                {
                    condition = true;
                }
            }
            if (condition == true)
            {
                Console.WriteLine(" === Danh sach sinh vien ===");
                SortStudentsByAverageScore(students);
                Console.WriteLine();
                float max = students[students.Count - 1].AverageScore;
                foreach (Student student in students)
                {
                    if (student.AverageScore == max)
                    {
                        Console.WriteLine(" === Danh sach sinh vien diem cao nhat khoa CNTT ===");
                        student.show();
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao thuoc khoa CNTT");
            }
                
        }
        static void DisplayStudentByFacultyAndScore(List<Student> students,string check, int score)
        {
            bool condition = false;
            foreach(Student student in students)
            {
                if(student.Faculty == check)
                {
                    condition = true;
                }
            }
            if(condition == true)
            {
                IEnumerable<string> query =
               from student in students
               where student.Faculty == check && student.AverageScore >= score
               select student.StudentID + student.FullName + student.Faculty + student.AverageScore;
                foreach (var i in query)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao thuoc CNTT");
            }
            
        }
        static void DisplayStudentsByFaculty(List<Student>students, string check)
        {
            bool condition = false;
            foreach (Student student in students)
            {
                if (student.Faculty == check)
                {
                    condition = true;
                }
            }
            if (condition == false)
            {
                Console.WriteLine("Khong co sinh vien nao thuoc CNTT");
               
            }
            else
            {
                IEnumerable<string> query =
              from student in students
              where student.Faculty == check
              select student.StudentID + student.FullName + student.Faculty + student.AverageScore;
                foreach (var i in query)
                {
                    Console.WriteLine(i);
                }
            }
                
        }

        static void DisplayStudentsByAverageScore(List<Student> students, int score)
        {
            IEnumerable<string> query =
               from student in students
               where student.AverageScore > score
               select student.StudentID + student.FullName + student.Faculty + student.AverageScore;
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
        }

        static void SortStudentsByAverageScore(List<Student> students)
        {
            for(int i = 0; i < students.Count -1; i++)
            {
                for(int j = i+1;j<students.Count;j++)
                {
                    if (students[i].AverageScore > students[j].AverageScore)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            DisplayStudentList(students);
        }

        static void AddStudent(List<Student>students)
        {
            Console.WriteLine("=== Nhap thong tin sinh vien ===");
            Student student = new Student();
            student.Input();
            students.Add(student);
            Console.WriteLine("Them sinh vien thanh cong");
        }
        
        static void DisplayStudentList(List<Student> students)
        {
            Console.WriteLine("=== Danh sach chi tiet thong tin sinh vien");
            foreach(Student student in students)
            {
                student.show();
            }
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student hung = new Student("1", "Hung", 10, "CNTT");
            Student huy = new Student("2", "huy", 10, "CNTT");
            Student trinh = new Student("3", "trinh", 4, "KINH TE");
            Student ngan = new Student("4", "ngan", 5, "CNTT");
            Student hoang = new Student("5", "hoang", 1, "CNTT");
            Student dung = new Student("6", "dung", 9, "CNTT");
            Student khai = new Student("7", "khai", 3, "CNTT");
            Student tran = new Student("8", "tran", 6, "CNTT");
            Student quang = new Student("9", "quang", 2, "CNTT");
            Student uyen = new Student("10", "uyen", 7, "CNTT");
            Student chau = new Student("11", "chau", 8, "CNTT");
            list.Add(hung);
            list.Add(huy);
            list.Add(trinh);
            list.Add(ngan);
            list.Add(hoang);
            list.Add(dung);
            list.Add(khai);
            list.Add(tran);
            list.Add(quang);
            list.Add(uyen);
            list.Add(chau);

/*            Student hung = new Student("1", "Hung", 10, "KINH TE");
                        Student huy = new Student("2", "huy", 10, "KINH TE");
                        Student trinh = new Student("3", "trinh", 4, "KINH TE");
                        list.Add(hung);
                        list.Add(huy);
                        list.Add(trinh);*/

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Hien thi danh sach sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Hien thi danh sach sinh vien diem TB > 5");
                Console.WriteLine("5. Hien thi danh sach sinh vien sap xep tang dan diem TB");
                Console.WriteLine("6. Hien thi danh sach sinh vien diem TB > 5 va thuoc khoa CNTT");
                Console.WriteLine("7. Hien thi danh sach sinh viendiem TB lon nhat va thuoc khoa CNTT");
                Console.WriteLine("8. Hien thi danh sach sinh vien va xep loai");
                Console.WriteLine("0. Thoat");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent(list);
                        break;
                    case "2":
                        DisplayStudentList(list);
                        break;
                    case "3":
                        DisplayStudentsByFaculty(list, "CNTT");
                        break;
                    case "4":
                        DisplayStudentsByAverageScore(list, 5);
                        break;
                    case "5":
                        SortStudentsByAverageScore(list);
                        break;
                    case "6":
                        DisplayStudentByFacultyAndScore(list, "CNTT", 5);
                        break;
                    case "7":
                        DisplayStudentListByMaxScore(list, "CNTT");
                        break;
                    case "8":
                        Filter(list);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long thu lai");
                        break;
                }
            }
        }
    }
}
