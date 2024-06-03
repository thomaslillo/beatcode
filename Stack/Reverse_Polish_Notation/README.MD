# Reverse Polish Notation

## My Solution

Big O: O(n)

My idea was fundamentally the same as the fastest versions but they took advantage of more performant features of C#

## Best Solution

```cs

 public int EvalRPN(string[] tokens) {
    Stack<int> stack = new Stack<int>();
    foreach (string current in tokens)
    {
      int left,right,result;
      switch(current)
      {
      case "+":
          right = stack.Pop();
          left = stack.Pop();
          result = left + right;
          stack.Push(result);
          break;
      case "-":
          right = stack.Pop();
          left = stack.Pop();
          result = left - right;
          stack.Push(result);
          break;
      case "/":
          right = stack.Pop();
          left = stack.Pop();
          result = left / right;
          stack.Push(result);
          break;
      case "*":
          right = stack.Pop();
          left = stack.Pop();
          result = left * right;
          stack.Push(result);
          break;
      default:
          int number = int.Parse(current);
          stack.Push(number);
          break;
      }
  }

  return stack.Peek();
}

```

Another good one that was really fast

```cs
public int EvalRPN(string[] tokens) {
    var stack = new Stack<int>();
    foreach(var str in tokens){
        if(int.TryParse(str, out var num)){
            stack.Push(num);
            continue;
        }

        var num2 = stack.Pop();
        var num1 = stack.Pop();

        if(str == "+") num1 += num2;
        else if(str == "-") num1 -= num2;
        else if(str == "*") num1 *= num2;
        else if(str == "/") num1 /= num2;

        stack.Push(num1);
    }

    return stack.Pop();
}

```

