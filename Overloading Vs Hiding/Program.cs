using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Vs_Hiding
{
    class ParentClass
    {
        public void Print()
        {
            Console.WriteLine("This is Parent class");
        }
    }
    class ChildClass : ParentClass
    {

        public new void Print()
        {
            //base.Print();
            Console.WriteLine("This is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.Print();
            ParentClass pc = new ChildClass();
            pc.Print();
            Star(1, 2);
        }
        public static void Star(int FN, int SN)
        {
            Console.WriteLine(FN + SN);
        }
        public static void Star(params int[] hari)
        {
            Console.WriteLine(hari);
        }
        public static int Star(int FN, int SN, int TN)
        {
            return FN + SN + TN;
        }


    }
}
