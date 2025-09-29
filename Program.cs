using System;
using System.Collections.Generic;

namespace Rodrigues.WordCount.App15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Word Count Program ===");
            Console.WriteLine("Enter a line of text, and I’ll count the frequency of each word:");
            string input = Console.ReadLine();

            
            CleanWords cleaner = new CleanWords();
            string[] words = cleaner.ProcessInput(input);

           
            CountWords counter = new CountWords();
            Dictionary<string, int> results = counter.Count(words);

            
            Console.WriteLine("\n=== Word Frequencies ===");
            foreach (var pair in results)
            {
                Console.WriteLine($"{pair.Key} → {pair.Value}");
            }

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
