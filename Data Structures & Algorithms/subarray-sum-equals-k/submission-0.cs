public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0, currSum = 0;
        var prefixSums = new Dictionary<int, int>();
        prefixSums[0] = 1;

        foreach(int num in nums)
        {
            currSum += num;
            int diff = currSum - k;

            if(prefixSums.ContainsKey(diff))
            {
                count += prefixSums[diff];
            }

            if(!prefixSums.ContainsKey(currSum))
            {
                prefixSums[currSum] = 0;
            }
            prefixSums[currSum]++;
        }

        return count;
    }
}