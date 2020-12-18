using System;
using System.Collections.Generic;

namespace PremutationCheck
{


    //Given two strings, write a method to decide if one is a permutation of the other
    //Tip: Ask if whitespace is significant
    //Tip: Ask if this is case sensitive God / dog example
    //Note that strings of different lengths are not premutations of each other
    //We can put them in order first or just start comparing

    class Program
    {

        static void Main(string[] args)
        {
            PrintResult();

        }

        static string PrintResult() {

            Console.WriteLine("Please enter a String");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please enter a second String");
            string string2 = Console.ReadLine();
            string perm1 = MySort(string1);
            string perm2 = MySort(string2);
            Boolean result = Permutation(perm1, perm2);
            Console.WriteLine("The final result is {0}", result);
            string MyString = Console.ReadLine();
            return MyString;
        }
        static string MySort(string s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);

            return new string(content);
        }

        static Boolean Permutation(String s, String t) {
            if (s.Length != t.Length)
            {
                return false;
            }
            return MySort(s).Equals(MySort(t));
        }


    }
}
