﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite numero A :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero B :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero C :");
            c = int.Parse(Console.ReadLine());
            M(a, b, c);

        }
        public static void M(int a, int b, int c)
        {

            if (a < b && a < c)
            {
                Console.WriteLine("Menor numero Digitado: " + a);

            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Menor numero Digitado: " + b);

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("Menor numero Digitado: " + c);

            }

        }
    }
}
