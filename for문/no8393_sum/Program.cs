using System;

namespace no8393_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                total = total + i;
            }

            Console.WriteLine(total);
        }
    }
}
