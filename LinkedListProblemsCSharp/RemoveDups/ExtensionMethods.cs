using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDups
{
    public static class ExtensionMethods
    {

        public static void RemoveDuplicates<T>(this LinkedList<T> source)
        {
            if (source == null || source.Count == 0) return;

            var hashSet = new HashSet<T>();
            var current = source.First;

            while (current != null)
            {
                var value = current.Value;
                if (hashSet.Contains(value))
                {
                    var next = current.Next;
                    source.Remove(current);
                    current = next;
                    continue;
                }

                hashSet.Add(current.Value);
                current = current.Next;
            }

        }

    }
}
