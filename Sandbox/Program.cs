using Top_Interview_Questions.Array_Strings.Sum_II;


int n = 10;
Four_Sum_II solution = new Four_Sum_II(n);

int[] nums1 = new int[n];
int[] nums2 = new int[n];
int[] nums3 = new int[n];
int[] nums4 = new int[n];

nums1 = [1, 2]; nums2 = [-2, -1]; nums3 = [-1, 2]; nums4 = [0, 2];

Console.WriteLine(solution.FourSumCount(nums1, nums2, nums3, nums4));