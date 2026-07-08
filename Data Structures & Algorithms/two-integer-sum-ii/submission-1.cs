public class Solution {
  public int[] TwoSum(int[] numbers, int target) {
    var s = 0;
    var e = numbers.Length - 1;

    while (s < e) {
      if (numbers[s] + numbers[e] > target) {
        e--;
      } else if (numbers[s] + numbers[e] < target) {
        s++;
      }

      if (numbers[s] + numbers[e] == target) {
        return new int[2] { s + 1, e + 1 };
      }
    }

    return [];
  }
}
