using System;

namespace LinkedListTravers
{
    partial class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedlist node1 = new SingleLinkedlist(100);
            SingleLinkedlist node2 = node1.InsertNext(200);
            SingleLinkedlist node3 = node2.InsertNext(300);
            SingleLinkedlist node4 = node3.InsertNext(400);
            SingleLinkedlist node5 = node4.InsertNext(500);

            node1.Traverse(null);

            Console.WriteLine("Deleting from Linked List...");

            node3.DeleteNext();

            node2.Traverse(null);

            Console.ReadLine();
        }
    }
}
