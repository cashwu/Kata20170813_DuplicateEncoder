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
            return "(";
        }
    }
}
