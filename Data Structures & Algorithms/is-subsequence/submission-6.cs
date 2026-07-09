public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(t=="")
            return false;

        int j=0;
        int sLength =s.Length,tLength=t.Length;
        for(int i=0;i<tLength && j<sLength;i++)
        {
            if(t[i]==s[j])
            {
                j++;
            }
        }

        if(j==sLength)
        {
            return true;
        }

        return false;
    }
}