using System;

namespace no11720_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int count = Convert.ToInt32(Console.ReadLine());
            char[] nums = Console.ReadLine().ToCharArray();

            for(int i = 0; i < count; i++)
            {
                result += Convert.ToInt32(Convert.ToString(nums[i]));
            }

            Console.WriteLine(result);
        }
    }
}
