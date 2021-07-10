using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueueProblem
{
    class Field
    {
        public int data;
        public Field next;

        public Field(int d)
        {
            data = d;
            next = null;
        }
    }
}
