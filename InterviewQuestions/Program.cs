using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = new int[] { 0, 2, 4, 6 };
            LinkedList<int> myLinkedList = new LinkedList<int>();

            foreach (int num in myNums)
                myLinkedList.AddLast(num);
        }


    }
}
