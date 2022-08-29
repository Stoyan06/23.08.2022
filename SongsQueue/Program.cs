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
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while(songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }

                if (command[0] == "Add")
                {
                    if(command.Length > 1)
                    {
                        for (int i = 2; i <= command.Length - 1; i++)
                        {
                            command[1] += " " + command[i];
                        }
                    }

                    if (songs.Contains(command[1]))
                    {
                        Console.WriteLine("{0} is already contained!", command[1]);
                    }
                    else
                    {
                        songs.Enqueue(command[1]);
                    }
                }

                if (command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}