public class Solution {
  public List<List<int>> ThreeSum(int[] nums) {
    var result = new List<List<int>>();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++) {
      if (nums[i] > 0)
        break;

      if (i > 0 && nums[i] == nums[i - 1])
        continue;

      int j = i + 1;
      int k = nums.Length - 1;

      while (j < k) {
        var sum = nums[i] + nums[j] + nums[k];

        if (sum > 0) {
          k--;
        } else if (sum < 0) {
          j++;
        } else {
          result.Add(new List<int> { nums[i], nums[j], nums[k] });
          j++;
          k--;
          while (j < k && nums[j] == nums[j - 1]) {
            j++;
          }
        }
      }
    }

    return result;
  }
}
