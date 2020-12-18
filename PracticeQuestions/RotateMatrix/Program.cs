using System;

namespace RotateMatrix
{
    class Program
    {
        public static object AssortedMethods { get; private set; }

        static void Main(string[] args)
        {
            const int size = 3;

            int[][] matrix = new int[4][];

            RotateMatrix(matrix, size);
            
        }

        static void RotateMatrix(int[][] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n -1 - layer;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    var top = matrix[first][i];

                    matrix[first][i] = matrix[last - offset][first];
                    matrix[last - offset][first] = matrix[last][last - offset];
                    matrix[last][last - offset] = matrix[i][last];
                    matrix[i][last] = top;

                }

            }

        }


    }
}
