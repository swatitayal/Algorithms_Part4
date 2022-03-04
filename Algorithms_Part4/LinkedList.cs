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

        public void AddNodeToBottom(Node<T> head, T data)
        {
            Node<T> new_node = new Node<T>(data);
            Node<T> curr = head;

            if(head == null)
            {
                head = new_node;
                head.bottom = null;
            }

            while(curr.bottom!= null)
            {
                curr = curr.bottom;
            }
            curr.bottom = new_node;
        }

        
        public void Print()
        {
            if (Head != null)
                Head.Print();
        }

        public void print2DList()
        {
            if (Head != null)
                Head.print2DList();
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

        public Node<int> AddNodeAsc(Node<int> head, int data)
        {
            Node<int> new_node = new Node<int>(data);
            Node<int> curr = head;
            Node<int> prev = null;

            if (head == null)
            {
                head = new_node;
                head.next = null;
            }
            else if (head.next == null)
            {
                if (head.data < data)
                {
                    head.next = new_node;
                }
                else
                {
                    new_node.next = head;
                    head = new_node;
                }
            }
            else
            {
                while (curr != null)
                {
                    if (curr.data < data)
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                    else break;
                }
                new_node.next = curr;
                prev.next = new_node;
            }
            return head;
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

        public void print2DList()
        {
            Node<T> curr = this;

            Console.Write("\n    Head");
            while (curr != null)
            {
                Console.Write("\n\t" + curr.data);
                Node<T> down = curr.bottom;
                while (down != null)
                {
                    Console.Write(" -- " + down.data);
                    down = down.bottom;
                }
                curr = curr.next;
                Console.Write("\n\t|");
            }
            Console.Write("\n    Null\n");
        }

    }
}
