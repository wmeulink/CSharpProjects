using System;

namespace SwapTwoVariables
{
    class Program
    {
        //This will not work because a and b are passed by value
        //This means they get a copy of the values of a and b
        
        static void BadSwap(int input1, int input2)
        {
            int temp = input1;
            input1 = input2;
            input2 = temp;
        }
        

        //This will work because we are passing by reference
        static void Swap(ref int input1, ref int input2)
        {
            int temp = input1;
            input1 = input2;
            input2 = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for int b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Swapping a and b.");
            BadSwap(a, b);
            Console.WriteLine("int a: {0}", a);
            Console.WriteLine("int b: {0}", b);
        }
    }
}
