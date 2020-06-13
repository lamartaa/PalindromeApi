using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Shared.Models
{
    public class PalindromeResult
    {
        public bool IsPalindrome { get; }
        public List<CharacterCount> SortedCharacterCount { get; }

        public PalindromeResult(bool isPalindrome, List<CharacterCount> sortedCharacterCount)
        {
            IsPalindrome = isPalindrome;
            SortedCharacterCount = sortedCharacterCount;
        }
    }
}
