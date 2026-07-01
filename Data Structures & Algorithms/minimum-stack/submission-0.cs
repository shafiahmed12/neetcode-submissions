public class MinStack {
    private Stack<int> minStack;
    private Stack<int> minValue; 
    public MinStack() {
        this.minStack = new Stack<int>();
        this.minValue = new Stack<int>();
    }
    
    public void Push(int val) {
        if(this.minStack.Count == 0)
        {
            this.minValue.Push(Math.Min(int.MaxValue, val));
        } else {
            this.minValue.Push(Math.Min(val, this.minValue.Peek()));
        }
        this.minStack.Push(val);
    }
    
    public void Pop() {
        this.minStack.Pop();
        this.minValue.Pop();

    }
    
    public int Top() {
        return this.minStack.Peek();
    }
    
    public int GetMin() {
        return this.minValue.Peek();
    }
}
