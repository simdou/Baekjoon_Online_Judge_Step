using System;

namespace no10818_Min_and_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            string[] nums = new string[int.Parse(Console.ReadLine())];
            nums = Console.ReadLine().Split(" ");

            min = int.Parse(nums[0]);
            max = int.Parse(nums[0]);

            for(int i = 1; i < nums.Length; i++)
            {
                min = min > int.Parse(nums[i]) ? int.Parse(nums[i]) : min;
                max = max < int.Parse(nums[i]) ? int.Parse(nums[i]) : max;
            }

            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
