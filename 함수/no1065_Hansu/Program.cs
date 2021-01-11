using System;

namespace no1065_Hansu
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if (Run(i))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static bool Run(int num)
        {
            bool result = true;
            string nums = num.ToString();
            uint gap = 0;

            if(num > 10)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if(i == 0)
                    {
                        gap = (Convert.ToUInt32(nums[i])) - (Convert.ToUInt32(nums[i + 1]));
                    }
                    else
                    {
                        if (gap != (Convert.ToUInt32(nums[i])) - (Convert.ToUInt32(nums[i + 1])))
                            result = false;
                            break;
                    }
                }
            }

            return result;
        }
    }
}
