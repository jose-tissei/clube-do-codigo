//https://neetcode.io/problems/minimum-stack?list=neetcode150
public class MinStack {

    private Stack<int> mainStack;
    private Stack<int> minStack;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);

        if(minStack.Count == 0 || minStack.Peek() >= val){
            minStack.Push(val);
        }

    }
    
    public void Pop() {
        var popped = mainStack.Pop();
        if (popped == minStack.Peek()){
            minStack.Pop();
        }
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
