using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            Console.WriteLine("Pushed 5");
            stack.Push(5);
            Console.WriteLine("Pushed 6");
            stack.Push(6);
            Console.WriteLine("Pushed 7");
            stack.Push(7);
            Console.WriteLine("Pop: {0}", stack.Pop());
            Console.WriteLine("Peek: {0}", stack.Peek());
            Console.WriteLine("Pop: {0}", stack.Pop());
            Console.WriteLine("Pop: {0}", stack.Pop());
        }
    }
}
