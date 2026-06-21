public class Solution {
    public int PivotIndex(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];
        var sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
            prefix[i] = sum;
        }
        
        sum = 0;
        for(int i = nums.Length-1; i >=0; i--)
        {
            sum = sum+nums[i];
            postfix[i] = sum;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(prefix[i] == postfix[i])
            {
                return i;
            }
        }

        return -1;

    }
}