using System;
using System.Collections.Generic;
using System.Text;

namespace SumLists
{
    public static class ExtensionMethods
    {
        public static LinkedList<int> SumLists(this LinkedList<int> num1, LinkedList<int> num2)
        {
            var node1 = num1.Last;
            var node2 = num2.Last;

            var result = new LinkedList<int>();

            var carry = 0;

            while (true)
            {
                if (node1 == null && node2 == null && carry == 0)
                {
                    break;
                }
                var val1 = node1?.Value ?? 0;
                var val2 = node2?.Value ?? 0;

                var sum = val1 + val2 + carry;
                carry = sum / 10;
                result.AddFirst(sum % 10);

                node1 = node1?.Previous;
                node2 = node2?.Previous;


            }
            return result;
        }
    }
}
