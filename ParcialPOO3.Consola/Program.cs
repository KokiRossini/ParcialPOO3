using ParcialPOO3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO3.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius c = 5;
            Kelvin k = 278.15f;
            Fahrenheit f = 41;

            if (c == f)
            {
                Console.WriteLine($"{c.Magnitud} Celcius es igual a {f.Magnitud} Fahrenheit");
            }
            else
            {
                Console.WriteLine("son distintos");
            }
            if (c == k)
            {
                Console.WriteLine($"{c.Magnitud} Celcius es igual a {k.Magnitud} kelvin");
            }
            else
            {
                Console.WriteLine("son distintos");
            }

            Celcius c2 = 10f;
            Fahrenheit f2 = 50f;
            Kelvin k2 = 283.15f;
            if (f2 == c2)
            {
                Console.WriteLine($"{f2.Magnitud} Fahrenheit es igual a {c2.Magnitud} Celcius");
            }
            else
            {
                Console.WriteLine("son distintos");
            }
            if (f2 == k2)
            {
                Console.WriteLine($"{f2.Magnitud} Fahrenheit es igual a {k2.Magnitud} kelvin");
            }
            else
            {
                Console.WriteLine("son distintos");
            }

            Celcius c3 = 10f;
            Fahrenheit f3 = 50f;
            Kelvin k3 = 283.15f;
            if (k3 == c3)
            {
                Console.WriteLine($"{k3.Magnitud} Kelvin es igual a {c3.Magnitud} Celcius");
            }
            else
            {
                Console.WriteLine("son distintos");
            }
            if (k3 == f3)
            {
                Console.WriteLine($"{k3.Magnitud} Kelvin es igual a {f3.Magnitud} Fahrenheit");
            }
            else
            {
                Console.WriteLine("son distintos");
            }




            Console.ReadKey();
        }
    }
}
