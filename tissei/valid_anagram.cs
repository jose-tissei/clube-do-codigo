public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        sd = ToDict(s);
        td = ToDict(t);
        
        foreach(var key in sd.Keys)
        {
            var value;
            var exists = td.TryGetValue(key, out value);
            if(!exists || sd[key] != value) return false;
        }

        return true;
    }

    public IDictionary<char, int> ToDict(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if(dict.ContainsKey(c)){
                dict[c]++;
            } else {
                dict[c] = 1;
            }
        }
        return dict;
    }
}
