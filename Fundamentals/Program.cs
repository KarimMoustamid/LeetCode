// See https://aka.ms/new-console-template for more information
using Fundamentals.Lesson_34;
string inputString = "apple,orange,banana";
char delimiter = ',';

string[] splittedArray = StringSplitAndJoin.SplitStringByDelimiter(inputString, delimiter);

string joinedString = StringSplitAndJoin.JoinStringsWithDelimiter(splittedArray, delimiter.ToString());

Console.WriteLine(splittedArray[0]);
Console.WriteLine(joinedString);