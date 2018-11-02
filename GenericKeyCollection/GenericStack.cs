using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericStack
    {
        public void MakeAStack()
        {
            //A Man A Pan A Panama
            Stack<char> panama = new Stack<char>();

            //Insert into stack
            Console.WriteLine("Pushing palindrome into stack");
            foreach(char chars in new char[] { 'A', 'M', 'a', 'n', 'A', 'P', 'a',
                                               'n', 'A', 'P', 'a', 'n', 'a', 'm', 'a'})
            {
                panama.Push(chars);
                Console.Write(chars);
            }
            Console.WriteLine();

            Console.WriteLine("Popping from the stack");
            while(panama.Count > 0)
            {
                char chars = panama.Pop();
                Console.Write(chars);
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
