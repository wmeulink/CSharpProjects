using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteMiddleNode
{
    public static class ExtensionMethods
    {
        public static void DeleteMiddleNode<T>(this LinkedList<T> source)
        {
            if (source == null || source.Count == 0) return;

            if (source.Count % 2 == 0) return;

            var middle = source.Count / 2;
            var currentNode = source.First;
            for (int i = 0; i < middle; i++)
            {
                currentNode = currentNode.Next;
            }

            source.Remove(currentNode);

        }

    }
}
