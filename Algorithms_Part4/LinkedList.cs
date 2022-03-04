using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public void AddNode(T data)
        {
            Node<T> new_node = new Node<T>(data);
            Node<T> curr_node = Head;

            if (Head == null)
            {
                Head = new_node;
                Head.next = null;
            }
            else
            {
                while (curr_node.next != null)
                {
                    curr_node = curr_node.next;
                }
                curr_node.next = new_node;
            }
        }

        public void Print()
        {
            if (Head != null)
                Head.Print();
        }

        public void AddLastNodeinLoop(int pos)
        {
            Node<T> lastNode = Head;
            Node<T> nthNode = Head;
            int ctr = 1;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            while (ctr != pos)
            {
                nthNode = nthNode.next;
                ctr++;
            }

            lastNode.next = nthNode;

        }
    }

    public class Node<T>
    {
        public T data;
        public Node<T> next, bottom;

        public Node(T d)
        {
            data = d;
            next = null;
            bottom = null;
        }

        public void Print()
        {
            Node<T> curr_node = this;
            while (curr_node != null)
            {
                Console.Write(curr_node.data + " ");
                curr_node = curr_node.next;
            }
            Console.Write("\n");
        }
    }
}
