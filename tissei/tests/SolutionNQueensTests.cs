using System;
using Xunit;
using exercicios;
using Shouldly;

namespace tests
{
    public class SolutionNQueensTests
    {
        [Fact]
        public void SolveNQueens_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solutionNQueens = new SolutionNQueens();
            int n = 4;
            var expected = new List<List<string>>
            {
                new List<string> { ".Q..","...Q","Q...","..Q." },
                new List<string> { "..Q.","Q...","...Q",".Q.." }
            };

            // Act
            var result = solutionNQueens.SolveNQueens(
                n);

            result
                .Select(sol => string.Join(",", sol))   // flatten each solution into a string
                .OrderBy(x => x)
                .ShouldBe(expected.Select(sol => string.Join(",", sol)).OrderBy(x => x));
        }
    }
}
