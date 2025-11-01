# LeetCode Solutions in C#

This repository contains my solutions to LeetCode problems organized by difficulty level.

## Project Structure

```text
├── leetcode.sln                    # Main solution file
├── LeetCode.Common/                # Shared utilities and data structures
│   ├── ListNode.cs                 # Linked list node definition
│   ├── TreeNode.cs                 # Binary tree node definition
│   └── SolutionRunner.cs           # Base classes and utilities
├── LeetCode.Easy/                  # Easy difficulty problems
│   ├── P001_TwoSum.cs             # Problem 1: Two Sum
│   ├── P021_MergeTwoSortedLists.cs # Problem 21: Merge Two Sorted Lists
│   └── Program.cs                  # Demo runner for easy problems
├── LeetCode.Medium/                # Medium difficulty problems
├── LeetCode.Hard/                  # Hard difficulty problems
└── LeetCode.Tests/                 # Unit tests for all solutions
    └── Easy/
        ├── TwoSumTests.cs
        └── MergeTwoSortedListsTests.cs
```

## Naming Convention

- **Solution Files**: `P{number:000}_{ProblemName}.cs`
  - Example: `P001_TwoSum.cs`, `P021_MergeTwoSortedLists.cs`
- **Test Files**: `{ProblemName}Tests.cs`
  - Example: `TwoSumTests.cs`, `MergeTwoSortedListsTests.cs`

## How to Use

### Adding a New Problem

1. **Choose the appropriate project** based on difficulty (Easy/Medium/Hard)
2. **Create a new solution file** following the naming convention
3. **Inherit from `SolutionBase`** and implement required properties
4. **Add multiple solution approaches** with different time/space complexities
5. **Create corresponding unit tests** in the `LeetCode.Tests` project

### Example Solution Template

```csharp
using LeetCode.Common;

namespace LeetCode.Easy;

/// <summary>
/// Problem XXX: Problem Name
/// Problem description goes here...
/// </summary>
public class ProblemName : SolutionBase
{
    public override int ProblemNumber => XXX;
    public override string ProblemTitle => "Problem Name";
    public override string Difficulty => "Easy"; // or "Medium" or "Hard"

    /// <summary>
    /// Approach 1 - O(n) time, O(1) space
    /// </summary>
    public ReturnType Method1(InputType input)
    {
        // Implementation here
    }

    /// <summary>
    /// Approach 2 - O(n²) time, O(n) space
    /// </summary>
    public ReturnType Method2(InputType input)
    {
        // Alternative implementation
    }
}
```

### Running Solutions

```bash
# Run easy problems
dotnet run --project LeetCode.Easy

# Run medium problems
dotnet run --project LeetCode.Medium

# Run hard problems
dotnet run --project LeetCode.Hard

# Run all tests
dotnet test

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Building the Solution

```bash
# Restore dependencies
dotnet restore

# Build all projects
dotnet build

# Clean and rebuild
dotnet clean && dotnet build
```

## Common Data Structures

The `LeetCode.Common` project provides commonly used data structures:

- **`ListNode`**: For linked list problems
- **`TreeNode`**: For binary tree problems
- **`SolutionBase`**: Base class for consistent solution structure
- **`SolutionRunner`**: Utilities for measuring performance and running examples

## Testing

All solutions include comprehensive unit tests using xUnit. Tests cover:

- ✅ Happy path scenarios
- ✅ Edge cases (empty inputs, null values)
- ✅ Performance characteristics
- ✅ Exception handling

## Contributing

When adding new problems:

1. Follow the established naming conventions
2. Include multiple solution approaches when possible
3. Add comprehensive unit tests
4. Document time and space complexity
5. Include problem description and examples

## Resources

- [LeetCode Website](https://leetcode.com/)
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [xUnit Testing Framework](https://xunit.net/)
