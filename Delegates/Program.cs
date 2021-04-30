using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student()
            {
                id = 101,
                name = "Pranaya",
                gender = "Male",
                attendence = 50,
               
            };
            Student stu2 = new Student()
            {
                id = 102,
                name = "Haripriya",
                gender = "Female",
                attendence = 70,

            };
            Student stu3 = new Student()
            {
                id = 103,
                name = "Latha",
                gender = "Female",
                attendence = 80,

            };
            List<Student> stu = new List<Student>();
            stu.Add(stu1);
            stu.Add(stu2);
            stu.Add(stu3);
            EligibleToNextSemester eligibleTopromote = new EligibleToNextSemester(Program.Promote);
            Student.PromoteStudent(stu, eligibleTopromote);
        }
        public static bool Promote(Student student)
        {
            if (student.attendence > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public delegate bool EligibleToNextSemester(Student EmployeeToPromotion);
   
       
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int attendence { get; set; }
        public static void PromoteStudent(List<Student> stu, EligibleToNextSemester IsStudentEligible)
        {
            foreach (Student student in stu)
            {
                if (IsStudentEligible(student))
                {
                    Console.WriteLine("Student {0} Promoted to Next Semester", student.name);
                }
            }
        }
    }
}
