using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            
             bool IsValid(string s)
            {
                s = "()[]{}";
                Stack<char> stack = new Stack<char>();
                Dictionary<char, char> dict = new Dictionary<char, char>() {
            {'(',')'},
            {'[',']'},
            {'{','}'},
        };

                foreach (var c in s)
                {
                    if (c == ')' || c == ']' || c == '}')
                    {
                        if (stack.Count > 0 && dict[stack.Peek()] != c || stack.Count == 0)
                        {
                            return false;
                        }
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }

                }
                return stack.Count == 0;

            }
        }
    }
}
