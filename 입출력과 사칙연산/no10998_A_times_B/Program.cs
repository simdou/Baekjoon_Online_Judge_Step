using System;

namespace no10998_A_times_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[2];

            String num_s = Console.ReadLine();
            string[] num_a = num_s.Split(' ');

            for (int i = 0; i < num_a.Length; i++)
            {
                num[i] = Convert.ToInt32(num_a[i]);
            }

            Console.WriteLine(num[0] * num[1]);
        }
    }
}
