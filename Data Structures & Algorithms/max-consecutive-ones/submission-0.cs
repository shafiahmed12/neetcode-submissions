public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxLen = 0;
        var currentLen = 0;
        int i = 0;

        while(i < nums.Length)
        {
            if(nums[i] == 1)
            {
                currentLen++;
                i++;
            }
            else if(nums[i] == 0)
            {
                if(currentLen > maxLen)
                {
                    maxLen = currentLen;
                }
                currentLen = 0;
                i++;
            }
        }
        if(currentLen > maxLen)
        {
            return currentLen;
        }
        return maxLen;
    }
}