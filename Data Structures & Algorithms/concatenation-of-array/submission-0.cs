public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] arr = new int[nums.Length*2];

        for(int i=0,j=(arr.Length/2);i<arr.Length/2 ;i++,j++)
        {
            arr[i]=nums[i];
            arr[j]=nums[i];
        }

        return arr;
    }
}