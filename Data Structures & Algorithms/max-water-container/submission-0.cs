public class Solution {
    public int MaxArea(int[] heights) {
        int left =0;
        int right=heights.Length-1;
        int max=0;
        while(left<right)
        {
            int low=Math.Min(heights[left],heights[right]);
            int capacity= low*(right-left);
            if(max<capacity)
            {
                max=capacity;
            }

            if(heights[left]<heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return max;
    }
}
