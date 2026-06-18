class Solution {
    /**
     * @param {number[]} arr
     * @return {number[]}
     */
    replaceElements(arr) {
        let max = -1;
        let ans = new Array(arr.length);
        for(let i = arr.length-1; i >= 0; i--){
            ans[i] = max;
            max = Math.max(max, arr[i]);
        }
        return ans;
    }
}
