﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into linked list", node.data);

        }

        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                Node temp = this.head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

        public Node RemoveFirstNode()
        {
            Console.WriteLine("After removing first node ");
            if (this.head == null)
            {
                return null;
            }
            this.head = head.next;
            return this.head;
        }

        public Node RemoveLastNode()
        {
            Console.WriteLine("After removing last node");
            if (this.head == null)
            {
                return null;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return head;
        }
    }
}
