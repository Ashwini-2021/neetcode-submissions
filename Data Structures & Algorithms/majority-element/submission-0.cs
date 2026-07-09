public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> count=new Dictionary<int,int>();

        foreach(int n in nums)
        {
            if(count.ContainsKey(n))
            {
                count[n]++;
            }
            else
            {
                count.Add(n,1);
            }
        }

        return count.Where(x =>( x.Value > (nums.Length/2))).Select(x => x.Key).FirstOrDefault();
    }
}