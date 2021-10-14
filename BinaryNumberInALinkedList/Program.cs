using System;
using System.Collections.Generic;

namespace BinaryNumberInALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var singlyLinkedList = new SinglyLinkedList() { 0, 0, 1, 1, 0, 1, 0 };  // 26
            Print(singlyLinkedList);
            Console.WriteLine(GetNumber(singlyLinkedList.First));
        }

        public static long GetNumber(LinkedListNode<int> binary)
        {
            // below is not working, like for normal List
            // string s = binary.List.ToArray 

            // so let's iterate
            string s = "";
            while (binary != null)
            {
                s = s + binary.Value.ToString();
                binary = binary.Next;
            }

            long i = Convert.ToInt64(s, 2); // convert binary to long int 
            return i;
        }

        static void Print(SinglyLinkedList l)
        {
            LinkedListNode<int> node = l.First;

            while (node != null)
            {
                Console.Write(node.Value);
                node = node.Next;
            }
        }
    }
}
