using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
           
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

                for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j <10; j++)
                {
                    if (j != i && a[j] == a[i])
                    {
                        Console.WriteLine("numeros repetidos  " + a[j]);
                    }
                }
            }

            
        }
    }
}