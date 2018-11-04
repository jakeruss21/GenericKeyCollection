using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKeyCollection
{
    class GenericHash
    {
        public void MakeAHash()
        {
            HashSet<string> breakfast = new HashSet<string>(new string[]
                {"Pancakes", "Burrito", "Cereal", "Omelete", "Sausage" });

            HashSet<string> dinner = new HashSet<string>(new string[]
                {"Mashed Potatoes", "Hamburger", "Burrito", "Cereal", "Tacos"});


            Console.WriteLine("HashSet<T>");
            Console.Write("Breakfast foods: ");
            foreach(string food in breakfast)
            {
                Console.Write($"{food}, ");
            }
            Console.WriteLine();

            Console.Write("Dinner foods: ");
            foreach (string food in dinner)
            {
                Console.Write($"{food}, ");
            }
            Console.WriteLine();

            dinner.IntersectWith(breakfast);
            Console.Write("Food for anytime: ");
            foreach(string food in dinner)
            {
                Console.Write($"{food}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
