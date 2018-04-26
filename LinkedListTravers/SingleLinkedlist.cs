using System;

namespace LinkedListTravers
{
    partial class Program
    {
        private class SingleLinkedlist
        {
            private int data;
            private SingleLinkedlist next;

            public SingleLinkedlist()
            {
                data = 0;
                next = null;
            }

            public SingleLinkedlist(int value)
            {
                data = value;
                next = null;
            }

            public SingleLinkedlist InsertNext(int value)
            {
                SingleLinkedlist node = new SingleLinkedlist(value);
                if (this.next == null)
                {
                    node.next = null;
                    this.next = node;
                }
                else
                {
                    SingleLinkedlist temp = this.next;
                    node.next = temp;
                    this.next = node;
                }
                return node;
            }

            public int DeleteNext()
            {
                if (next == null)
                    return 0;

                SingleLinkedlist node = this.next;
                this.next = this.next.next;
                node = null;

                return 1;
            }

            public void Traverse(SingleLinkedlist node)
            {
                if (node == null)
                    node = this;

                Console.WriteLine("Traversing Singly Linked List :");

                while (node != null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            }
        }
    }
}