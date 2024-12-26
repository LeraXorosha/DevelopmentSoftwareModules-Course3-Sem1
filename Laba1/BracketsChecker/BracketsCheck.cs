using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsChecker
{
    public static class BracketsCheck
    {
        public static bool Check(string brackets)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in brackets)
            {
                switch (c)//выражение-селектор
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;

                    case '}':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '{') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '[') return false;
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '(') return false;
                        break;
                }
            }
            return true;

        }
    }
}
