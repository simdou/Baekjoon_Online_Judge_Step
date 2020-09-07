using System;

namespace no2739_multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
