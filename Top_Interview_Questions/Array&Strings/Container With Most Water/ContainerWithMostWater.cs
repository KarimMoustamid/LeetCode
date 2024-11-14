namespace Top_Interview_Questions.Array_Strings.Container_With_Most_Water
{
    public class ContainerWithMostWater
    {

        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right) {
                int containerHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int area = containerHeight * width;
                maxArea = Math.Max(maxArea, area);

                // Move the pointer with the shorter line inward
                if (height[left] < height[right]) {
                    left++;
                } else {
                    right--;
                }
            }

            return maxArea;
        }
    }
}