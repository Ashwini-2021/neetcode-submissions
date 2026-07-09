public class Solution {
    public bool IsPalindrome(string s) {
        string str1="";
        string str="";
        for(int i=0, j=s.Length-1;i<s.Length && j>=0;i++,j--)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                str1+=s[i];
            }

            if(char.IsLetterOrDigit(s[j]))
            {
                str+=s[j];
            }
        }
        return str1.ToLower()==str.ToLower();
    }
}
