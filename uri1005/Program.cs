using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // multiplica a nota pelo peso e depois somar as notas e dividir pela soma dos pesos.
            media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;
            // media = nota1 + nota2 / 2;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));


        }
    }
}
