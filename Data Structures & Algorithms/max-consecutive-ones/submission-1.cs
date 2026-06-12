public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxLen = 0;
        int currentLen = 0;

        foreach(int num in nums)
        {
            if(num == 0)
            {
                maxLen = Math.Max(maxLen, currentLen);
                currentLen = 0;
            }
            else {
                currentLen++;
            }
        }

        return Math.Max(currentLen, maxLen);
    }
}