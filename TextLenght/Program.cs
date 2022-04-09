using System;
using System.Collections.Generic;

namespace TextLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakiś tekst");

            string t = Console.ReadLine();
            string[] text = t.Split(' ');

            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();

            foreach (var item in text)
            {
                int key = item.Length;
                if(dictionary.ContainsKey(key))
                {
                    List<string> list = dictionary[key];
                    list.Add(item);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(item);
                    dictionary.Add(key, list);
                }
            }
            foreach(KeyValuePair<int, List<string>> kv in dictionary)
            {
                Console.WriteLine(kv.Key);
                foreach (string word in kv.Value)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
