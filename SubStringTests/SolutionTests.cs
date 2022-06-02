using NUnit.Framework;
using SubString;

namespace SubStringTests
{
    [TestFixture()]
    public class SolutionTests
    {
        [TestCase("dvdf", 3)]
        [TestCase("asd",3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("aab", 2)]
        public void LengthOfLongestSubstringTest(string s, int result)
        {
            var solution = new Solution();
            Assert.AreEqual(result,solution.LengthOfLongestSubstring(s));
        }
    }
}