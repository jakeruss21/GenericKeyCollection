using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericLinkedList
    {
        public void MakeALinkedList()
        {
            LinkedList<string> lsString = new LinkedList<string>();
            foreach (string sentance in new string[]{ "I", "have", "a", "big", "nose" })
            {
                lsString.AddLast(sentance);
            }

            Console.WriteLine("LinkedList<string>:");

            foreach (var s in lsString)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
