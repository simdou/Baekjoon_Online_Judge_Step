using System;

namespace no1330_Compare_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nums = Console.ReadLine().Split(' ');

            if (Convert.ToInt32(nums[0]) > Convert.ToInt32(nums[1]))
            {
                Console.WriteLine(">");
            }
            else if(Convert.ToInt32(nums[0]) < Convert.ToInt32(nums[1]))
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
