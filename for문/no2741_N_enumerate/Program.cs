using System;
using System.Text;

namespace no2741_N_enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            StringBuilder numbers = new StringBuilder();

            for (int i = 1; i <= count; i++)
            {
                numbers.Append(i + "\n");
            }

            Console.Write(numbers);
        }
    }
}
