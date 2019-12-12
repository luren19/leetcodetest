public class MinStack {

    private Stack<int> st = new Stack<int>();
    //private int min;
    private Stack<int> minst = new Stack<int>();
    
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        st.Push(x);
        if(minst.Count == 0 || minst.Peek() > x){
            minst.Push(x);
        }
        else{
            minst.Push(minst.Peek());
        }
    }
    
    public void Pop() {
        if(st.Count > 0){
            minst.Pop();
            st.Pop();
        }
    }
    
    public int Top() {
        //if(st.Count > 0){
            return st.Peek();
        //}
        //return null;
    }
    
    public int GetMin() {
        //if(st.Count > 0){
            return minst.Peek();
        //}
        //return null;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
