public class Solution {
  public int CalPoints(string[] operations) {
    var stack = new Stack<int>();
    var score = 0;

    foreach (var operation in operations) {
      if (int.TryParse(operation, out var value)) {
        stack.Push(value);
      } else if (operation == "+") {
        if (stack.Count < 2) {
          var sum = 0 + stack.Peek();
          stack.Push(sum);
        } else {
          var last = stack.Pop();
          var sum = stack.Peek() + last;
          stack.Push(last);
          stack.Push(sum);
        }
      } else if (operation == "D") {
        var sum = stack.Count == 0 ? 0 : 2 * stack.Peek();
        stack.Push(sum);
      } else if (operation == "C") {
        stack.Pop();
      }
    }

    while (stack.Count > 0) {
      score += stack.Pop();
    }

    return score;
  }
}