using System;


namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string Word { get; set; }
        private string Sentence { get; set; }

        public RepeatCounter(string userWord, string userSentance)
        {
            Word = userWord.ToLower();
            Sentence = $" {userSentance.ToLower()} ";
        }

        public bool IsCharacterDividing(char character)
        {
          return !Char.IsLetterOrDigit(character);
        }

        public bool AreCharactersDividingWord(char previousCharacter, char followingCharacter)
        {
          return IsCharacterDividing(previousCharacter) && IsCharacterDividing(followingCharacter);
        }

        public bool IsValidWordInSentence(string paddedWord)
        {
          char previousCharacter = paddedWord[0];
          char followingCharacter = paddedWord[paddedWord.Length -1];

          return AreCharactersDividingWord(previousCharacter, followingCharacter);
        }

        public int GetOccurenceCount()
        {
          int wordLength = Word.Length + 2;

          int count = 0;
          int position = 0;

          while(position < Sentence.Length - 1)
          {
            int startIndex = Sentence.IndexOf(Word, position) - 1;
            int endIndex = startIndex + wordLength;

            if(startIndex < 0)
            {
              break;  
            }

            string paddedWord = Sentence.Substring(startIndex, wordLength);
            
            if (IsValidWordInSentence(paddedWord))
            {
              count ++;
            }

            position = endIndex;
          }

          return count;
        }
    }
}
