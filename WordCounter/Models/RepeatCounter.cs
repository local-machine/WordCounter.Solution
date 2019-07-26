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

        int occur = 0;

        // Doesn't work for multiple on words like 'cathedral'
        
        // public int GetOccurenceCount()
        // {
        //     if (IsValidWordInSentence() == true)
        //     {
        //         int occur = Sentence.Split(Word).Length - 1;
        //         return occur;
        //     }
        //     else
        //     {
        //         int occur = 0;
        //         return occur;
        //     }
        // }
        public int GetOccurenceCount()
        {
            if (IsValidWordInSentence() == true)
            {
                char[] delimiterChars = { ' ', ',', '.', ':', ';', '!', '?' };
                string[] wordsFromSentence = Sentence.Split(delimiterChars);

                foreach (var Word in wordsFromSentence)
                {
                    int occur = Sentence.Split(Word).Length - 1;
                }
            }
            else
            {
                int occur = 0;
                return occur;
            }
        }
    }
}
