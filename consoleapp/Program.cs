using System;
using System.Collections;
using System.Collections.Generic;

namespace consoleapp
{
    class Program
    {
        static List<string> pieceofthelist = new List<string>();
        static void Main(string[] args)
        {
            DoAThing();
            Console.WriteLine("Hello World!");
        }

        static void DoAThing()
        {
            List<string> test = new List<string>();

            test = AddThingsToList(test);

            pieceofthelist = test.FindAll(x => x.Contains("Item"));
        }

        static List<string> AddThingsToList(List<string> thelist)
        {
            thelist.Add("Test1");
            thelist.Add("Test2");
            thelist.Add("Item1");
            thelist.Add("Item2");

            return thelist;
        }
    }
}
