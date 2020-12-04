using System;

namespace no2577_Value_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[10];
            string result = Convert.ToString(int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()));

            for(int i = 0; i < 10; i++)
            {
                String[] tempS = result.Split(i.ToString());
                counts[i] = tempS.Length - 1;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(counts[i]);
            }
        }
    }
}
