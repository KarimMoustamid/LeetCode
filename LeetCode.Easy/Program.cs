using LeetCode.Common;

namespace LeetCode.Easy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LeetCode Easy Problems");
        Console.WriteLine("====================");
        
        // Example: Two Sum
        RunTwoSumExample();
        
        // Example: Merge Two Sorted Lists
        RunMergeTwoSortedListsExample();
    }

    static void RunTwoSumExample()
    {
        var solution = new TwoSum();
        SolutionRunner.PrintSolutionInfo(solution);
        
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        
        Console.WriteLine($"Input: nums = [{string.Join(", ", nums)}], target = {target}");
        
        var result = SolutionRunner.MeasureExecutionTime(
            () => solution.TwoSumHashMap(nums, target),
            out var executionTime);
        
        Console.WriteLine($"Output: [{string.Join(", ", result)}]");
        Console.WriteLine($"Execution Time: {executionTime.TotalMilliseconds}ms");
        Console.WriteLine();
    }

    static void RunMergeTwoSortedListsExample()
    {
        var solution = new MergeTwoSortedLists();
        SolutionRunner.PrintSolutionInfo(solution);
        
        var list1 = ListNode.FromArray(new int[] { 1, 2, 4 });
        var list2 = ListNode.FromArray(new int[] { 1, 3, 4 });
        
        Console.WriteLine($"Input: list1 = [{string.Join(" -> ", list1?.ToArray() ?? Array.Empty<int>())}]");
        Console.WriteLine($"       list2 = [{string.Join(" -> ", list2?.ToArray() ?? Array.Empty<int>())}]");
        
        var result = SolutionRunner.MeasureExecutionTime(
            () => solution.MergeTwoLists(list1, list2),
            out var executionTime);
        
        Console.WriteLine($"Output: [{string.Join(" -> ", result?.ToArray() ?? Array.Empty<int>())}]");
        Console.WriteLine($"Execution Time: {executionTime.TotalMilliseconds}ms");
        Console.WriteLine();
    }
}