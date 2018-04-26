using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Node<Person>> persons = new LinkedList<Node<Person>>();

            persons.AddLast(new Node<Person>(new Person{ Name = "Tom" }));
            persons.AddLast(new Node<Person>(new Person{ Name = "John" }));
            persons.AddLast(new Node<Person>(new Person{ Name = "Bill" }));
            persons.AddLast(new Node<Person>(new Person{ Name = "Rafik" }));

            ReverseList(persons.First.Value);
        }

        static void ReverseList<T>(Node<T> head)
        {
            Node<T> tail = head;
            Node<T> p = head.Next;
            tail.Next = null;

            while (p != null)
            {
                Node<T> n = p.Next;
                p.Next = tail;
                tail = p;
                p = n;
            }
            head = tail;
        }

    }


    public class Node<T>
    {
        public T Value { get; set; } 
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            Value = val;
            Next = null;
        }
    }

    public class Person : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
