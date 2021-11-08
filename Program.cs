using System;
using System.Collections.Generic;
using System.Collections;

namespace Demo_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var MYLIST = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var item in MYLIST)
            {
                Console.WriteLine(item);
            }
            var MYBooks= new List<string> {"secret","stories","harrypotter" };
            for (int i = 0; i< MYBooks.Count; i++)
            {
                Console.WriteLine("Books name is{0}",MYBooks[i]);
            }

            //display all content of stack

            Stack<string> Numbers = new Stack<string>();
            Numbers.Push("one");
            Numbers.Push("two");
            Numbers.Push("three");

            foreach(var item in Numbers)
            {
              Console.WriteLine("content of collections{0}\n", item);
            }
            //remove elements from stack

            Console.WriteLine("removing from top of stack\n{0}", Numbers.Pop());
        }
    }
}
