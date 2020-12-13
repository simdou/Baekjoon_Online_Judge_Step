using System;

namespace no8958_OX_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < count.Length; i++)
            {
                string OX = Console.ReadLine();
                int score = 0;
                int resurt = 0;

                for (int j = 0; j < OX.Length; j++)
                {
                    if (OX[j] == 'O')
                    {
                        score += 1;
                        resurt += score;
                    }
                    else
                    {
                        score = 0;
                    }
                }

                Console.WriteLine(resurt);
            }
        }
    }
}
