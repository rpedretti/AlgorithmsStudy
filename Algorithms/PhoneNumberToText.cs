using System.Collections.Generic;

namespace Algorithms
{
    public static class PhoneNumberToText
    {
        private static readonly Dictionary<char, char[]> map = new Dictionary<char, char[]>()
        {
            { '2', new char[] { 'a', 'b', 'c' } },
            { '3', new char[] { 'd', 'e', 'f' } },
            { '4', new char[] { 'g', 'h', 'i' } },
            { '5', new char[] { 'j', 'k', 'l' } },
            { '6', new char[] { 'm', 'n', 'o' } },
            { '7', new char[] { 'p', 'q', 'r', 's' } },
            { '8', new char[] { 't', 'u', 'v' } },
            { '9', new char[] { 'w', 'x', 'y', 'z' } },
        };

        public static IList<string> Run(string p1)
        {
            var output = new List<string>();
            if (!string.IsNullOrEmpty(p1)) BackTrack("", p1, output);

            return output;
        }

        private static void BackTrack(string combination, string nextDigits, List<string> output)
        {
            if (string.IsNullOrEmpty(nextDigits))
            {
                output.Add(combination);
            }
            else
            {
                var digit = nextDigits[0];
                var letters = map[digit];

                foreach (var letter in letters)
                {
                    var nextCombination = combination + letter;
                    var nextNextDigits = nextDigits[1..];
                    BackTrack(nextCombination, nextNextDigits, output);
                }
            }
        }
    }
}
