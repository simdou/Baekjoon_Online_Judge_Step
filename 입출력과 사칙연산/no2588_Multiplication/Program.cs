using System;

namespace no2588_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            String snum2 = num2.ToString();

            for (int i = 0; i < snum2.Length; i++)
            {
                num[i] = Convert.ToInt32(snum2.Substring(i, 1));
            }

            Console.WriteLine(num1 * num[2]);
            Console.WriteLine(num1 * num[1]);
            Console.WriteLine(num1 * num[0]);
            Console.WriteLine(num1 * num2);
        }
    }
}
