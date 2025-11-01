# LeetCode Problem Template

Use this template when creating new LeetCode solution files:

```csharp
using LeetCode.Common;

namespace LeetCode.[Difficulty]; // Easy, Medium, or Hard

/// <summary>
/// Problem XXX: [Problem Title]
///
/// [Problem Description]
///
/// Example:
/// Input: [example input]
/// Output: [example output]
/// Explanation: [explanation]
///
/// Constraints:
/// - [constraint 1]
/// - [constraint 2]
/// </summary>
public class [ProblemName] : SolutionBase
{
    public override int ProblemNumber => XXX;
    public override string ProblemTitle => "[Problem Title]";
    public override string Difficulty => "[Easy/Medium/Hard]";

    /// <summary>
    /// Approach 1: [Approach Name]
    /// Time Complexity: O(?)
    /// Space Complexity: O(?)
    /// </summary>
    public [ReturnType] Method1([ParameterType] parameter)
    {
        // Implementation here
        throw new NotImplementedException();
    }

    /// <summary>
    /// Approach 2: [Alternative Approach Name]
    /// Time Complexity: O(?)
    /// Space Complexity: O(?)
    /// </summary>
    public [ReturnType] Method2([ParameterType] parameter)
    {
        // Alternative implementation
        throw new NotImplementedException();
    }
}
```

## Test Template

```csharp
using Xunit;
using LeetCode.[Difficulty];

namespace LeetCode.Tests.[Difficulty];

public class [ProblemName]Tests
{
    private readonly [ProblemName] _solution = new();

    [Theory]
    [InlineData([test case 1])]
    [InlineData([test case 2])]
    [InlineData([test case 3])]
    public void Method1_ShouldReturnCorrectResult_WhenGivenValidInput([parameters], [expected])
    {
        // Act
        var result = _solution.Method1([parameters]);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Method1_ShouldThrowException_WhenGivenInvalidInput()
    {
        // Arrange
        [invalid input setup]

        // Act & Assert
        Assert.Throws<[ExceptionType]>(() => _solution.Method1([invalid input]));
    }
}
```
