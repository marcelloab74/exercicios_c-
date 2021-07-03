using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
           int idadeDias, resto, ano, mes, dia;

           Console.WriteLine("Digite o valor em dias");

           idadeDias = int.Parse(Console.ReadLine());

           ano = idadeDias / 365;
           resto = idadeDias % 365;
           mes = resto / 30;
           dia = resto % 30;

           Console.WriteLine(ano + " ano(s) ");
           Console.WriteLine(mes + " mês(se) ");
           Console.WriteLine(dia + " dia(s) ");
        }
    }
}
