public class Solution {
    public int MajorityElement(int[] nums) {
        var map = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if(map.ContainsKey(num))
            {
                map[num]++;
            } else {
                map.Add(num, 1);
            }
        }

        foreach(var kv in map)
        {
            if(kv.Value > nums.Length/2)
            {
                return kv.Key;
            }
        }
        return -1;
    }
}