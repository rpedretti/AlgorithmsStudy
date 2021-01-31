using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class PhoneNumberToTextTests
    {
        [TestCaseSource(nameof(TestData))]
        public IList<string> Test(string phone)
        {
            return PhoneNumberToText.Run(phone);
        }

        static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData("23").Returns(new List<string> {
                "ad", "ae", "af",
                "bd", "be", "bf",
                "cd", "ce", "cf"
            });
            yield return new TestCaseData("234").Returns(new List<string> {
                "adg", "adh", "adi",
                "aeg", "aeh", "aei",
                "afg", "afh", "afi",
                "bdg", "bdh", "bdi",
                "beg", "beh", "bei",
                "bfg", "bfh", "bfi",
                "cdg", "cdh", "cdi",
                "ceg", "ceh", "cei",
                "cfg", "cfh", "cfi",
            });
            yield return new TestCaseData("2").Returns(new List<string> { "a", "b", "c" });
            yield return new TestCaseData("4").Returns(new List<string> { "g", "h", "i" });
        }
    }
}
