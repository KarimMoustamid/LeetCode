namespace CodingExercises.Eazy
{
    using Common;

    public class ContainsNegativeChecker : SolutionRunner.RunnerBase
    {
        public override int ProblemNumber => 1;
        public override string ProblemTitle  => "Contains Negative";
        public override string Difficulty => "Easy";

        public static bool ContainsNegative(IEnumerable<int>? numbers)
        {
            return numbers?.Any(n => n < 0) ?? false;
        }

    }
}