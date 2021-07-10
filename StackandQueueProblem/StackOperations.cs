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
                Console.WriteLine("Value in te stack " + temp.data);
                temp = temp.next;
            }
        }
    }
}
