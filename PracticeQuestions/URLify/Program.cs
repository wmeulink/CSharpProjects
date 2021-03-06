﻿using System;

namespace URLify
{
    class Program
    {
        //Write a method to replace all spaces in a string with '%20: You may assume that the string
        //has sufficient space at the end to hold the additional characters, and that you are given the "true"
        //length of the string. (Note: If implementing in Java, please use a character array so that you can
        //perform this operation in place

        static char[] URLify(char[] input, int trueLength)
        {
            int index = input.Length - 1;
            for (int i = trueLength - 1; -1 < i; i--)
            {
                if (input[i] != ' ')
                {
                    input[index--] = input[i];
                }
                else
                {
                    input[index--] = '0';
                    input[index--] = '2';
                    input[index--] = '%';
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();
            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            //one of the space counts new characters is accounted for in input.Length
            char[] inputArray = new char[input.Length + (spaceCount * 2)];
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i];
            }
            char[] output = URLify(inputArray, input.Length);
            string outputString = new string(output);
            Console.WriteLine("URLified: {0}", outputString);


        }
    }
}
