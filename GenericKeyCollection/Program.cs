using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList genList = new GenericList();
            GenericLinkedList lList = new GenericLinkedList();
            GenericQueue qList = new GenericQueue();
            GenericStack stackit = new GenericStack();
            GenericDictionary dictionary = new GenericDictionary();
            GenericSortList sorted = new GenericSortList();
            GenericHash hashbrowns = new GenericHash();

            genList.MakeAList();
            lList.MakeALinkedList();
            qList.MakeAQueue();
            stackit.MakeAStack();
            dictionary.MakeADictionary();
            sorted.MakeASortedList();
            hashbrowns.MakeAHash();
        }
    }
}
