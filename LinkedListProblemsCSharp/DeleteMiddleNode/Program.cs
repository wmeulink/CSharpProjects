using System;
using System.Collections.Generic;
using System.Text;


namespace DeleteMiddleNode
{

    /*  
     *  Implement an algorithm to delete a node in the middle (Le., any node but
        the first and last node, not necessarily the exact middle) of a singly linked list, given only access to
        that node.
        EXAMPLE
        Input: the node c from the linked list a - >b- >c - >d - >e- >f
        Result: nothing is returned, but the new linked list looks like a->b->d->e->f
    */
    class Program
    {
        static void Main(string[] args)
        {
            var source = new LinkedList<string>(new[] { "a", "b", "c", "b", "a" });
            var oldSource = source;
            
            StringBuilder sb = new StringBuilder();
            StringBuilder sbOld = new StringBuilder();
            foreach (string s in oldSource)
            {
                sbOld.Append(s);
            }
            source.DeleteMiddleNode<String>();
            foreach (string s in source)
            {
                sb.Append(s);
            }
            

            Console.WriteLine("Here is your old list: {0}", sbOld.ToString());
            Console.WriteLine("Here is your new list: {0}", sb.ToString());
        }
    }
}
