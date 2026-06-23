public class Solution {

    public string Encode(IList<string> strs) {
        var encodedString = "";
        foreach(string s in strs)
        {
            encodedString = $"{encodedString}{s.Length}#{s}";
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        var i = 0;
        while(i < s.Length)
        {
            var j = i;
            while(s[j] != '#')
            {
                j++;
            }

            var length = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j+1, length));
            i = j + 1 + length;
        }
        return result;
   }
}
