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
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int counter = 1;
            while(clothes.Count != 0)
            {
                if(currentSum + clothes.Peek() <= capacity)
                {
                    currentSum += clothes.Peek();
                    clothes.Pop();
                    continue;
                }

                if (currentSum + clothes.Peek() > capacity)
                {
                    currentSum = 0;
                    counter++;
                    currentSum += clothes.Peek();
                    clothes.Pop();
                }
            }
            Console.WriteLine(counter);
        }
    }
}