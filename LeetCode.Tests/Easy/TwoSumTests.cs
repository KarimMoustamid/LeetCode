using Xunit;
using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class TwoSumTests
{
    private readonly TwoSum _solution = new();

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSumHashMap_ShouldReturnCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = _solution.TwoSumHashMap(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSumBruteForce_ShouldReturnCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = _solution.TwoSumBruteForce(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSumHashMap_ShouldThrowException_WhenNoSolutionExists()
    {
        // Arrange
        int[] nums = { 1, 2, 3 };
        int target = 10;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _solution.TwoSumHashMap(nums, target));
    }
}