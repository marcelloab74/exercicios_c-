using System;

namespace uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
           int km, minutos;

           km = int.Parse(Console.ReadLine());

           minutos = km * 2;

           Console.WriteLine(minutos + " minutos");
        }
    }
}
