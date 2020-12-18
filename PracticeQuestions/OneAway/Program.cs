using System;

namespace OneAway
{
    class Program
    {

        /*  
         *  
         *  One Away: There are three types of edits that can be performed on strings: insert a character,
            remove a character, or replace a character. Given two strings, write a function to check if they are
            one edit (or zero edits) away
       */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first string");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please enter in your second string");
            string string2 = Console.ReadLine();

            bool result = OneAway(string1, string2);
            if (result)
            {
                Console.WriteLine("{0} and {1} are one edit away from being the same string", string1, string2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not one edit away from being the same string", string1, string2);
            }
        }
        static bool OneEditReplace(string s1, string s2) {

            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i])
                {
                    if (foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;
                }
                
            }

            return true;
        }
        static bool OneEditInsert(string s1, string s2)
        {

            int index1 = 0;
            int index2 = 0;
            while (index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

       static bool OneAway(string first, string second)
       {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length) {
                return OneEditInsert(second, first);
            }

            return false;
        }

    }
}
