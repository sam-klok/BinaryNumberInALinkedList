using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryNumberInALinkedList
{
    // public class SinglyLinkedListNode<T>: LinkedList<T>
    public class SinglyLinkedList: LinkedList<int>
    {
        public void Add(int item)
        {
            ((ICollection<int>)this).Add(item);
        }
    }



}
