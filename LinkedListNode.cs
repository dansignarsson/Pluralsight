using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight_Algorithms_and_Data_Structures_p_1
{
    public class LinkedListNode<T>
    {
        //Constructs a new node with the specified value
        public LinkedListNode(T value)
        {
            Value = value;
        }

        //The node value
        public T Value { get; set; }

        //The next node in the linked list(null if last node)
        public LinkedListNode<T> Next { get; set; }
    }
}
