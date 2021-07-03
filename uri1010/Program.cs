using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, quantidade1, quantidade2;
            double valorUnitario1, valorUnitario2, aPagar;

            String[] ver = Console.ReadLine().Split(" ");

            codigo1 = int.Parse(ver[0]);
            quantidade1 = int.Parse(ver[1]);
            valorUnitario1 = double.Parse(ver[2], CultureInfo.InvariantCulture);

            ver = Console.ReadLine().Split(" ");

            codigo2 = int.Parse(ver[0]);
            quantidade2 = int.Parse(ver[1]);
            valorUnitario2 = Double.Parse(ver[2], CultureInfo.InvariantCulture);
        
            aPagar = (valorUnitario1 * quantidade1) + (valorUnitario2 * quantidade2);

            Console.WriteLine("VALOR A PAGAR: R$ " + aPagar.ToString("F2", CultureInfo.InvariantCulture));






            

            

        






        }
    }
}
