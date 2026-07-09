public class Solution {
    public int MajorityElement(int[] nums) {
        int count=0;
        int num=0;
        foreach(int n in nums)
        {
            if(count==0)
            {
                num=n;
            }

            count=count+(num==n?1:-1);
        }
        return num;
    }
}