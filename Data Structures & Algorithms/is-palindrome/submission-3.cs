public class Solution {
    public bool IsPalindrome(string s) {
        var start = 0;
        var end = s.Length - 1;

        while(start <= end)
        {
            if(!IsLetterOrNumber(s[start]))
            {
                start++;
                continue;
            }

            if(!IsLetterOrNumber(s[end]))
            {
                end--;
                continue;
            }

            Console.WriteLine($"{s[start]}, {s[end]}");
            if(char.ToLower(s[start]) != char.ToLower(s[end]))
            {
                Console.WriteLine($"{s[start]}");
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    public bool IsLetterOrNumber(char c)
    {
        return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9';
    }
}
