using System;
using System.IO;
using System.Threading;

namespace AppleStocks
{
    class Program
    {
        static int[] GenerateStockPrices()
        {
            try
            {
                DateTime openingTime = DateTime.Parse("9:30 AM");
                Console.WriteLine("Lets generate some stock prices!");
                Console.Write("closing time: ");
                DateTime closingTime = DateTime.Parse(Console.ReadLine());

                if(closingTime < openingTime)
                {
                    throw new Exception("Closing time has to be after opening time.");
                }

                Console.Write("Smallest stock price in US Dollars: $");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Largest stock price in US Dollars: $");
                int max = int.Parse(Console.ReadLine());

                if(max < min)
                {
                    throw new Exception("Smallest stock price must be smaller than largest stock price ");
                }

                if(min < 0 || max < 0)
                {
                    throw new Exception("A stock price cannot be less than zero.");
                }

                Console.WriteLine();
                int size = (int) closingTime.Subtract(openingTime).TotalMinutes;

                int[] stockPrices = new int[size];
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    stockPrices[i] = random.Next(min, max);
                }

                return stockPrices;
            }
            catch
            {
                Console.WriteLine("\nStock price generation failed.");
                Console.WriteLine("You probably think this program is about you.");
                Console.WriteLine("Don't you...\n");
                throw;
            }

        }

        static void ExecuteChoice(char choice, ref int[] stockPrices)
        {

            //for calculation time
            DateTime then = DateTime.Now;

            IMaxProfitGenerator maxProfitGenerator;
            switch (choice)
            {
                case 'A':
                case 'a':
                    maxProfitGenerator = new NaiveGetMaxProfitGenerator();
                    break;

                case 'B':
                case 'b':
                    maxProfitGenerator = new BetterGetMaxProfitGenerator();
                    break;

                case 'C':
                case 'c':
                    stockPrices = GenerateStockPrices();
                    return;

                default:
                    return;
            }
            int maxProfit = maxProfitGenerator.GetMaxProfit(stockPrices);
            Console.WriteLine("Calculation Time: {0}", DateTime.Now - then);
            Console.WriteLine("Max profit: ${0}", maxProfit);
            Console.WriteLine("\npress any key to go to main menu.");
            Console.ReadKey();
        }

        static void WriteMenuOptions()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("* Welcome dudes and dudettes *");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine("A) Naive implementation.");
            Console.WriteLine("B) Better implementation");
            Console.WriteLine("C) Generate new stock prices array.");
            Console.WriteLine("");
            Console.WriteLine("\nPress q to quit.");
            Console.WriteLine("What do you want to do ? ");
        }

        static void WriteProblemStatementAndDeveloperNotes(bool typeItOut = false)
        {
            if(typeItOut)
            {
                const int milliSecondsDragRate = 60;
                foreach (var line in File.ReadAllLines("notes.txt"))
                {
                    foreach (var word in line.Split(" "))
                    {
                        foreach (var key in word.ToCharArray())
                        {
                            Console.Write(key);
                            Thread.Sleep(milliSecondsDragRate);
                        }
                        Console.Write(" ");
                        Thread.Sleep(milliSecondsDragRate);
                    }
                    Console.WriteLine("");
                    Thread.Sleep(milliSecondsDragRate);
                }
            }

            else
            {
                Console.WriteLine(File.ReadAllText("notes.txt"));
            }

            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            char choice;
            WriteProblemStatementAndDeveloperNotes(true);
            int[] stockPrices = GenerateStockPrices();
            do
            {
                Console.Clear();
                WriteProblemStatementAndDeveloperNotes();
                WriteMenuOptions();

                choice = Console.ReadKey().KeyChar;
                Console.Clear();

                ExecuteChoice(choice, ref stockPrices);

            }
            while (choice != 'q');
           
        }

    }
}
