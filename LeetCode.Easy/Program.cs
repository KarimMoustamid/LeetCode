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

        RunBest_Time_to_Buy_and_Sell_Stock_II_Solution();
    }

    #region Arrays
    static void RunRemoveDuplicatesFromSortedArraySolution()
    {
        var solution = new RemoveDuplicatesFromSortedArray();
        SolutionRunner.PrintSolutionInfo(solution);

        int[] nums = new[] { 1, 1, 1, 2, 2, 3, 3, 3 };
        int[] expectedNums = new[] { 1, 2, 3 };
        Console.WriteLine($"Input: nums = [{string.Join(", ",nums)}] - expected = [{string.Join(", ", expectedNums)}]");
        Console.WriteLine();


        int numberOfUniqueValues = solution.RemoveDuplicates(nums);

        SolutionRunner.PrintColoredLines(ConsoleColor.DarkGreen,$"Number of Unique values = {numberOfUniqueValues}");
    }

    static void RunBest_Time_to_Buy_and_Sell_Stock_II_Solution()
    {
        var solution = new P002_Best_Time_to_Buy_and_Sell_Stock_II();
        SolutionRunner.PrintSolutionInfo(solution);

        int[] prices = new[] { 7, 1, 5, 3, 6, 4 };
        int expected = 7;
        Console.WriteLine($"Input: prices = [{string.Join(", ",prices)}] - expected = {expected}");
        Console.WriteLine();


        solution.MaxProfit(prices);
    }

    #endregion

}