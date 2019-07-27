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
            string userWord = Console.ReadLine();
            System.Console.WriteLine("Please enter the sentence you'd like to search: ");
            string userSentence = Console.ReadLine();
            RepeatCounter newRepeatCounter = new RepeatCounter(userWord, userSentence);
            int result = newRepeatCounter.GetOccurenceCount();
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine($"The word {userWord} appeared {result} time(s) in the sentence: '{userSentence}'");

        }
    }
}