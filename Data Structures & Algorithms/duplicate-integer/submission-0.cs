public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> duplicate= new Dictionary<int,int>();

        foreach(int num in nums)
        {
            if(duplicate.ContainsKey(num))
            {
                return true;
            }
            else
            {
                duplicate.Add(num,1);
            }
        }

        return false;
    }
}