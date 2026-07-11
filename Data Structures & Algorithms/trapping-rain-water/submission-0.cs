public class Solution {
  public int Trap(int[] height) {
    var maxPrefix = new int[height.Length];
    var maxPostfix = new int[height.Length];
    var result = 0;
    for (int i = 0; i < height.Length; i++) {
      if (i == 0) {
        maxPrefix[i] = Math.Max(0, height[i]);
      } else {
        maxPrefix[i] = Math.Max(maxPrefix[i - 1], height[i]);
      }
    }

    for (int i = height.Length - 1; i >= 0; i--) {
      if (i == height.Length - 1) {
        maxPostfix[i] = Math.Max(0, height[i]);
      } else {
        maxPostfix[i] = Math.Max(maxPostfix[i + 1], height[i]);
      }
    }

    var stack = new Stack<int>();

    for (int i = 0; i < height.Length; i++) {
      var trappedWater = Math.Min(maxPrefix[i], maxPostfix[i]) - height[i];
      stack.Push(trappedWater);
    }

    while (stack.Count > 0) {
      result += stack.Pop();
    }

    return result;
  }
}
