using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //11-25 Sort Scores on InterviewCake

            int[] unsortedScores = new[] { 37, 89, 41, 65, 91, 53 };
            const int HighestPossibleScore = 100;


        }

        public static int[] SortScores(int[] unsortedScores, int HighestPossibleScore)
        {
            int[] sortedScores[] = new int[unsortedScores.Length];
            int[] scoreCounts[] = new int[HighestPossibleScore];

            for (int score =0; score<unsortedScores.Length; score++)
            {
                scoreCounts[sortedScores[score]]++;
            }
        }
            
    }
}
