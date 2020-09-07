using System;
using System.Text;

namespace no11021_A_plus_B_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            StringBuilder results = new StringBuilder();

            for(int i = 1; i <= count; i++)
            {
                String[] nums = Console.ReadLine().Split(' ');
                results.Append("Case #" + i + ": " + (Int32.Parse(nums[0]) + Int32.Parse(nums[1])) + "\n");
            }

            Console.Write(results);
        }
    }
}
