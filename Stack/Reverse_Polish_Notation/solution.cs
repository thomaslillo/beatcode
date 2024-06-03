public class Solution {
    public int EvalRPN(string[] tokens) {
            
        Stack<int> values = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            var current_value = tokens[i];

            // perform operation on two most recent values
            // add product to top of stack to use in next operation
            if (current_value == "-") {
                var val1 = values.Pop();
                var val2 = values.Pop();
                int product = val2 - val1;
                values.Push(product);
            }
            else if (current_value == "+") {
                var val1 = values.Pop();
                var val2 = values.Pop();
                int product = val2 + val1;
                values.Push(product);
            }  
            else if (current_value == "/") {
                var val1 = values.Pop();
                var val2 = values.Pop();
                int product = val2 / val1;
                values.Push(product);
            }  
            else if (current_value == "*") {
                var val1 = values.Pop();
                var val2 = values.Pop();
                int product = val2 * val1;
                values.Push(product);
            }  
            else 
            {
                int intval = Int32.Parse(current_value);
                values.Push(intval);
            }
        }
        int final_result = values.Pop();
        return final_result;                        
    }
}
