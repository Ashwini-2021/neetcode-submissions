public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int left=0, right=0;
        string str="";
        while(left<word1.Length || right<word2.Length)
        {
            if(left<word1.Length)
            {
                str+=word1[left];
                left++;
            }

            if(right<word2.Length)
            {
                str+=word2[right];
                right++;
            }
        }

        return str;
    }
}