using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        public static void Main()
        {
            StudentsInformation s1 = new StudentsInformation()
            {
                id = 101,
                name = "Hari",
                place = "Vijayawada"
            };
            StudentsInformation s2 = new StudentsInformation()
            {
                id = 102,
                name = "Priya",
                place = "Bhimavaram"
            };
            StudentsInformation s3 = new StudentsInformation()
            {
                id = 103,
                name = "Latha",
                place = "Mallavaram"
            };
            Dictionary<int, StudentsInformation> dicStudentsInformation = new Dictionary<int, StudentsInformation>();
            dicStudentsInformation.Add(s1.id, s1);
            dicStudentsInformation.Add(s2.id, s2);
            dicStudentsInformation.Add(s3.id, s3);

            //Student s102 = dicStudentsInformation[102];
            //Console.WriteLine("id ={0},name={1},place={2}", s102.id, s102.name, s102.place);
            foreach (StudentsInformation stu in dicStudentsInformation.Values)
            {
                // Console.WriteLine(key);
                //    Console.WriteLine("Key is:{0}", StudentkeyValuePair.Key);
                //    Student stu = StudentkeyValuePair.Value;
                Console.WriteLine("id ={0},name={1},place={2}", stu.id, stu.name, stu.place);
                //    Console.WriteLine("==============================================");
            }

        }
    }
    public class StudentsInformation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string place { get; set; }
    }



}

