using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, velocidade;
            double litros;
            
            hora = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            litros = (double) hora * velocidade / 12;
                        
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
