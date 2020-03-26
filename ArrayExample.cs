using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyFirstProject
{
    class ArrayExample
    {
        public int ExampleWithArray()
        {
            string[] fruits = { "apple", "passionfruit", "banana", "mango",
                     "orange", "blueberry", "grape", "strawberry" };

            List<int> list = fruits.Select(fruit => fruit.Length).ToList();
            List<string> content = fruits.Select(fruit => fruit).ToList();

            int len = fruits.Length;

            /*foreach (var row in list)
            {
                Console.WriteLine(row + " -- ");
            }*/

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(list[i] + " -- " + content[i]);
            }

            return len;
        }
    }
}
