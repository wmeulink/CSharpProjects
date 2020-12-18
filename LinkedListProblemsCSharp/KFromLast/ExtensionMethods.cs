using System;
using System.Collections.Generic;
using System.Text;

namespace KFromLast
{
   public static class ExtensionMethods
    {
        public static IEnumerable<T> KFromLast<T>(this LinkedList<T> source, int k)
        {
            if (source == null || source.Count == 0) yield break;

            int length = source.Count;
            var currentNode = source.First;
            for (int i = 0; i < length - k; i++)
            {
                currentNode = currentNode.Next;
            }
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }



    }
}
