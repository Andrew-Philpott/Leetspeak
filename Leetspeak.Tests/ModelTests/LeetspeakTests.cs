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
            string s = "aEOITs";
            Assert.AreEqual("a3017z", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringContainingEReplacesEWithThree_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "E";
            Assert.AreEqual("3", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringContainingOReplacesOWithZero_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "O";
            Assert.AreEqual("0", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringContainingCapitalIReplacesIWithOne_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "I";
            Assert.AreEqual("1", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringContainingTReplacesTWithSeven_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "T";
            Assert.AreEqual("7", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringContainingSReplacesSWithZ_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "s";
            Assert.AreEqual("z", translator.Translate(s));
        }

        [TestMethod]
        public void Translate_StringWithMultipleWordsToLeetSpeak_String()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            string s = "Don't you love these 'String' exercises? I do!";
            Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", translator.Translate(s));
            // string s = "'Strings strings";
            // Assert.AreEqual("'S7r1ngz s7r1ngz", translator.Translate(s));
        }
    }
}