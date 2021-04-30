using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IArea
    {
        void area(double a, double b);
    }
    class Rectangle : IArea
    {
        public void area(double a, double b)
        {
            double areaOfRectangle;
            areaOfRectangle = a * b;
            Console.WriteLine("The area of Rectangle is :" + areaOfRectangle);
        }
    }
    class Circle : IArea
    {
        static double PI = 3.14;
        public void area(double a, double b)
        {
            double areaOfCircle;
            areaOfCircle = PI * a * a;
            Console.WriteLine("The area of Circle is :" + areaOfCircle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IArea ia = new Rectangle();
            ia.area(5, 6);
            // ia =new Circle(); // can use same instance object
            //ia.area(8,2);
           IArea ib = new Circle(); // can create another instance object
            ib.area(7, 0);
           
        }
    }
}
