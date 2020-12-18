using System;
using System.Text;

namespace PalindromePermutation
{
    class Program
    {

        /*  Given a string, write a function to check if it is a permutation of a palindrome. 
            A palindrome is a word or phrase that is the same forwards and backwards. A permutation
            is a rearrangement of letters.The palindrome does not need to be limited to just dictionary words. 
                Input: Tact Coa
                Output: True (permutations: "taco cat". "atco cta". etc.)     
       */
        static int GetCharNumber(char c)
        {

            int value = char.ToLower(c) - 'a';
            if (value >= 0 && value <= 25)
            {
                return value;
            }
            return -1;
        }
        static int[] GetTable(String s)
        {

            int[] table = new int[26];
            foreach (char c in s)
            {
                int val = GetCharNumber(c);
                if (val != -1)
                {
                    table[val]++;
                }
            }
            return table;
        }
        static bool CheckOdds(int[] table) {
            bool FoundOdd = false;

            foreach (int count in table) {
                if (count % 2 == 1) {
                    if (FoundOdd) {
                        return false;
                    }
                    FoundOdd = true;
                }
            }

            return true;
        }

        static bool IsPermutationOfPalindrome(string phrase)
        {

            int[] table = GetTable(phrase);
            return CheckOdds(table);
        }

        static void Main(string[] args) {

            Console.WriteLine("Please Enter a String, if you'd like to see if it is a Permutation of a Palindrome");
            string s = Console.ReadLine();
            bool b = IsPermutationOfPalindrome(s);
            if (b == true)
            {
                Console.WriteLine("The String {0} is a Permutation of a Palindrome", s);
            }
            else {
                Console.WriteLine("The String {0} is not a Permutation of a Palindrome", s);
            }

        }

    }
}

