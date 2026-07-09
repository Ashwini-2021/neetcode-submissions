public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count =0;
        for(int n=0;n<nums.Length;n++)
        {
            if(nums[n]!=val)
            {
                nums[count]=nums[n];
                count++;
            }
        }

        return count;
    }
}