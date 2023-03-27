using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DSA Problem");
            Console.WriteLine("Enter the Options to perform: ");
            Console.WriteLine("1:Custom Linked List\n2:custom Stack");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.Add(30);
                    linkedList.Add(50);
                    linkedList.Add(70);
                    linkedList.Display();
                    linkedList.RemoveFirstNode();
                    linkedList.Display();
                    linkedList.RemoveLastNode();
                    linkedList.Display();
                    break;
                 case 2:
                    CustomStack customStack = new CustomStack();
                    customStack.Push(70);
                    customStack.Push(30);
                    customStack.Push(56);
                   // customStack.IsEmpty();
                    customStack.Pop();
                    customStack.Peek();
                    customStack.Display();
                    break;

            }
    
        }
   
    }
}
