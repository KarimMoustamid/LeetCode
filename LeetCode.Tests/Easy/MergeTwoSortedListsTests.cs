using Xunit;
using LeetCode.Easy;
using LeetCode.Common;

namespace LeetCode.Tests.Easy;

public class MergeTwoSortedListsTests
{
    private readonly MergeTwoSortedLists _solution = new();

    [Fact]
    public void MergeTwoLists_ShouldMergeLists_WhenBothListsHaveElements()
    {
        // Arrange
        var list1 = ListNode.FromArray(new int[] { 1, 2, 4 });
        var list2 = ListNode.FromArray(new int[] { 1, 3, 4 });
        var expected = new int[] { 1, 1, 2, 3, 4, 4 };

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(expected, result?.ToArray());
    }

    [Fact]
    public void MergeTwoLists_ShouldReturnSecondList_WhenFirstListIsNull()
    {
        // Arrange
        ListNode? list1 = null;
        var list2 = ListNode.FromArray(new int[] { 0 });
        var expected = new int[] { 0 };

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(expected, result?.ToArray());
    }

    [Fact]
    public void MergeTwoLists_ShouldReturnNull_WhenBothListsAreNull()
    {
        // Arrange
        ListNode? list1 = null;
        ListNode? list2 = null;

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void MergeTwoListsRecursive_ShouldMergeLists_WhenBothListsHaveElements()
    {
        // Arrange
        var list1 = ListNode.FromArray(new int[] { 1, 2, 4 });
        var list2 = ListNode.FromArray(new int[] { 1, 3, 4 });
        var expected = new int[] { 1, 1, 2, 3, 4, 4 };

        // Act
        var result = _solution.MergeTwoListsRecursive(list1, list2);

        // Assert
        Assert.Equal(expected, result?.ToArray());
    }
}