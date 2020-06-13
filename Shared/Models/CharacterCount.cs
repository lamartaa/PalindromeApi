using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome.Shared.Models
{
    public class CharacterCount
    {
        public char Character { get; }
        public int Count { get; }
        public CharacterCount(char character, int count)
        {
            Character = character;
            Count = count;
        }
    }
}
