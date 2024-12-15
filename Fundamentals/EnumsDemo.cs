namespace Fundamentals
{
    public static class EnumsDemo
    {
        // Defining enums to demonstrate various types
        public enum DaysOfWeek // Standard enum with default integer values
        {
            Sunday, // 0
            Monday, // 1
            Tuesday, // 2
            Wednesday, // 3
            Thursday, // 4
            Friday, // 5
            Saturday // 6
        }

        public enum StatusCodes : short // Enum with explicitly defined underlying type
        {
            Success = 1,
            Warning = 2,
            Error = 3
        }

        [Flags] // Enum with the Flags attribute for bitwise operations
        public enum FilePermissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4,
            FullControl = Read | Write | Execute
        }

        // Adding a method to demonstrate usage of the enums
        public static void DemoEnums()
        {
            // Using the DaysOfWeek enum
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine($"Today is: {today}");

            // Using the StatusCodes enum
            StatusCodes code = StatusCodes.Warning;
            Console.WriteLine($"Operation status: {code} (Underlying value: {(short) code})");

            // Using the FilePermissions enum
            FilePermissions permissions = FilePermissions.Read | FilePermissions.Write;
            Console.WriteLine($"Assigned permissions: {permissions}");

            // Checking for specific permissions using bitwise operations
            bool hasWritePermission = (permissions & FilePermissions.Write) == FilePermissions.Write;
            Console.WriteLine($"Has write permission: {hasWritePermission}");
        }
    }
}