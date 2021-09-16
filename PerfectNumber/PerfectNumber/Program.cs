using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Your Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int Add = 1;
            for (int i = 2; i <= Num / 2; i++) //28
            {
                if (Num % i == 0)
                {
                    Add = Add + i;
                }
            }
                if (Num == Add)
                {
                    Console.WriteLine(Num+" "+ "is a Perfect Number");
                }
                else
                    Console.WriteLine(Num + " " + "is Not a Perfect Number");
            
        }
    }
}
