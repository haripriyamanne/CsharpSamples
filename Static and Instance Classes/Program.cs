using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Classes
{
    class Circle
    {
        static float pi = 3.141F;
        int radius;

        static Circle()
        {
            Console.WriteLine("This is Static constructor");
        }
        public Circle(int Radius)
        {
            Console.WriteLine("This is Instance constructor");
            this.radius = Radius;
        }

        public float CircleRadius()
        {
            return Circle.pi * this.radius * this.radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area = c1.CircleRadius();
            Console.WriteLine(area);

            Circle c2 = new Circle(8);
            float area1 = c2.CircleRadius();
            Console.WriteLine(area1);
        }
    }
}
