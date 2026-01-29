using CodingExercises.Common;
using CodingExercises.Eazy;
SolutionRunner.Runner.PrintColoredLines(ConsoleColor.DarkRed,
    "LeetCode Easy Problems",
    "====================",
    "");

   //Run_ContainsNegativeChecker_Solution();
   Run_SplitFullNameChecker_Solution();



    static void Run_ContainsNegativeChecker_Solution()
    {

        ContainsNegativeChecker solution = new ContainsNegativeChecker();
        SolutionRunner.Runner.PrintSolutionInfo(solution);

        var tests = new List<int[]>
        {
            new[] { 1, 2, 3, -1, 4, 5 },
            new[] { 1, 2, 3, 4, 5 }
        };

        foreach (var test in tests)
        {
            var input = test == null ? "null" : $"[{string.Join(", ", test)}]";

            bool hasNeg = ContainsNegativeChecker.ContainsNegative(test);

            SolutionRunner.Runner.PrintColoredLines(ConsoleColor.DarkGreen, $"Input: {input} - hasNeg = {hasNeg}");
        }

    }

    static void Run_SplitFullNameChecker_Solution()
    {
      var solution = new SplitFullNameChecker();

      SolutionRunner.Runner.PrintSolutionInfo(solution);
    }



