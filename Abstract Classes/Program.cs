using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class Calculator
    {
        public abstract void calculate(double a);
    }
    class SquareRoot : Calculator
    {
        public override void calculate(double a)
        {
            Console.WriteLine("Square Root is " + Math.Sqrt(a));
        }
    }
    public class SquareOfANumber : Calculator
    {
        public override void calculate(double a)
        {
            Console.WriteLine("Square is :" + (a * a));
        }
    }
    public class CubeOfANumber : Calculator
    {
        public override void calculate(double a)
        {
            Console.WriteLine("Cube is :" + (a * a * a));
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            SquareRoot sr = new SquareRoot();
            SquareOfANumber sn = new SquareOfANumber();
            CubeOfANumber cn = new CubeOfANumber();
            sr.calculate(9);
            sn.calculate(9);
            cn.calculate(9);
        }
    }
}
