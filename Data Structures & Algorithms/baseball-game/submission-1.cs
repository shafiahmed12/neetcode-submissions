public class Solution {
  public int CalPoints(string[] operations) {
    var stack = new Stack<int>();

    for (int i = 0; i < operations.Length; i++) {
      if (int.TryParse(operations[i], out var value)) {
        stack.Push(value);
      } else if (operations[i] == "+") {
        var last = stack.Pop();
        var beforeLast = stack.Pop();
        var score = last + beforeLast;
        stack.Push(beforeLast);
        stack.Push(last);
        stack.Push(score);
      } else if (operations[i] == "D") {
        var score = 2 * stack.Peek();
        stack.Push(score);
      } else if (operations[i] == "C") {
        stack.Pop();
      }
    }

    var sum = 0;
    while (stack.Count > 0) {
      sum += stack.Pop();
    }
    return sum;
  }
}