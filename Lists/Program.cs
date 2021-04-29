using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        public static void Main()
        {
            string userChoice = "";

            Student s1 = new Student()
            {
                id = 101,
                name = "hari",
                place = "Vijayawada"
            };
            Student s2 = new Student()
            {
                id = 102,
                name = "priya",
                place = "Bhimavaram"
            };
            Student s3 = new Student()
            {
                id = 103,
                name = "latha",
                place = "Mallavaram"
            };
            List<Student> liststudents = new List<Student>();
            liststudents.Add(s1);
            liststudents.Add(s2);
            liststudents.Add(s3);

            do
            {
                Console.WriteLine("Enter a Name");
                String strname = Console.ReadLine().ToLower();
                Student finalname = liststudents.Find(name => name.name == strname);

                if (finalname == null)
                {
                    Console.WriteLine("Enter a valid Name");
                }
                else
                {
                    Console.WriteLine("Id ={0} , Place ={1}", finalname.id, finalname.place);
                }
                do
                {
                    Console.WriteLine("Do you want to continue YES or No");
                    userChoice = Console.ReadLine().ToLower();
                } while (userChoice != "no" && userChoice != "yes");

                //foreach (Student stu in liststudents)
                //{

                //Console.WriteLine("Id ={0},Name={1},Place={2}", stu.Id, stu.Name, stu.Place);

                //}
            } while (userChoice == "yes");
        }
    }
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string place { get; set; }
    }

}

