public class NumArray {
  private int[] nums;
  private int[] sumArray;
  public NumArray(int[] nums) {
    this.nums = nums;
    this.sumArray = new int[nums.Length];

    var sum = 0;
    for (int i = 0; i < nums.Length; i++) {
        sum = sum + nums[i];
        sumArray[i] = sum;
    }
  }

  public int SumRange(int left, int right) {
    var leftSum = left == 0 ? 0 : sumArray[left-1];
    var rightSum = sumArray[right];
    return rightSum-leftSum;
  }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);

 [-2, -2, 1, -4, -2, -3]
 */