using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            double c, f=0;
            Console.WriteLine("temperatura em grau Celsius: ");
            c = double.Parse(Console.ReadLine());
            F(c, f);
            
        }
        public static void F(double c, double f )
        {

            f = (9 * c + 160) / 5;
            Console.WriteLine("a conversao de grau Celsius em grau Fahrenheit é : " + f);

        }

    }
}
