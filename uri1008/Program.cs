using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
           int numeroDoFuncionario, horasTrabalhadas;
           double valorHora, salario;

           numeroDoFuncionario = int.Parse(Console.ReadLine());
           horasTrabalhadas = int.Parse(Console.ReadLine());
           valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           salario = horasTrabalhadas * valorHora;

           Console.WriteLine("NUMBER = " + numeroDoFuncionario);
           Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
           
        
        }
    }
}
