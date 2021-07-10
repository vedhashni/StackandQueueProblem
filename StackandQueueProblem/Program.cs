using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queue program");
            Console.WriteLine("1.Push operation\n 2.PeekandPop operation\n 3.Enqueue Operation\n 4.Dequeue Operation");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            StackOperations stack= new StackOperations();
            QueueOperations queue = new QueueOperations();
            switch (option)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;

                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Pop();
                    stack.Display();
                    break;

                case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;

                case 4:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Dequeue();
                    queue.Display();
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
