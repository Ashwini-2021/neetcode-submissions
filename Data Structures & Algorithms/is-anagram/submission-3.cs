public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> ana= new Dictionary<char,int>();

        if(s.Length!=t.Length)
            return false;

        foreach(char c in s)
        {
            if(ana.ContainsKey(c))
            {
                ana[c]=++ana[c];
            }
            else
            {
                ana.Add(c,1);
            }
        }

        foreach(char c in t)
        {
            if(ana.ContainsKey(c))
            {
                ana[c]=--ana[c];
                if(ana[c]==0)
                    ana.Remove(c);
            }
        }

        return ana.Count==0;
    }
}
