using System;

namespace no2562_Max_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;
            int count = 0;

            for(int i = 1; i <= 9; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if(maxValue > temp)
                {
                    continue;
                }
                else
                {
                    maxValue = temp;
                    count = i;
                }
            }

            Console.WriteLine("{0}\n{1}", maxValue, count);
        }
    }
}
