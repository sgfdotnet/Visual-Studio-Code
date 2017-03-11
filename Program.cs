using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static List<String> TestList = new List<String>();
        public static String AVariable = "AValue";
        public static void Main(string[] args)
        {
            Give();

            Console.WriteLine("Hello World!");
        }

        public static List<String> PopulateList()
        {
            List<String> ReturnList = new List<String>();

            ReturnList.Add("This");
            ReturnList.Add("Is");
            ReturnList.Add("A");
            ReturnList.Add("List");
            ReturnList.Add("Of");
            ReturnList.Add("Strings");            

            return ReturnList;
        }

        public static void Give()
        {
            Me();
        }

        public static void Me()
        {
            A();
        }

        public static void A()
        {
            CallStack();
        }

        public static void CallStack()
        {
            TestList = PopulateList();
            Console.WriteLine(AVariable);
        }
    }
}
