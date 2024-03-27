using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ParanthesesBallancing
    {
         

        private List<char> ConvertStringToCharList(string input)
        {
            List<char> charList = new List<char>();

            foreach (char c in input)
            {
                charList.Add(c);
            }

            return charList;
        }

        public bool CheckParanthesesBalancing(string input)
        {
            List<char> chars = ConvertStringToCharList(input);
            Stack<char> stack = new Stack<char>();
            foreach (char c in chars)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false; // There's a closing parenthesis without a corresponding opening parenthesis
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0; // True if stack is empty, False otherwise
        }
    }
}
