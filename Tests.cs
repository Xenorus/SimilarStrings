using System.Collections.Generic;
using NUnit.Framework;

namespace Interview
{
    // Если тесты не запускаются через Test Explorer, выполните Clean Solution
    public class Tests
    {
        public static IEnumerable<object[]> TestCases()
        {
            yield return new object[] {"korova", "kovora", true};
            yield return new object[] {"abc", "cab", false};
            yield return new object[] {"korovv", "kovorr", false};
            yield return new object[] {"korova", "krova", true};
            yield return new object[] {"korova", "kroav", false};
            yield return new object[] {"krova", "korova", true};
            yield return new object[] {"korova", "korovan", true};
            yield return new object[] {"korovan", "korova", true};
            yield return new object[] {"korova", "vorona", false};
            yield return new object[] {"korova", "rotova", false};
            yield return new object[] {"rotova", "korova", false};
            yield return new object[] {"korova", "karova", false};
            yield return new object[] {"korova", "rokota", false};
            yield return new object[] {"kororo", "korova", false};
            yield return new object[] {"korova", "kororo", false};
            yield return new object[] {"korova", "a", false};
            yield return new object[] {"rama", "lama", false};
            yield return new object[] {"kxova", "korova", false};
            yield return new object[] {"abc", "abca", true};
            yield return new object[] {"abcab", "abcb", true};
            yield return new object[] {"abcab", "abca", true};
            yield return new object[] {"abcab", "bcab", true};
            yield return new object[] {"abcab", "acab", true};
            yield return new object[] {"abcab", "abcba", true};
            yield return new object[] {"abcbac", "abcabc", true};
            yield return new object[] {"abracadabra", "acracadabra", false};
            yield return new object[] {"aaaaaaab", "aaaaaaac", false};
            yield return new object[] {"a", "b", false};
            yield return new object[] {"a", "ab", true};
            yield return new object[] {"ab", "a", true};
            yield return new object[] {"ab", "ba", true};
            yield return new object[] {"abcdab", "abcd", false};
            yield return new object[] {"abcd", "abcdab", false};
            yield return new object[] {"abcd", "bcx", false};
            yield return new object[] {"bcd", "abcd", true};
            yield return new object[] {"acd", "abcd", true};
            yield return new object[] {"abd", "abcd", true};
            yield return new object[] {"abc", "abcd", true};
            yield return new object[] {"dbcd", "dbecd", true};
            yield return new object[] {"dbecd", "dbcd", true};
            yield return new object[] {"qwerty", "verty", false};
            yield return new object[] {"verty", "qwerty", false};
            yield return new object[] {"dbcd", "dbecx", false};
            yield return new object[] {"dbecx", "dbcd", false};
            yield return new object[] {"abcdefghijklmnopqrstuvwxyz", "zbcdefghijklmnopqrstuvwxya", true};
            yield return new object[] {"abcdefghijklmnopqrstuvwxyz", "zbcdefthijklmnopqrsguvwxya", false};
            yield return new object[] {"abcdefghijklmnopqrstuvwxyz", "bcdefghijklmnopqrstuvwxyza", false};
            yield return new object[] {"abcdefghijklmnopqrstuvwxyz", "abcdefghijlmnopqrstuvwxyz", true};
            yield return new object[] {"abcdefghijlmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", true};
            yield return new object[] {"aaaaaaa", "aaaa", false};
            yield return new object[] {"aaaaaaa", "aaaaaa", true};
            yield return new object[] {"aaaaab", "aaabb", false};
            yield return new object[] {"bbbaa", "bbbbba", false};
            yield return new object[] {"ababab", "bbaba", false};
            yield return new object[] {"bb", "abc", false};
            yield return new object[] {"abaaa", "babbb", false};
            yield return new object[] {"aagaeaa", "aacaiaa", false};
        }

     [TestCaseSource(nameof(TestCases))]
        public void Test(string first, string second, bool expected)
        {
            var actual = new SimilarStringsChecker().CheckStrings(first, second);
            Assert.AreEqual(expected, actual);
        }
    }
}