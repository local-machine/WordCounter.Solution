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
            RepeatCounter myRepeatCounter = new RepeatCounter("cat", "I'm walking to the cathedral.");
            Assert.AreEqual(typeof(RepeatCounter), myRepeatCounter.GetType());
        }

        // [TestMethod]
        // public void 
    }
}