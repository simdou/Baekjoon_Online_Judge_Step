using System;

namespace no4344_above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                float average = 0;
                float result = 0;
                int overCount = 0;
                string[] scores = Console.ReadLine().Split(" ");

                for(int j = 1; j <= int.Parse(scores[0]); j++)
                {
                    average += int.Parse(scores[j]);
                }

                average = (average / int.Parse(scores[0]));

                for (int j = 1; j <= int.Parse(scores[0]); j++)
                {
                    if(float.Parse(scores[j]) > average)
                    {
                        overCount++;
                    }
                }

                result = overCount / float.Parse(scores[0]);

                Console.WriteLine("{0:0.000}" + "%", result * 100);
            }
        }
    }
}
