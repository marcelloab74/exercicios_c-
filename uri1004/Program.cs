using System;

namespace uri1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, produto;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            produto = a * b;
            
            Console.WriteLine("PROD = " + produto);
            
        }
    }
}
