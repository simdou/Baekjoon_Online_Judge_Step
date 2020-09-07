using System;

namespace no1008_A_divided_by_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[2];

            String num_s = Console.ReadLine();
            string[] num_a = num_s.Split(' ');

            for (int i = 0; i < num_a.Length; i++)
            {
                num[i] = Convert.ToDouble(num_a[i]);
            }

            Console.WriteLine(num[0] / num[1]);
        }
    }
}
