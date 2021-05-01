using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class StudentsInformation
    {
        private int stuId, stuAge;
        private string stuName, stuAddress;
        public int StudentId
        {
            set
            {
                stuId = value;
            }
            get
            {
                return stuId;
            }
        }
        public int StudentAge
        {
            set
            {
                stuAge = value;
            }
            get
            {
                return stuAge;
            }
        }
        public string StudentName
        {
            set
            {
                stuName = value;
            }
            get
            {
                return stuName;
            }
        }
        public string StudentAddress
        {
            set
            {
                stuAddress = value;
            }
            get
            {
                return stuAddress;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentsInformation si = new StudentsInformation();
            si.StudentId = 101;
            si.StudentName = "Haripriya";
            si.StudentAge = 23;
            si.StudentAddress = "Bhimavaram";
            Console.WriteLine("Student details are:");
            Console.WriteLine("Student Id:" + si.StudentId);
            Console.WriteLine("Student Name:" + si.StudentName);
            Console.WriteLine("Student Age:" + si.StudentAge);
            Console.WriteLine("student Address:" + si.StudentAddress);
            Console.ReadKey();
        }
    }
}
