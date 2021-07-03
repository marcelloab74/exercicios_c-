using System;
using System.Globalization;

namespace uriteste
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, total;

            Console.WriteLine("digite o valor.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor.");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("o resultado é:");
            total = (double) a * b / c;

            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
