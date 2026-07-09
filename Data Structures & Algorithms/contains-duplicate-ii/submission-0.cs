public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        List<int> l=new List<int>();

        for(int i=0,j=k;i<nums.Length;i++,j++)
        {
            if(l.Contains(nums[i]))
            {
                return true;
            }

            l.Add(nums[i]);

            if(l.Count>k)
                l.RemoveAt(0);
        }
        return false;
    }
}