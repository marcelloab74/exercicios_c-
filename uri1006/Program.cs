using System;
using System.Globalization;

namespace uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // multiplica a nota pelo peso e depois somar as notas e dividir pela soma dos pesos.
            media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10;
            // media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
