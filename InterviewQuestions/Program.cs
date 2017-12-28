using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //12-25 Sort Scores on InterviewCake

            int[] unsortedScores = new[] { 37, 89, 41, 65, 91, 53 };
            const int HighestPossibleScore = 100;

            int[] sortedScores = SortScores(unsortedScores, HighestPossibleScore);

            foreach (int score in sortedScores)
                Console.WriteLine(score);
        }

        public static int[] SortScores(int[] unsortedScores, int HighestPossibleScore)
        {
            int[] sortedScores = new int[unsortedScores.Length];
            int[] scoreCounts = new int[HighestPossibleScore + 1];

            for (int score = 0; score < unsortedScores.Length; score++)
            {
                scoreCounts[unsortedScores[score] + 1]++;
            }

            int indexForSortedArray = 0;

            for (int score = scoreCounts.Length-1; score >=0; score--)
            {
                int count = scoreCounts[score];

                for (int occurence = 0; occurence < count; occurence++)
                {
                    sortedScores[indexForSortedArray] = score;
                    indexForSortedArray++;
                }
            }
            return sortedScores;
        }

    }
}
