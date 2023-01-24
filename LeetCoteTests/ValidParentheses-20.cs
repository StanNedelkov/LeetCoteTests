using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoteTests
{
    public class ValidParentheses_20
    {
        
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var bracket in s)
            {
                if (bracket == ')' ||
                    bracket == ']' ||
                    bracket == '}')
                {
                    if (stack.Count <= 0)
                    {
                        return false;
                    }

                    char current = stack.Peek();

                    if (current == '(' && bracket ==')' ||
                        current == '[' && bracket == ']' ||
                        current == '{' && bracket == '}') 
                    {
                        stack.Pop();
                        continue;
                    }

                    return false;
                }

                stack.Push(bracket);
            }

            return stack.Count() == 0;
        }
    }
}
