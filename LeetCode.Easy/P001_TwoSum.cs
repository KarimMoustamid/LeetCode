using LeetCode.Common;

namespace LeetCode.Easy;

/// <summary>
/// Problem 1: Two Sum
/// Given an array of integers nums and an integer target, 
/// return indices of the two numbers such that they add up to target.
/// </summary>
public class TwoSum : SolutionBase
{
    public override int ProblemNumber => 1;
    public override string ProblemTitle => "Two Sum";
    public override string Difficulty => "Easy";

    /// <summary>
    /// Hash map approach - O(n) time, O(n) space
    /// </summary>
    public int[] TwoSumHashMap(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        
        throw new ArgumentException("No two sum solution");
    }

    /// <summary>
    /// Brute force approach - O(n²) time, O(1) space
    /// </summary>
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        
        throw new ArgumentException("No two sum solution");
    }
}