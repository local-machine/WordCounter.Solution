using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Find the word in the sentence!");
            System.Console.WriteLine("Please enter a word: ");
            string Word = Console.ReadLine();
            System.Console.WriteLine("Please enter a the sentence you'd like to search for your word: ");
            string Sentence = Console.ReadLine();
        }
    }
}