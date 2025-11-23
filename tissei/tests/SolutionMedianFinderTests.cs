using System;
using Xunit;
using exercicios;

namespace tests
{
    public class SolutionMedianFinderTests
    {
        [Fact]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            SolutionMedianFinder medianFinder = new SolutionMedianFinder();
            medianFinder.AddNum(1);    // arr = [1]
            Assert.Equal(1.0, medianFinder.FindMedian()); // return 1.0
            medianFinder.AddNum(3);    // arr = [1, 3]
            Assert.Equal(2.0, medianFinder.FindMedian()); // return 2.0
            medianFinder.AddNum(2);    // arr[1, 2, 3]
            Assert.Equal(2.0, medianFinder.FindMedian()); // return 2.0
        }

        [Fact]
        public void AddNum_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            SolutionMedianFinder medianFinder = new SolutionMedianFinder();
            medianFinder.AddNum(0);    // arr = [1]
            medianFinder.AddNum(0);    // arr = [1]
            Assert.Equal(0.0, medianFinder.FindMedian()); // return 1.0
        }
    }
}
