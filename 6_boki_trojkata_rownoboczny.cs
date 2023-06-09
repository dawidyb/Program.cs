using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wprowadź pierwszy bok");
            double a = inputValue();
            Console.WriteLine("wprowadź drugi bok");
            double b = inputValue();
            Console.WriteLine("wprowadź trzeci bok");
            double c = inputValue();
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Powstanie trójkąt równoboczny");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nie powstanie trójkąt równoboczny");
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
