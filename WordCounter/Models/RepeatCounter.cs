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

        // public int IsWordInSentence()
        // {
        //     char[] delimiterChars = { ' ', ',', '.', ':', ';', '!', '?' };
        //     string[] wordsFromSentence = Sentence.Split(delimiterChars);

        //     if (Sentence.Contains(Word))
        //     {
        //       foreach (var Word in Sentence)
        //       {
        //           int occurenceCount = Sentence.Split(Word).Length -1;
        //       }
        //     }
        // }
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

        public int GetOccurenceCount()
        {
            if (IsValidWordInSentence() == true)
            {
                int occur = Sentence.Split(Word).Length - 1;
                return occur;
            }
            else
            {
                int occur = 0;
                return occur;
            }
        }

    }

}
