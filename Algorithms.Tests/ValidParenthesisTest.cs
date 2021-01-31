using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class ValidParenthesisTest
    {
        [TestCaseSource(nameof(TestData))]
        public bool Test(string input)
        {
            return ValidPaarethesis.Run(input);
        }

        static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData("").Returns(true);
            yield return new TestCaseData("(").Returns(false);
            yield return new TestCaseData("[").Returns(false);
            yield return new TestCaseData("{").Returns(false);
            yield return new TestCaseData(")").Returns(false);
            yield return new TestCaseData("]").Returns(false);
            yield return new TestCaseData("}").Returns(false);

            yield return new TestCaseData("()").Returns(true);
            yield return new TestCaseData("()(").Returns(false);
            yield return new TestCaseData("())").Returns(false);

            yield return new TestCaseData("[]").Returns(true);
            yield return new TestCaseData("[][").Returns(false);
            yield return new TestCaseData("[]]").Returns(false);

            yield return new TestCaseData("{}").Returns(true);
            yield return new TestCaseData("{}{").Returns(false);
            yield return new TestCaseData("{}}").Returns(false);
            
            yield return new TestCaseData("(]").Returns(false);
            yield return new TestCaseData("[}").Returns(false);
            yield return new TestCaseData("{)").Returns(false);

        }
    }
}
