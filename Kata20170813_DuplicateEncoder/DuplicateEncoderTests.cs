using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170813_DuplicateEncoder
{
    [TestClass]
    public class DuplicateEncoderTests
    {
        [TestMethod]
        public void input_a()
        {
            DuplicateEncoderShouldBe("(", "a");
        }

        [TestMethod]
        public void input_ab()
        {
            DuplicateEncoderShouldBe("((", "ab");
        }

        [TestMethod]
        public void input_aa()
        {
            DuplicateEncoderShouldBe("))", "aa");
        }

        private static void DuplicateEncoderShouldBe(string expected, string word)
        {
            var kata = new Kata();
            var actual = kata.DuplicateEncode(word);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string DuplicateEncode(string word)
        {
            return string.Concat(word.Select(c => AnyDuplicateChar(word, c) ? ")" : "("));
        }

        private static bool AnyDuplicateChar(string word, char @char)
        {
            return word.Count(c => @char == c) > 1;
        }
    }
}
