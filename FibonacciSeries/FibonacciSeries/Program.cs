﻿using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, Num,i;
            Console.WriteLine("Please Enter Number");
            Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (i = 2; i <= Num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}