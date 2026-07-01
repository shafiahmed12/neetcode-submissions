public class Solution {
  public List<int> MajorityElement(int[] nums) {
    var map = new Dictionary<int, int>();
    foreach (var num in nums) {
      if (map.ContainsKey(num)) {
        map[num]++;
      } else {
        map.Add(num, 1);
      }
    }

    var result = new List<int>();
    foreach (var kv in map) {
      if (kv.Value > nums.Length / 3) {
        result.Add(kv.Key);
      }
    }

    return result;
  }
}