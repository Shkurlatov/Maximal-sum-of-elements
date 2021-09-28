using Xunit;
using ParsingProject;
using System.Collections.Generic;

namespace Task3UnitTestProject
{
    public class ParsingTest
    {
        [Theory]
        [MemberData(nameof(ParsingTestData))]
        public void Parsing_InitializationAndSearchContent(int expectedMaxString, int[] expectedFalseStrings, string content)
        {
            // Arrange
            var parsing = new Parsing(content);

            // Assert
            Assert.Equal(expectedMaxString, parsing.MaxStringNumber);
            Assert.Equal(expectedFalseStrings, parsing.FalseStringNumbers);
        }

        public static IEnumerable<object[]> ParsingTestData()
        {
            yield return new object[] { 0, null, null };
            yield return new object[] { 0, null, "" };
            yield return new object[] { 0, new int[] { 1 }, " " };
            yield return new object[] { 0, new int[] { 1 }, "abcdef" };
            yield return new object[] { 1, new int[] { }, " 100" };
            yield return new object[] { 0, new int[] { 1 }, "100,abcdef" };
            yield return new object[] { 0, new int[] { 1 }, "100.100.100" };
            yield return new object[] { 0, new int[] { 1 }, "100_100" };
            yield return new object[] { 0, new int[] { 1 }, "1.435e6" };
            yield return new object[] { 0, new int[] { 1 }, "100,abcdef" };
            yield return new object[] { 1, new int[] { }, "0" };
            yield return new object[] { 1, new int[] { }, "100" };
            yield return new object[] { 1, new int[] { }, "100,100" };
            yield return new object[] { 1, new int[] { }, "100.100" };
            yield return new object[] { 1, new int[] { }, "-100" };
            yield return new object[] { 1, new int[] { }, "-100,-100" };
            yield return new object[] { 1, new int[] { }, "-100.100" };
            yield return new object[] { 2, new int[] { 1 }, " \n0" };
            yield return new object[] { 2, new int[] { 1 }, "abcdef\n100" };
            yield return new object[] { 2, new int[] { }, " 100\n100,100" };
            yield return new object[] { 2, new int[] { 1 }, "100,abcdef\n100.100" };
            yield return new object[] { 2, new int[] { 1 }, "100.100.100\n-100" };
            yield return new object[] { 2, new int[] { 1 }, "100_100\n-100,-100" };
            yield return new object[] { 2, new int[] { 1 }, "1.435e6\n-100.100" };
            yield return new object[] { 1, new int[] { }, "1\n0" };
            yield return new object[] { 1, new int[] { }, "200\n100" };
            yield return new object[] { 1, new int[] { }, "200,200\n100,100" };
            yield return new object[] { 1, new int[] { }, "200.200\n100.100" };
            yield return new object[] { 2, new int[] { }, "-200\n-100" };
            yield return new object[] { 2, new int[] { }, "-200,-200\n-100,-100" };
            yield return new object[] { 2, new int[] { }, "-200.100\n-100.100" };
        }
    }
}
