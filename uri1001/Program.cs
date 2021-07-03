using System;

namespace uri1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;


            Console.WriteLine("Digite o valor");

            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            b = int.Parse(Console.ReadLine());
            
            x = a + b;
            Console.WriteLine("Resulado da soma dos valores");
            Console.WriteLine("X = " + x);

            //Console.Beep(400, 5000);
            //Console.Beep(1000, 5000);
            //Console.Beep(8000, 5000);
        


        }
    }
}
