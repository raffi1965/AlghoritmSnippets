using System;

namespace LinkedListFindMiddleItem
{
    public class LinkedList
    {
        public Node Head { get; set; }
        private Node tail;

        public LinkedList()
        {
            Head = new Node("head");
            tail = Head;
        }

        public void Add(Node node)
        {
            tail.Next = node;
            tail = node;
        }

        public class Node
        {
            public Node Next { get; set; }
            public String Data { get; set; }

            public Node(String data)
            {
                Data = data;
            }

            public String toString()
            {
                return Data;
            }
        }

    }
}
