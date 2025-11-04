using LeetCode.Common;

namespace LeetCode.Easy;

/// <summary>
/// Problem 21: Merge Two Sorted Lists
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>
public class MergeTwoSortedLists : SolutionBase
{
    public override int ProblemNumber => 21;
    public override string ProblemTitle => "Merge Two Sorted Lists";
    public override string Difficulty => "Easy";
    public override string ProblemUrl => "https://leetcode.com/problems/merge-two-sorted-lists/";

    /// <summary>
    /// Iterative approach - O(m + n) time, O(1) space
    /// </summary>
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var dummy = new ListNode(0);
        var current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Attach remaining nodes
        current.next = list1 ?? list2;

        return dummy.next;
    }

    /// <summary>
    /// Recursive approach - O(m + n) time, O(m + n) space
    /// </summary>
    public ListNode? MergeTwoListsRecursive(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoListsRecursive(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoListsRecursive(list1, list2.next);
            return list2;
        }
    }
}