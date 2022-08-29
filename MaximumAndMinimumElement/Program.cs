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
            Stack<int> stack = new Stack<int>();
            int repeats = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeats; i++)
            {
                var command = Console.ReadLine().Split();
                if (int.Parse(command[0]) == 1)
                {
                    stack.Push(int.Parse(command[1]));
                }
                if (int.Parse(command[0]) == 2 && stack.Count > 0)
                {
                        stack.Pop();
                }

                if (int.Parse(command[0]) == 3 && stack.Count > 0)
                {
                     Console.WriteLine(stack.Max());
                }

                if (int.Parse(command[0]) == 4 && stack.Count > 0)
                {
                 Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}