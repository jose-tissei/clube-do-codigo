public class Solution
{
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var str in strs)
        {
            sb.Append(str.Length).Append('#').Append(str);
        }

        return sb.ToString();
    }//6#Victor4#Hugo7#Soriani

    public List<string> Decode(string s)
    {
        var result = new List<string>();

        var pattern = @"(\d+)#";
        var regex = new Regex(pattern);
        int index = 0;

        while (index < s.Length)
        {
            var match = regex.Match(s, index);
            if (!match.Success)
                break;

            var length = int.Parse(match.Groups[1].Value);
            int start = match.Index + match.Length;

            string str = s.Substring(start, length);
            result.Add(str);

            index = start + length;
        }

        return result;
    }
}
