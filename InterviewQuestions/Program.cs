using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = new int[] { 0, 2, 4, 6, 0 };
            LinkedList<int> myLinkedList = new LinkedList<int>();

            foreach (int num in myNums)
                myLinkedList.AddLast(num);

            foreach (int num in myLinkedList)
                Console.WriteLine(num);

            // Writing Code to remove duplicates from LinkedList
            Dictionary<int, int> listSearcher = new Dictionary<int, int>();

            foreach (var num in myLinkedList)
            {
                if (listSearcher.ContainsKey(num))
                    listSearcher[num]++;
                else
                    listSearcher.Add(num, 1);
            }

            foreach (var num in myLinkedList)
            {
                Console.WriteLine(num);
                //if (listSearcher[num] > 1)
                //{
                //    myLinkedList.Remove(num);
                //    listSearcher[num]--;
                //}
            }

            foreach (var num in myLinkedList)
                Console.WriteLine(num);
        }
    }
}
