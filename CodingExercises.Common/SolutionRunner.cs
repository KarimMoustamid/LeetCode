namespace CodingExercises.Common
{
    public class SolutionRunner
    {
        public abstract class RunnerBase
            {
                public abstract int ProblemNumber { get; }
                public abstract string ProblemTitle { get; }
                public abstract string Difficulty { get; }
            }

        public static class Runner
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
                public static void PrintSolutionInfo(RunnerBase solution)
                {
                    ConsoleColor previousColor = Console.ForegroundColor;

                    try
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Problem {solution.ProblemNumber}: {solution.ProblemTitle}");
                        Console.WriteLine($"Difficulty: {solution.Difficulty}");
                        Console.WriteLine(new string('-', 50));
                    }
                    finally
                    {
                        Console.ForegroundColor = previousColor;
                    }

                    Console.WriteLine();
                }

                public static void PrintColoredLines(ConsoleColor color, params string[] lines)
                {
                    var previousColor = Console.ForegroundColor;
                    Console.ForegroundColor = color;
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ForegroundColor = previousColor;
                }

            }
    }
}