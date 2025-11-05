namespace LeetCode.Easy
{
    using Common;

    public class RemoveDuplicatesFromSortedArray : SolutionBase
    {
        public override int ProblemNumber => 1;
        public override string ProblemTitle => "Remove Duplicates from Sorted Array";
        public override string Difficulty => "Easy";
        public override string ProblemUrl => "https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/";

        public int RemoveDuplicates(int[] nums)
        {
            // Fast-path: if the input is null or empty, there are no elements to keep.
            if (nums == null || nums.Length == 0) return 0;

            // 'write' is the index where the next unique element should be written.
            // Initialize to 1 because the first element (index 0) is always kept
            // (there is nothing before it to compare to).
            int write = 1;

            // Scan the array with 'read' from 1…n-1 and copy a value to 'write'
            // only when it differs from the previous value (nums[read - 1]).
            // Because the array is sorted, equal values are adjacent, so this
            // condition detects the first occurrence of each distinct value.
            for (int read = 1; read < nums.Length; read++)
            {
                // If the current value is different from the previous, it's the next unique
                // value; move it to the 'write' position and increment 'write'.
                if (nums[read] != nums[read - 1])
                {
                    nums[write++] = nums[read];
                }
                // If it's equal to the previous, do nothing: we effectively skip
                // the duplicate by not advancing 'write'. The read pointer keeps
                // scanning to find the next new value.
            }

            // 'write' now holds the count of unique elements and is the new length.
            return write;
        }
    }
}