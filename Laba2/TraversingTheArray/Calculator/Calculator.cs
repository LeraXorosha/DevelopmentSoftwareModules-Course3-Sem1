using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static double Calculate(string symbols)
        {
            Stack<double> operands = new Stack<double>();
            Stack<char> operators = new Stack<char>();
            bool isLastWasNumber = false;

            for (int i = 0; i < symbols.Length; i++)
            {
                char s = symbols[i];

                if (s == ' ')
                    continue;

                if (s >= '0' && s <= '9')
                {
                    string num = "";

                    while (i < symbols.Length && (symbols[i] >= '0' && symbols[i] <= '9' || symbols[i] == '.'))
                    {
                        num += symbols[i];
                        i++;
                    }

                    i--;

                    double value = double.Parse(num);
                    operands.Push(value);
                    isLastWasNumber = true;
                }
                else if (s == '(')
                {
                    operators.Push(s);
                    isLastWasNumber = false;
                }
                else if (s == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        DoMath(isLastWasNumber, operands, operators);
                        isLastWasNumber = true;
                    }

                    operators.Pop();
                }
                else if (s == '+' || s == '-' || s == '*' || s == '/')
                {
                    if (s == '-' && !isLastWasNumber) { s = '~'; }
                    while (operators.Count > 0 && HasPrecedence(s, operators.Peek()))
                    {
                        DoMath(isLastWasNumber, operands, operators);
                    }

                    operators.Push(s);
                    isLastWasNumber = false;
                }
            }

            while (operators.Count > 0)
            {
                DoMath(isLastWasNumber, operands, operators);
            }

            return operands.Pop();

            static void DoMath(bool isLastWasNumber, Stack< double> operands, Stack<char> operators)
            {
                char op = operators.Pop();
                double val2 = 0;
                double val1 = 0;
                if (op == '~')
                {
                    val1 = operands.Pop();
                }
                else
                {
                    val2 = operands.Pop();
                    val1 = operands.Pop();
                }

                double result = ApplyOperator(val1, val2, op);
                operands.Push(result);
                isLastWasNumber = true;
            }
        }

        public static bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;

            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            if ((op1 == '~'))
            {
                return false;
            }

            return true;
        }

        public static double ApplyOperator(double val1, double val2, char op)
        {
            switch (op)
            {
                case '~':
                    return -val1;
                case '+':
                    return val1 + val2;
                case '-':
                    return val1 - val2;
                case '*':
                    return val1 * val2;
                case '/':
                    if (val2 == 0) throw new DivideByZeroException();
                    return val1 / val2;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}


