using exercises_hammer.week_3;
using JetBrains.Annotations;
using Shouldly;

namespace tests.week_3;

[TestSubject(typeof(ProductArrayExceptSelf))]
public class ProductArrayExceptSelfTest
{
    [Theory]
    [InlineData(new int[] { -1, 0, 1, 2, 3 }, new int[] { 0, -6, 0, 0, 0 })]
    [InlineData(new int[] { 1, 2, 4, 6 }, new int[] { 48, 24, 12, 8 })]
    public void Test1(int[] nums, int[] expected)
    {
        var product = new ProductArrayExceptSelf();
        product.ProductExceptSelf(nums).ShouldBeEquivalentTo(expected);
    }
}