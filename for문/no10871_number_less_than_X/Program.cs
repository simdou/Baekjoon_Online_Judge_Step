using System;

namespace no10871_number_less_than_X
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] standard_nums = Console.ReadLine().Split(' ');
            string[] nums = Console.ReadLine().Split(' ');

            for(int i = 0; i < int.Parse(standard_nums[0]); i++)
            {
                if(int.Parse(nums[i]) < int.Parse(standard_nums[1]))
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
