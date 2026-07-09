public class Solution {
    public void ReverseString(char[] s) {
        int j=(s.Length-1);
        for(int i=0;i<s.Length/2;i++)
        {
            if(s[i]!=s[j])
            {
                char k=s[i];
                s[i]=s[j];
                s[j]=k;
            }
            j--;
        }
    }
}