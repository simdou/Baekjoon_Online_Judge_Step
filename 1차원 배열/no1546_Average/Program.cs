using System;

namespace no1546_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            float maxScore = 0;
            int scoreCount = Convert.ToInt32(Console.ReadLine());
            String[] scores = Console.ReadLine().Split(" ");
            float fixScoreSum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if(maxScore < float.Parse(scores[i]))
                {
                    maxScore = float.Parse(scores[i]);
                }
            }

            for (int i = 0; i < scores.Length; i++)
            {
                fixScoreSum += (float.Parse(scores[i]) / maxScore) * 100;
            }

            Console.WriteLine(fixScoreSum / scoreCount);
        }
    }
}
