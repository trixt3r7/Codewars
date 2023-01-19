namespace CodeWars.LevelFive;

public class Parentheses
{
  public static bool ValidParentheses(string input)
  {
    int parentheses = 0;
    foreach (char c in input)
    {
      if (c == '(')
      {
        parentheses++;
      }
      else if (c == ')')
      {
        parentheses--;

        if (parentheses < 0)
        {
          return false;
        }
      }
    }

    return parentheses == 0;
  }
  public static bool ValidParenthesesV2(string input)
  {
    input = string.Concat(input.Where(x => "()".Contains(x)));
    while (input.Contains("()"))
    {
      input = input.Replace("()", "");
    }

    return !input.Any();
  }
  public static bool ValidParenthesesV1(string input)
  {
    Stack<char> stack = new Stack<char>();
    
    foreach (char c in input)
    {
      if (!"()".Contains(c)) 
      {
        continue;
      }
      if (c == ')')
      {
        if (stack.Count > 0 && stack.Peek() == '(')
        {
          stack.Pop();
        }
        else
        {
          return false;
        }
      }
      else
      {
        stack.Push(c);
      }
    }
    return stack.Count > 0 ? false : true;
  }
}
