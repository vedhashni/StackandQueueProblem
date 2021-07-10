using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueueProblem
{
    class Stack
    {
        public int data;
        public Stack next;

        public Stack(int d)
        {
            data = d;
            next = null;
        }
    }
}
