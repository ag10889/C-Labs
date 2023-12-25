public class Solution {
    Stack<int> stack = new Stack<int>();
    public int EvalRPN(string[] tokens) {
        foreach (string token in tokens)
        {
            if (token == "-"){
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if (token == "+")
            {   
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (token == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(token == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
       return stack.Pop();
    }
}
