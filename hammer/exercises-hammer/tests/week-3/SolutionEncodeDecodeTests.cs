using System;
using Xunit;
using exercises_hammer.week_3.EncodeDecode;
using Shouldly;

namespace tests
{
    public class SolutionEncodeDecodeTests
    {
        [Fact]
        public void Encode_StateUnderTest_ExpectedBehavior()
        {
            var solutionEncodeDecode = new SolutionEncodeDecode();
            string[] strs = ["neet", "code", "love", "you"];

            var encodedResult = solutionEncodeDecode.Encode(strs);
            var actual = solutionEncodeDecode.Decode(encodedResult);

            actual.ShouldBeEquivalentTo(strs.ToList());
        }

        [Fact]
        public void Encode_StateUnderTest_ExpectedBehavior2()
        {
            var solutionEncodeDecode = new SolutionEncodeDecode();
            string[] strs = [""];

            var encodedResult = solutionEncodeDecode.Encode(strs);
            var actual = solutionEncodeDecode.Decode(encodedResult);

            actual.ShouldBeEquivalentTo(strs.ToList());
        }

        [Fact]
        public void Encode_StateUnderTest_ExpectedBehavior3()
        {
            var solutionEncodeDecode = new SolutionEncodeDecode();
            string[] strs = [];

            var encodedResult = solutionEncodeDecode.Encode(strs);
            var actual = solutionEncodeDecode.Decode(encodedResult);

            actual.ShouldBeEquivalentTo(strs.ToList());
        }

        [Fact]
        public void Encode_StateUnderTest_ExpectedBehavior4()
        {
            var solutionEncodeDecode = new SolutionEncodeDecode();
            string[] strs = ["", "   ", "!@#$%^&*()_+", "LongStringWithNoSpaces", "Another, String With, Commas"];

            var encodedResult = solutionEncodeDecode.Encode(strs);
            var actual = solutionEncodeDecode.Decode(encodedResult);

            actual.ShouldBeEquivalentTo(strs.ToList());
        }

    }
}
