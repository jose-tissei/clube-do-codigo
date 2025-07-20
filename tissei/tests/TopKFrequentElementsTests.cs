using System;
using Xunit;
using exercicios;
using Shouldly;

namespace tests
{
    public class TopKFrequentElementsTests
    {
        [Fact]
        public void TopKFrequent_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var topKFrequentElements = new TopKFrequentElements();
            int[] nums = [1, 2, 2, 3, 3, 3];
            int k = 2;

            // Act
            var result = topKFrequentElements.TopKFrequent(
                nums,
                k);

            // Assert
            result.ShouldBeEquivalentTo(new int[] { 3, 2 });
        }

        [Fact]
        public void TopKFrequent_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var topKFrequentElements = new TopKFrequentElements();
            int[] nums = [1, 2];
            int k = 2;

            // Act
            var result = topKFrequentElements.TopKFrequent(
                nums,
                k);

            // Assert
            result.ShouldBeEquivalentTo(new int[] { 1, 2 });
        }
    }
}
