public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left=0;
        int maxfrq=0;
        int length=0;
        Dictionary<char,int> d= new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!d.ContainsKey(s[i]))
            {
                d.Add(s[i],0);
            }

            d[s[i]]++;

            maxfrq= Math.Max(maxfrq,d[s[i]]);

            if((i-left+1)-maxfrq>k)
            {
                d[s[left]]--;
                left++;
            }

            length= Math.Max(length,i - left + 1);
        }

        return length;
    }
}
