using System;
using System.Collections.Generic;

namespace SumLists
{
    class Program
    {

        /*
         Sum Lists: You have two numbers represented by a linked list, where each node contains a single
        digit. The digits are stored in reverse order, such that the 1's digit is at the head of the list. Write a
        function that adds the two numbers and returns the sum as a linked list.
            EXAMPLE
                Input: (7-> 1 -> 6) + (5 -> 9 -> 2) .Thatis,617 + 295.
                Output: 2 - > 1 - > 9.That is, 912.
            FOLLOW UP   
                Suppose the digits are stored in forward order. Repeat the above problem.
                Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).Thatis,617 + 295.
                Output: 9 - > 1 - > 2.That is, 912
             
             */
        static void Main(string[] args)
        {
            var number1 = new LinkedList<int>(new[] { 7, 9, 2, 3 });
            var number2 = new LinkedList<int>(new[] { 2, 1, 9, 8 });

            var expected = new LinkedList<int>(new[] { 1, 0, 1, 2, 1 });

            var result = number1.SumLists(number2);
            foreach (int i in result)
            {
                Console.WriteLine("The first number is {0}", i);
                
            }
            foreach (int i in expected)
            {
                Console.WriteLine("The first number in the expected result is {0}", i);
            }

        }

    }
}
