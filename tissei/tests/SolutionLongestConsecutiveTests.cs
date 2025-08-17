using System;
using Xunit;
using exercicios;
using Shouldly;

namespace tests
{
    public class SolutionLongestConsecutiveTests
    {
        [Fact]
        public void LongestConsecutive_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solutionLongestConsecutive = new SolutionLongestConsecutive();
            int[] nums = [0, -1];

            // Act
            var result = solutionLongestConsecutive.LongestConsecutive(
                nums);

            // Assert
            result.ShouldBe(2);
        }
    }
}
