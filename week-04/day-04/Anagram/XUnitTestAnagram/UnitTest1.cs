using System;
using Xunit;
using Anagram;


namespace XUnitTestAnagram
{
    public class UnitTest1
    {
        private TestObject testObject;

        public UnitTest1()
        {
            testObject = new TestObject();
        }

        [Theory]
        [InlineData("martin", "nitram")]
        [InlineData("ahoj", "nazdar")]
        public void Test1(string wordOne, string wordTwo)
        {
            bool output = testObject.IsAnagram(wordOne, wordTwo);
            Assert.True(output);
            
        }
    }
}
