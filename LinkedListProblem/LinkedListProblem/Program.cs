using System;
using System.Collections.Generic;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DSA Problem");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(30);
            linkedList.Add(50);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.RemoveFirstNode();
            linkedList.Display();
            linkedList.RemoveLastNode();
            linkedList.Display();

        }
    }
}
