using Palindrome.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome.Shared.Helpers
{
    public static class PalindromeHelper
    {
        public static PalindromeResult AnalyzeText(string text)
        {
            text = text.ToLower();

            bool isPalindrome = IsPalindrome(text);

            List<CharacterCount> alphabeticalCharacterCount = GetAlphabeticalCharacterCount(text);

            return new PalindromeResult(isPalindrome, alphabeticalCharacterCount);
        }

        private static bool IsPalindrome(string text)
        {
            bool isPalindrome = true;

            //for loops comes from both sides of the text to check for palindrome 
            for (int i = 0; i < text.Length; i++)
            {
                //if character at location i does not equals the character at 
                //location text.Length - 1 - i the text is not a palindrome
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }

                //this is a check to see if the loop has reached the center
                //(or two) character(s) in the text. If we have made it to this point
                // then we can diffinitively say the text is a palindrome
                if (i == (text.Length - 1 - i))
                {
                    break;
                }
            }

            return isPalindrome;
        }

        private static List<CharacterCount> GetAlphabeticalCharacterCount(string text)
        {
            //Group by characters first, then alphabetize characters, then create the Character Count object
            List<CharacterCount> alphabeticalCharacterCount = text
                                                                .GroupBy(c => c)
                                                                .OrderBy(g => g.Key)
                                                                .Select(g => new CharacterCount(g.Key, g.Count()))
                                                                .ToList();

            return alphabeticalCharacterCount;
        }
    }
}
