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
            Console.WriteLine("1.Push operation");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            StackOperations stack= new StackOperations();
            switch (option)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
