using System;

namespace no3052_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int count = 0;
            bool flag = true;

            for(int i = 0; i < 10; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine()) % 42;
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    flag = true;

                    if (i == j)
                        continue;

                    if (nums[i] == nums[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    count += 1;
            }

            Console.WriteLine(count);
        }
    }
}
