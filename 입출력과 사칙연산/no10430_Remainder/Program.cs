using System;

namespace no10430_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            String num_s = Console.ReadLine();
            string[] num_a = num_s.Split(' ');

            for (int i = 0; i < num_a.Length; i++)
            {
                num[i] = Convert.ToInt32(num_a[i]);
            }

            Console.WriteLine((num[0] + num[1]) % num[2]);
            Console.WriteLine(((num[0] % num[2]) + (num[1] % num[2])) % num[2]);
            Console.WriteLine((num[0] * num[1]) % num[2]);
            Console.WriteLine(((num[0] % num[2]) * (num[1] % num[2])) % num[2]);
        }
    }
}
