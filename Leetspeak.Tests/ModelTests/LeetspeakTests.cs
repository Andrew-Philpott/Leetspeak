using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;
using System;

namespace Leetspeak.Tests
{
    [TestClass]
    public class LeetspeakTests
    {

        [TestMethod]
        public void Translate_StringContainsUnaffectedLetters_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "A";
            Assert.AreEqual("A", translator.Translate(s));
        }
    }
}