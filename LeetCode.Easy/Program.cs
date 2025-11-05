using LeetCode.Common;

namespace LeetCode.Easy;

class Program
{
    static void Main(string[] args)
    {
        SolutionRunner.PrintColoredLines(ConsoleColor.DarkRed,
            "LeetCode Easy Problems",
            "====================",
            "");

        RunRemoveDuplicatesFromSortedArraySolution();

    }

    static void RunRemoveDuplicatesFromSortedArraySolution()
    {
        var solution = new RemoveDuplicatesFromSortedArray();
        SolutionRunner.PrintSolutionInfo(solution);

        int[] nums = [3, 1, 2, 1, 3, 2, 1, 3];
        int[] expectedNums = [1, 2, 3];
        Console.WriteLine($"Input: nums = [{string.Join(", ",nums)}] - expected = [{string.Join(", ", expectedNums)}]");


        solution.RemoveDuplicates(nums);

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

}