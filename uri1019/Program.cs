using System;
using System.Globalization;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, hora, minutos, segundos, resto;

            Console.WriteLine("Digite o tempo em segundos.");
            N = int.Parse(Console.ReadLine());
            
            // operador (% mod)
            hora = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = N % 60;
            
            Console.WriteLine("Seu resultado é:");
            Console.WriteLine(hora + ":" + minutos + ":" + segundos);
            
            // 556 0:9:16
            //140153  38:55:53



        }
    }
}
