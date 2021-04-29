using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[3];
            stu[0] = new Student
            {
                Name = "Hari",
                Gender = Genders.Female
            };
            stu[1] = new Student
            {
                Name = "Vamshi",
                Gender = Genders.Male
            };
            stu[2] = new Student
            {
                Name = "Trans",
                Gender = Genders.Transgender
            };
            foreach (Student s in stu)
            {
                Console.WriteLine("name = {0},Gender = {1}", s.Name, GetGender(s.Gender));
            }

        }
        public static String GetGender(Genders gender)
        {
            switch (gender)
            {
                case Genders.Female:
                    return "Female";
                case Genders.Male:
                    return "Male";
                case Genders.Transgender:
                    return "Transgender";
                default:
                    return "Unknown";
            }
        }

    }

    public class Student
    {
        public Genders Gender { get; set; }
        public string Name { get; set; }
    }
    public enum Genders
    {
        Female,
        Male,
        Transgender
    }

}
  