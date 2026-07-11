public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int left = 2;

        for(int right = 2; right < nums.Length; right++)
        {
            if(nums[left-2] != nums[right]){
                nums[left] = nums[right];
                left++;
            }
        }

        return left;
    }
}