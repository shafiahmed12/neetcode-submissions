public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var max = -1;
        int[] ans = new int[arr.Length];
        for(int i = arr.Length-1; i>=0; i--)
        {
            ans[i] = max;
            max = Math.Max(max, arr[i]);
        }
        return ans;
    }
}