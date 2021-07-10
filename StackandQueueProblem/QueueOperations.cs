using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueueProblem
{
    /// <summary>
    /// UC3 - Enqueue Operation
    /// </summary>
    class QueueOperations
    {
        Field head;
        public void Enqueue(int item)
        {
            Field new_node = new Field(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Field temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into queue : " + new_node.data);
        }

        public void Display()
        {
            Field temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("No element present in the Queue");
                return;
            }
            Console.WriteLine("The elements are : ");
            while (temp != null)
            {

                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}
