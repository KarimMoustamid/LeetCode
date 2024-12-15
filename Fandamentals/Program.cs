// See https://aka.ms/new-console-template for more information
using Fandamentals;
// Console.WriteLine(ParseStrings.ParseStringValues("1,false,3.14"));
// Console.WriteLine(ParseStrings.ParseStringToDate("12/12/2021"));

Console.WriteLine(ParseStrings.ConvertStringToEnum<weekDays>("Monday"));

enum weekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};