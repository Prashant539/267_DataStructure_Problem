using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class CustomStack
    {
        public Node top;
        public CustomStack()
        {
            this.top = null;

        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top != null)
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to Stack", value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
    }
}
