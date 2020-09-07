using System;
using System.Text;

namespace no2742_reverse_N_enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            StringBuilder numbers = new StringBuilder();

            for (int i = count; i >= 1; i--)
            {
                numbers.Append(i + "\n");
            }

            Console.Write(numbers);
        }
    }
}
