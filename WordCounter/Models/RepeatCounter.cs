using System;


namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        public RepeatCounter(string userWord, string userSentance)
        {
            Word = userWord;
            Sentence = userSentance;
        }
        
        public bool IsValidWordInSentence()
        {
          if (Sentence.Contains(" " + Word + " "))
          {
            return true;
          }
          else if (Sentence.Contains(" " + Word + "."))
          {
            return true;
          }
          else if (Sentence.Contains(" " + Word + "!"))
          {
            return true;
          }
          else if (Sentence.Contains(" " + Word + "?"))
          {
            return true;
          }
          else if (Sentence.Contains(" " + Word + ";"))
          {
            return true;
          }
          else if (Sentence.Contains(" " + Word + ","))
          {
            return true;
          }
          else
          {
            return false;
          }
        }

        // int occur = 0;
        // public int GetOccurencesCount()
        // {
        //   while ((occur < Sentence.Length) && (occur = ))
        // }

    }

}
