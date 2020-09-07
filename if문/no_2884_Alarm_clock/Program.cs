using System;

namespace no_2884_Alarm_clock
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sHM = Console.ReadLine().Split(' ');

            int h = Convert.ToInt32(sHM[0]);
            int m = Convert.ToInt32(sHM[1]);

            m = m - 45;

            if (m < 0)
            {
                m = m + 60;
                h = h - 1;
                if (h < 0)
                {
                    h = h + 24;
                    Console.WriteLine("{0} {1}", h, m);
                }
                else
                {
                    Console.WriteLine("{0} {1}", h, m);
                }
            }
            else
            {
                Console.WriteLine("{0} {1}", h, m);
            }
        }
    }
}
