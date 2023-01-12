using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Hash Table Data Structure");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            CountNumbOfOccurence(paragraph);
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(19);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation");
            hashTabe.Display();
            string s = "avoidable";
            hashTabe.Remove(s);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("After removed an item {0}", s);
            hashTabe.Display();
        }
    }
}
