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

        // List<int> occurences = new List<int>(); 
        
        int occur = 0;
        public bool GetValidWordInSentence(string Sentence, string Word)
        {
          if 
        }
    }

}
