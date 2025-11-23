using System;
using Xunit;
using exercicios;

namespace tests
{
    public class SolutionMergeTripletsTests
    {


        public SolutionMergeTripletsTests()
        {

        }

        private SolutionMergeTriplets CreateSolutionMergeTriplets()
        {
            return new SolutionMergeTriplets();
        }

        [Fact]
        public void MergeTriplets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solutionMergeTriplets = this.CreateSolutionMergeTriplets();
            int[][] triplets = [[9, 4, 9], [7, 4, 8], [10, 5, 1], [3, 7, 6], [5, 3, 4]];
            int[] target = [9, 7, 9];

            // Act
            var result = solutionMergeTriplets.MergeTriplets(
                triplets,
                target);

            // Assert
            Assert.True(result);
        }

        
    }
}
