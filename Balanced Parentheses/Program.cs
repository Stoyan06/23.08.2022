using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);
            for (int i = 0; i < input.Length / 2; i++)
            {
                char memory = stack.Pop();
                if (input[i] == '{')
                {
                    if(memory != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (input[i] == '(')
                {
                    if (memory != ')')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (input[i] == '[')
                {
                    if (memory != ']')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                if (input[i] == ' ')
                {
                    if (memory != ' ')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}