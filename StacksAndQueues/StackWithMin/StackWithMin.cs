using System;
using System.Collections.Generic;
using System.Text;

namespace StackWithMin
{
    public class StackWithMin : Stack<int>
    {
        Stack<int> stackTwo;
        public StackWithMin() {
            stackTwo = new Stack<int>();
        }
        public void Push(int value) {
            if (value <= Min()) {
                stackTwo.Push(value);
            }
            base.Push(value);
        }
        public int Pop() {
            int value = base.Pop();
            if (value == Min()) {
                stackTwo.Pop();
            }
            return value;
        }

        public int Min()
        {
            if (stackTwo.Count == 0)
            {
                return int.MaxValue;
            }
            else {
                return stackTwo.Peek();
            }
        }
    }
}
