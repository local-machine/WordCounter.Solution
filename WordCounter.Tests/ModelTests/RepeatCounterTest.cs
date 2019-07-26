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
        public void RepeatCounterTest_IsValidWordInSentence_True()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cat cafe.");
            bool result = newRepeatCounter.IsValidWordInSentence();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void RepeatCounterTest_IsValidWordInSentence_False()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral.");
            bool result = newRepeatCounter.IsValidWordInSentence();
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void RepeatCounterTest_GetOccurenceCount_NoOccurences()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral.");
            int result = newRepeatCounter.GetOccurenceCount();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void RepeatCounterTest_GetOccurenceCount_OneOccurence()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking to the cat cafe.");
            int result = newRepeatCounter.GetOccurenceCount();
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void RepeatCounterTest_GetOccurenceCount_MultipleOccurences()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I'm walking my cat Molly and my cat Kevin to the cathedral.");
            int result = newRepeatCounter.GetOccurenceCount();
            Assert.AreEqual(result, 2);
        }
    }
}