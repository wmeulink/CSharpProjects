using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(String[] args)
        {
            int stackSize = 20;
            FixedMultiStack stack = new FixedMultiStack(stackSize);
            stack.push(1, 43);
            stack.push(2, 44);
            stack.push(3, 45);
            

            Console.WriteLine(stack.getSize(1));

        }
    }
}
