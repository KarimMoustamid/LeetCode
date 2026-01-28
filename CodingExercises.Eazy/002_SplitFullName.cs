using RunnerBase = CodingExercises.Common.SolutionRunner.RunnerBase;
namespace CodingExercises.Eazy
{
    public class SplitFullNameChecker : RunnerBase
    {
        public override int ProblemNumber => 02;
        public override string ProblemTitle => "Split Full Name";
        public override string Difficulty => "Easy";

        public static (string? FirstName , string? LastName) SplitFullName(string fullName)
        {
            //your code goes here
            foreach (var character in fullName)
            {
                var firstName = "";
                var lastName = "";

                if (char.IsWhiteSpace(character))
                {

                }
            }
            return (null, null);
        }
    }
}