using System;

namespace no1110_Addition_cycle
{
    class Program
    { 
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string originNum = num;
            int cycleCount = 1;

            while (true)
            {

                if(num.Length == 1)
                {
                    num = num + "0";
                    originNum = num;
                }

                if(Convert.ToString(int.Parse(num.Substring(0, 1)) + int.Parse(num.Substring(1, 1))).Length == 2)
                {
                    num = num.Substring(1, 1) + (Convert.ToString(int.Parse(num.Substring(0, 1)) + int.Parse(num.Substring(1, 1))).Substring(1, 1));
                }
                else
                {
                    num = num.Substring(1, 1) + (Convert.ToString(int.Parse(num.Substring(0, 1)) + int.Parse(num.Substring(1, 1))));
                }

                if (num == originNum)
                {
                    Console.WriteLine(cycleCount);
                    break;
                }

                cycleCount = cycleCount + 1;
            }
        }
    }
}
