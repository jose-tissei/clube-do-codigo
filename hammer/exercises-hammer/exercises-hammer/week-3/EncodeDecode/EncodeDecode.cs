namespace exercises_hammer.week_3.EncodeDecode;

public class SolutionEncodeDecode {

    public string Encode(IList<string> strs)
    {
        const char separator = 'ô';
        const string empty = "ã";

        var strs2 = strs.Select(s => s == "" ? empty : s);
        return string.Join(separator, strs2);
    }

    public List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return new List<string>();
        }
        var answer = s.Split('ô').ToList();

        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i] == "ã")
            {
                answer[i] = "";
            }
        }
        return answer;
    }
}