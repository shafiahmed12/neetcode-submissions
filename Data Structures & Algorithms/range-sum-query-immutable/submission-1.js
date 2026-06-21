class NumArray {
    /**
     * @param {number[]} nums
     */

    constructor(nums) {
        this.sumArray = []
        let sum = 0

        for(let num of nums)
        {
            sum = sum + num
            this.sumArray.push(sum);
        }

    }

    /**
     * @param {number} left
     * @param {number} right
     * @return {number}
     */
    sumRange(left, right) {
        let leftSum = left === 0 ? 0 : this.sumArray[left-1];
        let rightSum = this.sumArray[right]
        return rightSum - leftSum
    }
}
