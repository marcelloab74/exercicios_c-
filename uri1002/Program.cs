﻿using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n=3.14159, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
