using System;
using Xunit;
using Apples;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Apple apple;

        public UnitTest1()
        {
            apple = new Apple();
        }

        [Fact]
        public void GetAppleTest()
        {
            // arrange - is instatiated in the UnitTest1 "constructor"

            // act 
            string output = apple.GetApple();

            // assert
            Assert.Equal("apple", output);
        }

        // its not possible to give list in InlineData - but array is
        [Theory]
        [InlineData(new int[4]{ 1, 2, 3, 4 })]
        [InlineData(new int[1] { 1 })]
        [InlineData(new int[0])]
        public void SumListTest(int[] array)
        {
            List<int> list = new List<int>(array);  // transformation of array to list 
            int output = apple.SumList(list);
            
            Assert.Equal(10, output);
            //Assert.Equal(1, output);
            //Assert.Empty(list);
        }
    }

    
}
