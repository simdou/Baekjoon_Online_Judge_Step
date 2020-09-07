using System;

namespace no9498_Test_results
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = Convert.ToInt32(Console.ReadLine());

            if (point >= 90)
            {
                Console.WriteLine("A");
                return;
            }

            if (point >= 80)
            {
                Console.WriteLine("B");
                return;
            }

            if (point >= 70)
            {
                Console.WriteLine("C");
                return;
            }

            if (point >= 60)
            {
                Console.WriteLine("D");
                return;
            }

            Console.WriteLine("F");
        }
    }
}
