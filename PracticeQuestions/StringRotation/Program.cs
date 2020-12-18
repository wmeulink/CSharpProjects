using System;

namespace StringRotation
{
    class Program
    {

        /*
         *  String Rotation: Assume you have a method isSubstring which checks if one word is a substring
            of another. Given two strings, 51 and 52, write code to check if 52 is a rotation of 51 using only one
            call to isSubstring (e.g., "waterbottle" is a rotation of "erbottlewat")
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first String");
            String string1 = Console.ReadLine();
            Console.WriteLine("Please enter the second String");
            String string2 = Console.ReadLine();

            bool result = StringRotate(string1, string2);
            if (result)
            {
                Console.WriteLine("The string {0} can be rotated to be {1}", string1, string2);
            }
            else
            {
                Console.WriteLine("The string {0} can not be rotated to be {1}", string1, string2);
            }
        }

        static bool StringRotate(string s1, string s2) {
            int length = s1.Length;
            bool result;
            String tempString;
            if (length == s2.Length && length > 0)
            {
                tempString = s1 + s1;
                result = tempString.IndexOf(s2) >= 0;
                return result;
            }
            return false;
        }
    }
}
