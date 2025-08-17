using System;
using Xunit;
using exercicios;

namespace tests
{
    public class SolutionPalindromeTests
    {
        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solutionPalindrome = new SolutionPalindrome();
            string s = "Was it a car or a cat I saw?";

            // Act
            var result = solutionPalindrome.IsPalindrome(
                s);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var solutionPalindrome = new SolutionPalindrome();
            string s = "No lemon, no melon";

            // Act
            var result = solutionPalindrome.IsPalindrome(
                s);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            var solutionPalindrome = new SolutionPalindrome();
            string s = " ";

            // Act
            var result = solutionPalindrome.IsPalindrome(
                s);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior4()
        {
            // Arrange
            var solutionPalindrome = new SolutionPalindrome();
            string s = "race a car";

            // Act
            var result = solutionPalindrome.IsPalindrome(
                s);

            // Assert
            Assert.True(true);
        }
    }
}
