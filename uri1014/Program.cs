using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
           int distancia;
           double consumo, media;

           distancia = int.Parse(Console.ReadLine());
           consumo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // fazer um "castim". Que é colocar esse (double) para ter a certeza que o resultado será em double.
           media = (double)distancia / consumo;

           Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
