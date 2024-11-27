namespace Top_Interview_Questions.Easy.Intersection_of_Two_Arrays_II
{
    using System.Runtime.InteropServices.JavaScript;
    using Helpers;

    public static class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            // Dictionary to store frequency of elements in nums1
            Dictionary<int, int> counts = new Dictionary<int, int>();

            Log.LogMessage("Count frequencies of elements in nums1");
            foreach (int num in nums1)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }
            Log.LogDictionary(counts);

            Log.LogMessage("List to store the intersection result");
            List<int> intersection = new List<int>();

            // Find matches in nums2
            foreach (int num in nums2)
            {
                if (counts.ContainsKey(num) && counts[num] > 0)
                {
                    intersection.Add(num); // Add to result
                    counts[num]--; // Decrement count in dictionary
                }
            }
            Log.LogDictionary(counts);


            Log.LogMessage("Convert the result list to an array");
            Log.Array(intersection.ToArray());

            return intersection.ToArray();
        }

    }
}