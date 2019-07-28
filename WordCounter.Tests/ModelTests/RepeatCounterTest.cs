using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounterConstructorTest_CreatesInstancesOfRepeatCounter_RepeatCounter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral.");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void RepeatCounterTest_IsCharacterDividing_AsLetter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsCharacterDividing('h');
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void RepeatCounterTest_IsCharacterDividing_AsSpace()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsCharacterDividing(' ');
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void RepeatCounterTest_IsCharacterDividing_AsNumber()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsCharacterDividing('8');
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void RepeatCounterTest_IsCharacterDividing_AsPunctuation()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsCharacterDividing('.');
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void RepeatCounterTest_AreCharactersDividingWord_True()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.AreCharactersDividingWord(' ', '.');
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void RepeatCounterTest_AreCharactersDividingWord_False()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.AreCharactersDividingWord(' ', 'h');
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void RepeatCounterTest_IsValidWordInSentence_True()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsValidWordInSentence(" cat ");
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void RepeatCounterTest_IsValidWordInSentence_False()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("", "");
      bool result = newRepeatCounter.IsValidWordInSentence(" catt");
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_NoOccurences()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral.");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_OneOccurence()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cat cafe.");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_MultipleOccurences()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking my cat Molly and my cat Kevin to the cathedral.");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_FrontEdgeCase()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "Cat and I are walking to the cathedral.");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_EndEdgeCase()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral with my cat");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_ToLowerCheck()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "Cat and I are walking to the cathedral.");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void RepeatCounterTest_GetOccurenceCount_Apostrophe()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "The cat's in the craddle");
      int result = newRepeatCounter.GetOccurenceCount();
      Assert.AreEqual(1, result);
    }
  }
}