using System;

namespace no10952_A_B_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] nums = Console.ReadLine().Split(' ');

                if(Convert.ToInt32(nums[0]) == 0 && Convert.ToInt32(nums[1]) == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]));
                }
            }
        }
    }
}
