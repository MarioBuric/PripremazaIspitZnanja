﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmariopripremazaispit_1.zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            float x;
            Console.WriteLine("Unesi broj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi broj b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi broj c:");
            c = Convert.ToInt32(Console.ReadLine());
            x = (a + b + c) / 3;

            Console.WriteLine("Prosjek triju brojeva je " + x);
            Console.ReadKey();





        }
    }
}
