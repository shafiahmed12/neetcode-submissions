public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        var longest = 0;
        foreach(var num in nums)
        {
            set.Add(num);
        }

        foreach(var value in set)
        {
            if(!set.Contains(value-1))
            {
                var length = 1;
                while(set.Contains(value + length))
                {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
