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
            string s = "a";
            Assert.AreEqual("a", translator.Translate(s));
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
    }
}