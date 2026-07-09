public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(t=="")
            return false;

          int j=0;
        for(int i=0;i<t.Length && j<s.Length;i++)
        {
            if(t[i]==s[j])
            {
                j++;
                if(j==s.Length)
                {
                    return true;
                }
            }
        }

        if(j==s.Length)
        {
            return true;
        }

        return false;
    }
}