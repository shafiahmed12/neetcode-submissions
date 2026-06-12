class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    findMaxConsecutiveOnes(nums) {
        let res = 0
        let currentLength = 0;
        for(const num of nums)
        {
            if(num === 0)
            {
                res = Math.max(res, currentLength)
                currentLength = 0
            } else {
                currentLength++;
            }
        }

        return Math.max(res, currentLength)

    }
}
