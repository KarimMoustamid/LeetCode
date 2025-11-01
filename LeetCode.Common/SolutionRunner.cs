namespace LeetCode.Common;

/// <summary>
/// Base class for all LeetCode solutions to ensure consistent structure.
/// </summary>
public abstract class SolutionBase
{
    /// <summary>
    /// The problem number on LeetCode.
    /// </summary>
    public abstract int ProblemNumber { get; }
    
    /// <summary>
    /// The problem title.
    /// </summary>
    public abstract string ProblemTitle { get; }
    
    /// <summary>
    /// The problem difficulty.
    /// </summary>
    public abstract string Difficulty { get; }
    
    /// <summary>
    /// URL to the problem on LeetCode.
    /// </summary>
    public string ProblemUrl => $"https://leetcode.com/problems/{ProblemTitle.ToLower().Replace(' ', '-')}/";
}

/// <summary>
/// Utility class for running and testing solutions.
/// </summary>
public static class SolutionRunner
{
    /// <summary>
    /// Measures execution time of a function.
    /// </summary>
    public static T MeasureExecutionTime<T>(Func<T> func, out TimeSpan executionTime)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        var result = func();
        stopwatch.Stop();
        executionTime = stopwatch.Elapsed;
        return result;
    }

    /// <summary>
    /// Prints solution information.
    /// </summary>
    public static void PrintSolutionInfo(SolutionBase solution)
    {
        Console.WriteLine($"Problem {solution.ProblemNumber}: {solution.ProblemTitle}");
        Console.WriteLine($"Difficulty: {solution.Difficulty}");
        Console.WriteLine($"URL: {solution.ProblemUrl}");
        Console.WriteLine(new string('-', 50));
    }
}