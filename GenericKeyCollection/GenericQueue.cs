using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericQueue
    {
        public void MakeAQueue()
        {
            Queue<char> character = new Queue<char>();

            Console.WriteLine("Queue Generic List:");

            foreach(char chars in new char[] { 'a', 'b', 'c', 'd', 'E' })
            {
                character.Enqueue(chars);
                Console.Write($"\'{chars}\' is now in the queue\t");
            }
            Console.WriteLine();

            //Empty the queue
            while (character.Count > 0)
            {
                char chars = character.Dequeue();
                Console.Write($"{chars} ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
