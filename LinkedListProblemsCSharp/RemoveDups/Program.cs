using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var source = new LinkedList<string>(new[] { "a", "b", "c", "d","a", "a", "c", "e" });
            var expected = new LinkedList<string>(new[] { "a", "b", "c", "d", "e" });

            source.RemoveDuplicates();
            StringBuilder source_sb = new StringBuilder();
            StringBuilder expected_sb = new StringBuilder();
            foreach (string x in source) {
                source_sb.Append(x);
            }
            foreach (string x in expected)
            {
                expected_sb.Append(x);
            }
            
            Console.WriteLine("Here is the new LinkedList {0}", source_sb.ToString());
            Console.WriteLine("Here is what was expected {0}", expected_sb.ToString());
        }
    }

    

}

