using System;
using System.Text;

namespace StringCompression
{
    class Program
    { 
        /*Implement a method to perform basic string compression using the counts
        of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the
        "compressed"string would not become smaller than the original string, your method should return
        the original string. You can assume the string has only uppercase and lowercase letters (a - z).*/
    
        static void Main(string[] args)
        {
            String original = "aaabbbbeeeedd";
            String compressedString = CompressBetter(original);
            Console.WriteLine("Your original String is \"{0}\"", original);
            Console.WriteLine("Your compressed String is \"{0}\"", compressedString);
        }
        static int GetLength(String s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            char last = s[0];
            int size = 0;
            int count = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < s.Length; i++)
            {
                if (last != s[i])
                {
                    count++;
                }
                else
                {
                    last = s[i];
                    size += 1 + string.Format("{0}", count).Length;
                    count = 1;
                }
            }

            size += 1 + string.Format("0", count).Length;

            return size;
        }

        static String CompressBetter(String s) {

            int size = GetLength(s);
            if (size >= s.Length)
            {
                return s;
            }

            StringBuilder sb = new StringBuilder();
            int count = 1;
            char last = s[0];

            for (int i = 1; i < s.Length; i++) {

                if (last == s[i])
                {
                    count++;
                }
                else
                {
                    sb.Append(last);
                    sb.Append(count);
                    last = s[i];
                    count = 1;
                }
            }

            sb.Append(last);
            sb.Append(count);

            return sb.ToString();
        }



    }
}
