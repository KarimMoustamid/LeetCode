namespace CodingExercises.Eazy
{
    using System.Globalization;
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

        public static bool ContainsNegative_BasicLoop(IEnumerable<int>? numbers)
        {

            if(numbers == null) return false;

            var hasNeg = false;
            foreach (var number in numbers)
            {
                if(number < 0)
                    return true;
                    break; // Exit loop early if negative number is found
            }       

            return hasNeg;
        }

        public static bool ContainsNegative_ForEach(IEnumerable<int>? numbers)
        {
            if(numbers == null) return false;

            foreach (var number in numbers)
            {
                if(number < 0)
                    return true;
            }       

            return false;

        }

    }
}