using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(01, "Adana");
            cities.Add(02, "Ankara");
            Console.WriteLine(cities.Count);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            MyDictionary<int, string> cities2 = new MyDictionary<int, string>();
            cities2.Add(01, "Adana");
            cities2.Add(02, "Ankara");
            cities2.Add(13, "Bitlis");
            cities2.Add(33, "Mersin");
            cities2.Add(34, "İstanbul");
            Console.WriteLine(cities2.Count);

            cities2.List();

        }
    }
}