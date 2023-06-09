using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wprowadź pierwszą liczbę");
            double a = inputValue();
            Console.WriteLine("wprowadź drugą liczbę");
            double b = inputValue();
            if (a == b)
            {
                Console.WriteLine("Liczby są takie same");
                Console.ReadKey();
            }
            else if (a > b)
            {
                Console.WriteLine("wynik: " + a);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("wynik: " + b);
                Console.ReadKey();
            }

        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}
