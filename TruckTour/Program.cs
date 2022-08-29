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
            int pumps = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int min = 0;
            int minPosition = 0;
            for (int i = 0; i < pumps; i++)
            {
                var input = Console.ReadLine().Split();
                if(i == 0)
                {
                    min = int.Parse(input[1]);
                }
                stack.Push(int.Parse(input[1]));
                if(stack.Peek() < min)
                {
                    minPosition = i;
                    min = int.Parse(input[1]);
                }
            }
            Console.WriteLine(minPosition);
        }
    }
}