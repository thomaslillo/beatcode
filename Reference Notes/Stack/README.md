# Stack

A list-like data structure that can only have information added or removed from the top of the list. This makes these procedures very fast and efficient to perform. Stacks are a LIFO data structure.

Common Stack Methods

- Accessible end of the list - top
- add to a stack - push
- remove from a stack - pop
- view the top element without removing - peek
- remove all elements - clear
- get length

**Creating A Stack**

```python
class Stack():

	def __init__(self):
		self.dataStore = []

	def push(self, value):
		self.dataStore.append(value)
	
	def pop(self):
		self.dataStore.pop()

	def peek(self):
		return self.dataStore[-1]

	def.getLen():
		return len(self.dataStore)
```

# 1. Easy - Valid Parentheses

![Untitled](Stack%20f93b864d32eb4fa9b09d3f7a5bd3c154/Untitled.png)

### Best Answer

**Big O:** O(n)

Just one thing to note in this solution, use of `Stack<char>` helps to avoid unnecessary **boxing/unboxing** and improves performance (*eq. runtime*) metrics:

```csharp
public class Solution {
    public bool IsValid(string s) {
        // Get ready initial state (enforce element type)
        var k = new Stack<char>();
        // Evaluate each character for potential mismatch 
        foreach(char c in s) {
            // Push closing round bracket onto the stack
            if (c == '(') { k.Push(')'); continue; }
            // Push closing curly bracket onto the stack
            if (c == '{') { k.Push('}'); continue; }
            // Push closing square bracket onto the stack
            if (c == '[') { k.Push(']'); continue; }
            // Look out for imbalanced strings or mismatches
            if (k.Count == 0 || c != k.Pop()) return false;
        }
        // Empty stack means string is valid and invalid otherwise
        return k.Count == 0;
    }
}
```
