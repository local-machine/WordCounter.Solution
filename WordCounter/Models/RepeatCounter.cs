using System;


namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Word { get; set; }
        public string String { get; set; }

        public RepeatCounter(string userWord, string userString)
        {
            Word = userWord;
            String = userString;
        }
    }

}
