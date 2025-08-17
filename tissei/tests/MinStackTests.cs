using System;
using Xunit;
using exercicios;

namespace tests
{
    public class MinStackTests
    {
        [Fact]
        public void Push_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            // Act
            MinStack minStack = new MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            Assert.Equal(minStack.GetMin(), 0); // return 0
            minStack.Pop();
            minStack.Top();    // return 2
            Assert.Equal(minStack.GetMin(), 1); // return 1

            // Assert
            Assert.True(false);
        }
    }
}
