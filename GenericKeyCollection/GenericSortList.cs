using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericSortList
    {
        public void MakeASortedList()
        {
            SortedList<string, int> position = new SortedList<string, int>();

            position.Add("Dad", 1);
            position.Add("Mom", 2);
            position.Add("Drew", 3);
            position.Add("Lizz", 4);
            position.Add("GMoney", 5);

            Console.WriteLine("Sorted List array:");

            foreach (KeyValuePair<string, int> element in position)
            {
                string name = element.Key;
                int spot = element.Value;
                Console.Write($"Name: {name}\tPosition in famliy: {spot}\n");
            }
            Console.WriteLine();
        }
    }
}
