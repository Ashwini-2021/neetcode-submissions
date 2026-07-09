public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> n=new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(n.ContainsKey(num))
            {
                n[num]++;
            }
            else
            {
                n.Add(num, 1);
            }
        }

         return n
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();
    }
}
