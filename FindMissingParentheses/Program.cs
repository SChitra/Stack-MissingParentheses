using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingParentheses
{
    class Program
    {
        //Find missing paren in a given expression
        static void Main(string[] args)
        {
            string exp = "((4+5)))";
            //string exp = "((4+5)+(4*2";
            //string exp = "((5*4)+ (4*5 - (10/2";
            //string exp = "(())))";
            //string exp = string.Empty;
            
            Console.WriteLine("Number of missing parentheses in a given expression is {0} ", MissingParen(exp));
                
            
        }


        public static int MissingParen(string exp)
        {
            //int count = 0;
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i <= exp.Length-1; i++)
            {

                if (exp[i] == '(' || exp[i] == ')')
                {
                    //check of stack is empty - this condition is needed when there is extra closing parentheses eg.()) when there is no open paren
                    if (stack.Count == 0)
                        stack.Push(exp[i]);
                    else
                    {
                        if (stack.Peek() != exp[i])
                           // if top of stack is opening symbol and the current symbol is closing then pop from stack.
                            stack.Pop();
                        else
                            stack.Push(exp[i]);
                    }


                }
            }

            return stack.Count;

            //else if(exp[i] == ')')
            //{
            /*if top of stack is not equal to closing symbol pop from stack 
            that is if top of stack is opening symbol and the current symbol is closing then pop from stack.*/
            //if (stack.Peek() != exp[i])
            //    stack.Pop();
            //else
            //stack.Push(exp[i]);
            //else if (stack == null)
            // stack.Push(exp[i]);
            //else if (stack.Peek() == 0)
            //stack.Push(exp[i]);

            //}
            //count++;

            //return the missing parentheses from the stack.

        }

    }
}
