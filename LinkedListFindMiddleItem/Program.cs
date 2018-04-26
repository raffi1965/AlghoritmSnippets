using System;

namespace LinkedListFindMiddleItem
{
    partial class Program
    {

        static LinkedList linkedList = new LinkedList();

        static void Main(string[] args)
        {
            LinkedList.Node head = linkedList.Head;

            linkedList.Add(new LinkedList.Node("1"));
            linkedList.Add(new LinkedList.Node("2"));
            linkedList.Add(new LinkedList.Node("3"));
            linkedList.Add(new LinkedList.Node("4"));
            linkedList.Add(new LinkedList.Node("5"));
            linkedList.Add(new LinkedList.Node("6"));
            linkedList.Add(new LinkedList.Node("7"));
            linkedList.Add(new LinkedList.Node("8"));
            linkedList.Add(new LinkedList.Node("9"));
            linkedList.Add(new LinkedList.Node("10"));

            LinkedList.Node current = head;
            LinkedList.Node middle = head;

            int length = 0;

            while (current.Next != null)
            {
                length++;

                if (length % 2 == 0)
                    middle = middle.Next;

                current = current.Next;
            }

            if (length % 2 == 1)
                middle = middle.Next;

            Console.WriteLine($"length of LinkedList {length}");
            Console.WriteLine($"middle element of LinkedList {middle.toString()}");

            Console.ReadKey();
        }

    }
}
