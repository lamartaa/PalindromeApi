using NUnit.Framework;
using Palindrome.Shared.Helpers;
using Palindrome.Shared.Models;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Madam")]
        [TestCase("noon")]
        [TestCase("malayalam")]
        [Test]
        public void AnalyzeText_IsPalindrome_ReturnTrue(string text)
        {
            var result = PalindromeHelper.AnalyzeText(text);

            Assert.IsTrue(result.IsPalindrome, $"{text} should be a palindrome");
        }

        [TestCase("hello")]
        [TestCase("running")]
        [TestCase("fast")]
        [Test]
        public void AnalyzeText_IsPalindrome_ReturnFalse(string text)
        {
            var result = PalindromeHelper.AnalyzeText(text);

            Assert.IsFalse(result.IsPalindrome, $"{text} should not be a palindrome");
        }

        [TestCase("Madam")]
        [Test]
        public void AnalyzeText_SortedCharacterCount_AreEqualTrue(string text)
        {
            var result = PalindromeHelper.AnalyzeText(text);

            var array = result.SortedCharacterCount.ToArray();

            Assert.AreEqual('a', array[0].Character);
            Assert.AreEqual(2, array[0].Count);
            Assert.AreEqual('d', array[1].Character);
            Assert.AreEqual(1, array[1].Count);
            Assert.AreEqual('m', array[2].Character);
            Assert.AreEqual(2, array[2].Count);
        }
    }
}