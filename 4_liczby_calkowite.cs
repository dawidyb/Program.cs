
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = (int)inputValue();
            int b = (int)inputValue();
            int c = (int)inputValue();
            int d = (int)inputValue();
            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
                Console.ReadKey();
            }
            else if (b == d)
            {
                int x = a + c;
                Console.WriteLine("Twój licznik to: " + x);
                Console.WriteLine("Twój mianownik to: " + d);
                Console.ReadKey();
            }
            else if (b != d)
            {
                int y = b * d;
                a = a * d;
                c = c * b;
                int x = a + c;
                Console.WriteLine("Twój licznik to: " + x);
                Console.WriteLine("Twój mianownik to: " + y);
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
