using System;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string Word { get; set; }
    private string Sentence { get; set; }

    // Create new instance of RepeatCounter - Converts case to lower and adds space on both sides in case the word appears are the very beginning or end of the sentance.
    public RepeatCounter(string userWord, string userSentance)
    {
      Word = userWord.ToLower();
      Sentence = $" {userSentance.ToLower()} ";
    }

    // Method analizes character in front of and behind the word and invalidates the instance of word if it is a letter or digit.
    public bool IsCharacterDividing(char character)
    {
      return !Char.IsLetterOrDigit(character);
    }

    // Method takes beginning and ending character and sends it to IsCharacterDividing.
    public bool AreCharactersDividingWord(char previousCharacter, char followingCharacter)
    {
      return IsCharacterDividing(previousCharacter) && IsCharacterDividing(followingCharacter);
    }

    // Method takes padded word and isolates the beginning/previousCharacter and end/followingCharacter before sending it to AreCharactersDividingWord
    public bool IsValidWordInSentence(string paddedWord)
    {
      char previousCharacter = paddedWord[0];
      char followingCharacter = paddedWord[paddedWord.Length - 1];

      return AreCharactersDividingWord(previousCharacter, followingCharacter);
    }

    // Method takes in user word and sentence and created a padded version of word before sendng it to IsValidWordInSentence
    public int GetOccurenceCount()
    {
      int wordLength = Word.Length + 2;

      int count = 0;
      int position = 0;
      // Padded word creation to get the character in front of and behind an instance of word.
      while (position < Sentence.Length - 1)
      {
        int startIndex = Sentence.IndexOf(Word, position) - 1;
        int endIndex = startIndex + wordLength;

        // Break to avoid an infinate loop.
        if (startIndex < 0)
        {
          break;
        }

        string paddedWord = Sentence.Substring(startIndex, wordLength);

        // If statement to count up the number of times a valid instance of word appears in the sentance.
        if (IsValidWordInSentence(paddedWord))
        {
          count++;
        }

        position = endIndex;
      }

      return count;
    }
  }
}
