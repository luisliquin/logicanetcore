using ValidationLibrary;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase("4/6", "2/3")]
        [TestCase("10/11", "10/11")]
        [TestCase("100/400", "1/4")]
        public void TestSimplify(string input, string expected)
        {
            Assert.AreEqual(expected, FractionSimplifier.Simplify(input));
        }

        [TestCase("E. Poe", true)]
        [TestCase("E. A. Poe", true)]
        [TestCase("Edgard Allan Poe", true)]
        [TestCase("Edgard", false)]
        public void TestValidName(string input, bool expected)
        {
            Assert.AreEqual(expected, NameValidator.ValidName(input));
        }
    }
}