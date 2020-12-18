using System;
using System.Collections.Generic;

namespace Palindrome_Permutation
{
    class Program
    {
        struct PalindromePermutationResult
        {
            bool IsPermutation;
            LinkedList<string> permutations;
        }


        static PalindromePermutationResult IsPalindromePermutation(char[] input)
        {
            Array.Sort(input);
            char a = input[0];
            int count = 1;
            int unevenCount = 0;
            for(int i = 1; i < input.Length; i++)
            {
                if(a == input[i])
                {
                    count++;
                }
                else
                {
                    if(count % 2 != 0)
                    {
                        unevenCount++;
                    }
                }
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
