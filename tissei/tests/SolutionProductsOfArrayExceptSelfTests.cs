using System;
using Xunit;
using exercicios;
using Shouldly;

namespace tests
{
    public class SolutionProductsOfArrayExceptSelfTests
    {
        [Fact]
        public void ProductExceptSelf_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solutionProductsOfArrayExceptSelf = new SolutionProductsOfArrayExceptSelf();
            int[] nums = [1, 2, 4, 6];

            // Act
            var result = solutionProductsOfArrayExceptSelf.ProductExceptSelf(
                nums);

            // Assert
            result.ShouldBeEquivalentTo(new[] { 48, 24, 12, 8 });
        }

        [Fact]
        public void ProductExceptSelf_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var solutionProductsOfArrayExceptSelf = new SolutionProductsOfArrayExceptSelf();
            int[] nums = [-1, 0, 1, 2, 3];

            // Act
            var result = solutionProductsOfArrayExceptSelf.ProductExceptSelf(
                nums);

            // Assert
            result.ShouldBeEquivalentTo(new[] { 0, -6, 0, 0, 0 });
        }
    }
}
