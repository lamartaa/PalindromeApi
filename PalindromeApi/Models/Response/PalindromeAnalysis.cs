using Palindrome.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeApi.Models.Response
{
    public class PalindromeAnalysis
    {
        public bool IsPalindrome { get; set; }
        public List<CharacterCount> SortedCharacterCount { get; set; }
        public string TimeStamp { get; set; }
    }
}
