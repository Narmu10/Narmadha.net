using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationProgram
{
    /* ImplementationProgram */

    public class NarmadhaList<T>
    {
        internal class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }


        }
        private Node head;
        private Node tail;
        private int count;
        private object root;
 
        public NarmadhaList()
        {
            head = null;
            tail = null;
            count = 0;
            root = new object();
        }

        public int Count
        {
            get
            {
                lock (root)
                {
                    return count;
                }
            }
            set
            {
                lock (root)
                {
                    Node current = head;
                    int currentIndex = 0;

                    while (current != null && currentIndex < currentIndex)
                    {
                        current = current.Next;
                        currentIndex++;
                    }
                }
            }
        }

        internal class SynchronizedNarmadhaList
        {
            private NarmadhaList<T> list;
            private object root;

        }
        public NarmadhaList(NarmadhaList<T> list)
        {
            list = list;
            root = list.root;
        }
        public void Add(T data)
        {
            Node newNode = new Node(data);
            lock (root)
            {
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
                count++;
            }
        }
        public void push(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            newNode.Previous = null;

            if (head != null)
            {
                head.Previous = newNode;
            }
            head = newNode;

            count++;
        }
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + "");
                current = current.Next;
            }
            Console.WriteLine();
        }
        /*void DeleteNode(Node del)
        {
            if (head == null || del == null)
            {
                return;
            }
            if (head == del)
            {
                head = del.Next;
            }

            if (del.Next != null)
            {
                del.Next.Previous = del.Previous;
            }
            if (del.Previous != null)
            {
                del.Previous.Next = del.Next;
            }
            return;
        }*/
        public void DisplayList()
        {

            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void Remove(T data)
        {
                Node current = head;
                if (current == null)
                {
                    Console.WriteLine("Node with key not found.");
                    return;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }

                Console.WriteLine("Node with key removed successfully.");
            }

        }

        
        }
    






