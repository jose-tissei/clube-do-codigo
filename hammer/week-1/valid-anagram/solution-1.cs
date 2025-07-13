public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        char[] sortedS = s.ToArray();
        char[] sortedT = t.ToArray();
        Array.Sort(sortedS);
        Array.Sort(sortedT);

        for(int i = 0; i < sortedS.Count(); i++)
        {
            if (sortedS[i] != sortedT[i])
            {
                return false;
            }
        }
        return true;
    }
}
