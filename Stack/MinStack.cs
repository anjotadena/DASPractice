namespace DSAPractice.Stack;

public class MinStack : Problem, ISolution
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public string Title => "Minimum Stack";

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        // identify minimum
        int min = Math.Min(val, minStack.Count != 0 ? minStack.Peek() : val);
        minStack.Push(min);
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }

    public string Answer()
    {
        var stack = new MinStack();

        // ["MinStack","push","push","push","getMin","pop","top","getMin"]
        // [[],[-2],[0],[-3],[],[],[],[]]
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);

        var min = stack.GetMin();
        stack.Pop();
        var top = stack.Top();

        min = stack.GetMin();

        return $"Min. value for [[[],[-2],[0],[-3],[],[],[],[]]] | [\"MinStack\",\"push\",\"push\",\"push\",\"getMin\",\"pop\",\"top\",\"getMin\"]: {min}";
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
