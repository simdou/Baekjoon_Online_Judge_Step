using System;

namespace no2753_leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());

            if (y % 400 == 0)
            {
                Console.WriteLine(1);
                return;
            }
            else if (y % 4 == 0)
            { 
                if (y % 100 != 0)
                {
                    Console.WriteLine(1);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}
