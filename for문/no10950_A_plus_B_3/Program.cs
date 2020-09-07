using System;

namespace no10950_A_plus_B_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[5];
            String[] sNums;

            for (int i = 0; i < count; i++)
            {
                sNums = Console.ReadLine().Split(' ');
                Console.WriteLine(Convert.ToInt32(sNums[0]) + Convert.ToInt32(sNums[1]));
            }
        }
    }
}
