using System;

namespace ReverseANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int rem=0; 
            int rev=0;
            while (Num != 0)
            {
                rem = Num % 10;  //121
                rev = rev * 10 + rem;
                Num /= 10;
            }
            Console.WriteLine("Reverse Number is"+" "+ rev );
        }
    }
}
