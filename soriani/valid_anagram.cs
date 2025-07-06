public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) 
        {
            return false;
        }

        var dic = new Dictionary<char,int>();
        for (int i=0; i< s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]] += 1;
            }
            else
            {
                dic.Add(s[i],1);
            }
            if (dic.ContainsKey(t[i]))
            {
                dic[t[i]] -= 1;
            }
            else
            {
                dic.Add(t[i], -1);
            }
        }
        return dic.Values.All(v => v == 0);
    }
}
