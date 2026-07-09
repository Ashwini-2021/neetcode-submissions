public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length > t.Length){
            return false;
        }
        
        int j=0,i=0,sLength =s.Length,tLength=t.Length;
        
        for(;i<tLength && j<sLength;i++)
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