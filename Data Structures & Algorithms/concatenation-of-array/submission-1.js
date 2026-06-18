class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    getConcatenation(nums) {
        let len = 2 * nums.length;
        let i = 0;
        let ans = new Array(len);
        while(i < len)
        {
            if(i < nums.length){
                ans[i] = nums[i];
            } else {
                ans[i] = nums[i - nums.length];
            }
            i++;
        }

        return ans;
    }
}
