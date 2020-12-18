using System;

namespace Stack
{
    class Stack<T> : IStack<T>
    {
        private T[] _stack;
        private int _length;

        public Stack()
        {
            _stack = new T[50];
            _length = 0;
        }

        public void Push(T item)
        {
            ResizeArrayIfNecessary();
            _stack[_length] = item;
            _length++;
        }

        public T Peek()
        {
            ThrowIfEmpty();
            return _stack[_length - 1];
        }

        public T Pop()
        {
            ThrowIfEmpty();
            T value = _stack[_length - 1];
            _length--;
            return value;
        }

        private void ThrowIfEmpty()
        {
            if(_length == 0)
            {
                throw new Exception("Stack must have at least one element to perform this operation.");
            }
        }

        private void ResizeArrayIfNecessary()
        {
            //if _length is over half _stack's capacity
            if(_length >= (_stack.Length / 2))
            {
                //double it
                T[] temp = _stack;
                _stack = new T[_stack.Length * 2];

                //transfer all values from temp back to stack
                for(int i = 0; i < temp.Length; i++)
                {
                    _stack[i] = temp[i];
                }
            }

        } 

    }
}