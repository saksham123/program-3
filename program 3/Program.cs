using System;

namespace program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;
            Console.WriteLine("Please enter value of x");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value of y");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value of z");
            val3 = Convert.ToInt32(Console.ReadLine());

            if (val1 > val2 && val1 > val3)
            {
                Console.WriteLine("The greatest number is" +val1);
            }
            else if (val2 > val1 && val2 > val3)

                Console.WriteLine("The greatest number is" +val2);

            else
            {
                Console.WriteLine("The greatest number is" +val3);
            }
            Console.WriteLine("press enter to exit");
            Console.ReadKey(true);
        }
    }
}
