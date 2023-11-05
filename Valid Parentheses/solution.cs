public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 0)
        {
            Stack brackets = new Stack();
            for (int index = 0; index < s.Length; index++)
            {                
                char currentBracket = s[index];
                if (brackets.Count == 0)
                {
                    brackets.Push(currentBracket);
                }
                else 
                {
                    switch(currentBracket) 
                    {
                    case ')':                    
                        if(Convert.ToChar(brackets.Pop()) != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if(Convert.ToChar(brackets.Pop()) != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if(Convert.ToChar(brackets.Pop()) != '[')
                        {
                            return false;
                        }
                        break;
                    default:
                        brackets.Push(currentBracket);
                        break;
                    }
                }                                                                
            }
            // if no issues
            if (brackets.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else 
        {
            return false;
        }                
    }
}
