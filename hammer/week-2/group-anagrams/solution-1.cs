public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var answer = new Dictionary<string, List<string>>();

        foreach (var value in strs)
        {
            char[] valueCharArray = value.ToArray();
            Array.Sort(valueCharArray);
            var sortedValue = new string(valueCharArray);
            
            if (!answer.ContainsKey(sortedValue))
            {
                answer[sortedValue] = new List<string>();
            }

            answer[sortedValue].Add(value);
        }

        return answer.Values.ToList();
    }
}
