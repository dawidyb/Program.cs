using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w;
            double h;
            Console.WriteLine("Podaj wagę w kilogramach");
            w = inputValue();
            Console.WriteLine("Podaj wzrost w metrach(maksymalnie 2m)");
            h = inputValue();
            while (h > 2)
            {
                Console.WriteLine("Podaj wzrost w metrach(maksymalnie 2m)");
                h = inputValue();
            }
            double bmi;
            bmi = w / (h * h);
            Console.WriteLine("Twoje bmi wynosi " + bmi);
            Console.ReadKey();
        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}