public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var len = 2 * nums.Length;
        var ans = new int[len];
        var i = 0;
        while (i < len) {
            if (i < nums.Length) {
                ans[i] = nums[i];
            } else {
                ans[i] = nums[i- nums.Length];
            }
            i++;
        }
        return ans;
    }
}