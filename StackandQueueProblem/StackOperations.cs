using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueueProblem
{
    /// <summary>
    /// UC1 - Push operation
    /// </summary>
    class StackOperations
    {
        //Creating a node top
        public Stack top;

        // Function is used to push data into stack
        public void Push(int newData)
        {
            Stack newnode = new Stack(newData);
            if (this.top != null)
            {
                newnode.next = this.top;
            }
            this.top = newnode;
            Console.WriteLine("New Node is {0}", newnode.data);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Console.WriteLine("The element after peeking is : " + this.top.data);
        }
        //Pop Mthod-Removes the top most element
        public void Pop()
        {
            while (true)
            {
                if (this.top != null)
                {
                    Peek();
                    this.top = this.top.next;
                }
                else
                {
                    Console.WriteLine("No elements present in the stack");
                    return;
                }
            }
        }
        //Checking the any underflow or overflow occurs
        /*public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }*/
        // Function is used to display stack
        public void Display()
        {
            Stack temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in stack " + temp.data);
                temp = temp.next;
            }
        }
    }
}
