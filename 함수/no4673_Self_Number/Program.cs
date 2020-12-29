using System;

namespace no4673_Self_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] nums = new bool[10001];
            int num = 0;

            while (num <= 10000)
            {
                try
                {
                    nums[Df(num.ToString())] = true;
                    num++;
                }
                catch (Exception)
                {
                    num++;
                    continue;
                }
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int Df(string num)
        {
            int result = int.Parse(num);

            for(int i = 0; i < num.Length; i++)
            {
                result = result + int.Parse(num[i].ToString());
            }

            return result;
        }
    }
}
