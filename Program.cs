using System;
using System.Collections.Generic;

namespace Pluralsight_Algorithms_and_Data_Structures_p_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 5 };
            first.Next = middle;

            Node last = new Node { Value = 7 };
            middle.Next = last;

            PrintList(first);

            LinkedList<string> myList = new LinkedList<string>();


            myList.Add("Dan");
            bool contains = myList.Contains("Dan");
            Console.WriteLine(contains);
            Console.WriteLine(myList.Count);
            myList.AddFirst("Henrik");
            Console.WriteLine(myList.Count);
            myList.AddLast("Håkan");
            Console.WriteLine(myList.Count);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }



        }
        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }
    }
}
