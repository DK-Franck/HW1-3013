using System;
namespace Plc_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number and press enter");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number and press enter");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type one more number and press enter");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Sum of the three numbers is");
            double d = a + b + c;
            ;
            Console.WriteLine(d.ToString("N3"));

            const double e = 7.777;
            double f = e * d;

            Console.WriteLine("The product of " + e + " and the sum of the three numbers is ");
            Console.WriteLine(f);
            Console.ReadKey();




        }
    }
}
