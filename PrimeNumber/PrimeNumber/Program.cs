using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int B = Num / 2;
            int Flag = 1;
            for (int i = 2; i <= B; i++) //20
            {
              if(Num % i == 0)
                {
                    Flag = 0;
                }
              
            }

            if (Flag == 0)
            {
                Console.WriteLine(Num +" "+  "Is not a Prime Number");
            }
            else
            {
                Console.WriteLine(Num +" "+  "Is a Prime Number");
            }
        }
    }
}
