using System;
using System.Collections.Generic;
using System.Text;

namespace KFromLast
{
    class Program
    {

        /*Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list*/

        static void Main(string[] args)
        {
            var source = new LinkedList<String>(new[] { "a", "b", "c", "d", "e" });
            var k = 3;

            var expected = new[] { "c", "d", "e" };

            var result = source.KFromLast(k);

            StringBuilder source_sb = new StringBuilder();
            StringBuilder expected_sb = new StringBuilder();
            foreach (string x in source)
            {
                source_sb.Append(x);
            }
            foreach (string x in expected)
            {
                expected_sb.Append(x);
            }

            Console.WriteLine("Here is the old LinkedList {0}", source_sb.ToString());
            Console.WriteLine("Here are the last {0} items in the LinkedList {1}", k, expected_sb.ToString());
        }

    }


    
}
