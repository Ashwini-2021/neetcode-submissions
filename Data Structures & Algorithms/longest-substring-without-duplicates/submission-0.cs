public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;
        int maxLength=0;
        List<char> str= new List<char>();
        for(int i=0;i<s.Length;i++)
        {
            while(str.Contains(s[i]))
            {
                str.Remove(s[left]);
                left++;
            }
                str.Add(s[i]);
                maxLength=Math.Max(maxLength, i-left+1);
        }

        return maxLength;
    }
}
