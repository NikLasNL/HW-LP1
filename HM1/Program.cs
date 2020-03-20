using System;

namespace ConsoleApplication1
{
    class Program
    { 
        static void Main(string[] args)
        {
            /* a  = (e ^ |x - y| + x/2) /
                    |e-y|(1 + sin ^ 2 z/ x + y)
            */
            double a,b;
            double e = Math.E;
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            a = (Math.Pow(e, Math.Abs(x - y)) + x / 2) / Math.Abs(e - y) * (1 + (Math.Pow(Math.Sin(z), 2))/ x + y);
            Console.WriteLine(a);
            b = Math.Pow(Math.PI, Math.Pow(-y, x)) + Math.Sin(x / 10);
            Console.WriteLine(b);

        }
    }
}