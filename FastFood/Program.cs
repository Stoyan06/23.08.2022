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
            int availableFood = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int max = queue.Max();
            int repeats = queue.Count();

            while(queue.Count != 0)
            {
                int currentOrder = queue.Peek();

                if(currentOrder <= availableFood)
                {
                    availableFood -= currentOrder;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(max);
                    Console.WriteLine("Orders left: " + String.Join(" ", queue));
                    return;
                }
            }
                Console.WriteLine(max);
                Console.WriteLine("Orders complete");
        }
    }
}