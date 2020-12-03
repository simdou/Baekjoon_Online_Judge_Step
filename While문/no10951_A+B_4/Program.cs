using System;

namespace no10951_A_B_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string nums = Console.ReadLine();
                string[] temp;

                if (nums == null)
                {
                    break;
                }
                else
                {
                    temp = nums.Split(' ');
                    Console.WriteLine(Convert.ToInt32(temp[0]) + Convert.ToInt32(temp[1]));
                }
            }
        }
    }
}
