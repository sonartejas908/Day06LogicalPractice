using System;

namespace CouponCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number of Coupon Codes");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < Num; j++)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[6];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                Console.WriteLine("Code "+j+ " is : "+finalString);
            }
        }
    }
}
