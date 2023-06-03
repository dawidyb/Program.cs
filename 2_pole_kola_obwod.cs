
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Podaj pole koła");
            double P = inputValue();
            double O;
            r = Math.Sqrt(P / Math.PI);
            O = r * Math.PI * 2;
            Console.WriteLine("Obwód koła to");
            Console.WriteLine(O);
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