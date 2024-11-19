namespace Top_Interview_Questions.Array_Strings.Sum_II
{
    using System.Runtime.Serialization;

    public class Four_Sum_II
    {
        int[] nums1;
        int[] nums2;
        int[] nums3;
        int[] nums4;

        public Four_Sum_II(int n)
        {
            nums1 = new int[n];
            nums2 = new int[n];
            nums3 = new int[n];
            nums4 = new int[n];
        }

        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            var map = new Dictionary<int, int>();
            int count = 0;

            // Step 1: Calculate sums of pairs from nums1 and nums2, store in map
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int sum = nums1[i] + nums2[j];
                    if (!map.ContainsKey(sum))
                    {
                        map[sum] = 0;
                    }

                    map[sum]++;
                }
            }

            // Step 2: Calculate sums of pairs from nums3 and nums4, check in map for negation
            for (int k = 0; k < nums3.Length; k++)
            {
                for (int l = 0; l < nums4.Length; l++)
                {
                    int sum = nums3[k] + nums4[l];
                    if (map.ContainsKey(-sum))
                    {
                        count += map[-sum];
                    }
                }
            }

            return count;
        }
    }
}