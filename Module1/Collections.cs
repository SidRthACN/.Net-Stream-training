using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Collections
    {
        // types of collections in C# are as follows:


        internal void display()
        {
            //ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            Console.WriteLine("ArrayList elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Type of Datatype in ArrayList is: " + arrayList[0].GetType());
            // List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("\nList elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Type of Datatype in List is: " + list[0].GetType());

            // Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);

            Console.WriteLine("\nDictionary elements:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("Type of Datatype in Dictoinary is: " + dictionary["One"].GetType());
        }


    }
}
