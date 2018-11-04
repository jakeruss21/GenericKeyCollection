using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericDictionary
    {
        public void MakeADictionary()
        {
            Dictionary<string, int> days = new Dictionary<string, int>();

            days.Add("Sunday", 1);
            days.Add("Monday", 2);
            days.Add("Tuesday", 3);

            days["Wednesday"] = 4;
            days["Thursday"] = 5;

            days.Add("Friday", 6);
            days.Add("Saturday", 7);

            Console.WriteLine("Generic Dictionary Key");

            foreach(KeyValuePair<string, int> dictionary in days)
            {
                string name = dictionary.Key;
                int day = dictionary.Value;
                Console.WriteLine($"Day Name: {name}\tDay number: {day}");
            }

            Console.WriteLine();
        }
    }
}
