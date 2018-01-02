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

            // Writing Code to remove duplicates from LinkedList
            Dictionary<int, int> listSearcher = new Dictionary<int, int>();

            foreach (var num in myLinkedList)
            {
                if (listSearcher.ContainsKey(num))
                    listSearcher[num]++;
                else
                    listSearcher.Add(num, 1);
            }

            var node = myLinkedList.First;
            while (node != null)
            {
                var next = node.Next;
                if (listSearcher[node.Value] > 1)
                {
                    myLinkedList.Remove(node);
                    listSearcher[node.Value]--;
                }
                node = next;
            }

            foreach (var num in myLinkedList)
                Console.WriteLine(num);
        }
    }
}
