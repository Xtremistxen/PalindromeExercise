using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("A man", false)]
        [InlineData("No 'x' in Xanth", false)]
        [InlineData("123454321", true)]
        [InlineData("123456789", false)]
        
       
        public void IsAPalidromeTest(string thuum, bool expected)
        {
            // Arrange
            var wordsmith = new WordSmith();
            
            // Act
            var actual = wordsmith.IsAPalindrome(thuum);
            
            // Assert
            Assert.Equal(expected, actual);

        }
        
    }
}
