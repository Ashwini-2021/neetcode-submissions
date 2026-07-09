public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> num =new Dictionary<int,int>();
        for(int i=0;i<nums.Length; i++)
        {
            if(num.ContainsKey(target-nums[i]))
            {
                return new int[]{num[target-nums[i]],i};
            }

            num.Add(nums[i],i);
        }

        return new int[0];
    }
}
