using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericList
    {
        public void MakeAList()
        {
            List<int> ls = new List<int>();

            ls.Add(53);
            ls.Add(25);
            ls.Add(72);

            ls.Insert(ls.Count - 2, 35);
            ls.Add(15);

            Console.WriteLine("List<T> Generic type");
            
            foreach(var c in ls)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
