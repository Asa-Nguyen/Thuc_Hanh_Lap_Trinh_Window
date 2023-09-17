// C# program to print Hello World!
using System;
using System.Collections.Generic;

// namespace declaration
namespace Lab01_03
{
    class Program
    {
        static void Filter(List<Student> students)
        {
            foreach (Student student in students)
            {
                switch ((int)student.AverageScore)
                {
                    case 1:

                    case 2:

                    case 3:

                        student.Output();
                        Console.WriteLine("Hoc luc: Kem");
                        break;

                    case 4:

                        student.Output();
                        Console.WriteLine("Hoc luc: Yeu");
                        break;

                    case 5:

                    case 6:

                        student.Output();
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;

                    case 7:

                        student.Output();
                        Console.WriteLine("Hoc luc: Kha");
                        break;

                    case 8:

                        student.Output();
                        Console.WriteLine("Hoc luc: Gioi");
                        break;

                    case 9:
                    case 10:
                        student.Output();
                        Console.WriteLine("Hoc luc: Xuat sac");
                        break;
                    default:
                        Console.WriteLine("Loi Diem !!!");
                        break;
                }
            }
        }
        static void DisplayListTeacherAddress(List<Teacher> teacherList, string check)
        {
            bool condition = false;
            foreach (Teacher teacher in teacherList)
            {
                if (teacher.Address == check)
                {
                    condition = true;
                }
            }
            if (condition == false)
            {
                Console.WriteLine("No one from District 9");

            }
            else
            {
                IEnumerable<string> query =
              from teacher in teacherList
              where teacher.Address == check
              select teacher.Id + teacher.Name + teacher.Salary + teacher.Address;
                foreach (var i in query)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void SortStudentsByAverageScore(List<Student> students)
        {
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].AverageScore > students[j].AverageScore)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
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
                        student.Output();
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao thuoc khoa CNTT");
            }

        }
        static void DisplayStudentsByFaculty(List<Student> students, string check)
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
                Console.WriteLine("No one from IT");

            }
            else
            {
                IEnumerable<string> query =
              from student in students
              where student.Faculty == check
              select student.Id + student.Name + student.Faculty + student.AverageScore;
                foreach (var i in query)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Main(string[] args)
        {
            bool checkError = true;
            while (checkError)
            {
                Console.WriteLine("---------MENU----------");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Display teacher list");
                Console.WriteLine("4. Display student list");
                Console.WriteLine("5. Count List");
                Console.WriteLine("6. Display IT student");
                Console.WriteLine("7. Display teacher with address district 9");
                Console.WriteLine("8. Display List Student has highest GPA and their faculity is IT");
                Console.WriteLine("9. Student rank");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter menu");
                int menu = int.Parse(Console.ReadLine());
                List<Student> studentList = new List<Student>();
                List<Teacher> teacherList = new List<Teacher>();
                Student hung = new Student("1", "Hung", 10, "IT");
                Student huy = new Student("2", "huy", 10, "IT");
                Student trinh = new Student("3", "trinh", 4, "KINH TE");
                Student ngan = new Student("4", "ngan", 5, "IT");
                Student hoang = new Student("5", "hoang", 1, "IT");
                Student dung = new Student("6", "dung", 9, "IT");
                Student khai = new Student("7", "khai", 3, "IT");
                Student tran = new Student("8", "tran", 6, "IT");
                Student quang = new Student("9", "quang", 2, "IT");
                Student uyen = new Student("10", "uyen", 7, "IT");
                Student chau = new Student("11", "chau", 8, "IT");
                studentList.Add(hung);
                studentList.Add(huy);
                studentList.Add(trinh);
                studentList.Add(ngan);
                studentList.Add(hoang);
                studentList.Add(dung);
                studentList.Add(khai);
                studentList.Add(tran);
                studentList.Add(quang);
                studentList.Add(uyen);
                studentList.Add(chau);

                Teacher han = new Teacher("12", "Han", 3000000, "Quan 10");
                Teacher kha = new Teacher("13", "Kha", 2000000, "Quan 10");
                Teacher khang = new Teacher("12", "Khang", 300000000, "Quan Thu Duc");
                Teacher quynh = new Teacher("13", "quynh", 40000000, "Quan Thu Duc");
                teacherList.Add(han);
                teacherList.Add(kha);
                teacherList.Add(khang);
                teacherList.Add(quynh);

                switch (menu)
                {
                    case 1:
                        Student studentAdd = new Student();
                        studentAdd.Input();
                        studentList.Add(studentAdd);
                        break;
                    case 2:
                        Teacher teacherAdd = new Teacher();
                        teacherAdd.Input();
                        teacherList.Add(teacherAdd);
                        break;
                    case 3:
                        foreach (Student student in studentList)
                        {
                            student.Output();
                        }
                        break;
                    case 4:
                        foreach(Teacher teacher in teacherList)
                        {
                            teacher.Output();
                        }
                        break;
                    case 5:
                        Console.WriteLine("1. Student list");
                        Console.WriteLine("2. Teacher list");
                        Console.WriteLine("Choose list");
                        int choose = int.Parse(Console.ReadLine());
                        int countStudent = 0;
                        int countTeacher = 0;
                        if (choose == 1)
                        {
                            foreach (Student student in studentList)
                            {
                                countStudent++;
                            }
                            Console.WriteLine("Number of student: " + countStudent);
                        }
                        if(choose == 2)
                        {
                            foreach (Teacher teacher in teacherList)
                            {
                                countTeacher++;
                            }
                            Console.WriteLine("Number of student: " + countTeacher);
                        }
                        break;
                    case 6:
                        DisplayStudentsByFaculty(studentList, "IT");
                        break;
                    case 7:
                        DisplayListTeacherAddress(teacherList, "Quan Thu Duc");
                        break;
                    case 8:
                        DisplayStudentListByMaxScore(studentList, "IT");
                        break;
                    case 9:
                        Filter(studentList);
                        break;
                    default:
                        checkError = false;
                        break;

                }
            }
            

        }
    }
}