using RunnerBase = CodingExercises.Common.SolutionRunner.RunnerBase;
namespace CodingExercises.Eazy
{
    public class SplitFullNameChecker : RunnerBase
    {
        public override int ProblemNumber => 02;
        public override string ProblemTitle => "Split Full Name";
        public override string Difficulty => "Easy";

        // Splits a full name ("First Last") into first and last name parts.
        public static (string FirstName , string LastName) SplitFullName(string fullName)
        {
            // Validate input to avoid invalid slicing.
            if(string.IsNullOrWhiteSpace(fullName)) throw new ArgumentException();

            // Find the single space separating first and last names.
            var spaceIndex = fullName.IndexOf(' ');
            // Slice the string around the space without allocating an array.
            var firstName = fullName[..spaceIndex];
            var lastName = fullName[(spaceIndex + 1)..];
            // Return a named tuple for clarity at call sites.
            return (FirstName: firstName, LastName: lastName);
        }
    }
}