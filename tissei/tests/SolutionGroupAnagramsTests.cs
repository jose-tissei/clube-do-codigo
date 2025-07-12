using exercicios;
using Shouldly;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var actual = new SolutionGroupAnagrams().GroupAnagrams(["act", "pots", "tops", "cat", "stop", "hat"]);

            actual.ShouldBeEquivalentTo(new string[][] { ["act", "cat"], ["pots", "tops", "stop"], ["hat"] });
        }

        [Fact]
        public void Test2()
        {
            var actual = new SolutionGroupAnagrams().GroupAnagrams(["act", "pots", "tops", "cat", "stop", "hat"]);

            actual.ShouldBeEquivalentTo(new string[][] { ["act", "cat"], ["pots", "tops", "stop"], ["hat"] });
        }

        [Fact]
        public void Test3()
        {
            var actual = new SolutionGroupAnagrams().GroupAnagrams(["", ""]);

            actual.ShouldBeEquivalentTo(new string[][] { ["", ""]});
        }
    }
}