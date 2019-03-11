using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List

            //List<string> testList = new List<string>();

            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);

            //Console.WriteLine("----------------------------------");
            //testList.Add("str1");

            //string[] strArray = { "1", "2" };
            //testList.AddRange(strArray);
            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);

            //testList.Add("str1");
            //testList.Add("str1");
            //testList.Add("str1");
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);
            //Console.WriteLine("----------------------------------");

            //testList.Add("str1");
            //testList.Add("str1");
            //testList.Add("str1");
            //testList.Add("str1");
            //testList.Add("str32");
            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);

            //var isContains = testList.Contains("str1");
            //Console.WriteLine(isContains);

            //Console.WriteLine(testList.Exists(st => st.Contains("3")));

            //Console.WriteLine(testList.FindIndex(st => st == "str32"));

            #endregion

            #region Dictionary

            Dictionary<int, string> testDictionary = new Dictionary<int, string>();

            testDictionary.Add(0, "test 0");
            testDictionary.Add(1, "test 1");
            testDictionary.Add(2, "test 2");
            testDictionary.Add(3, "test 3");
            testDictionary.Add(4, "test 4");

            var keys = testDictionary.Keys;

            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            var values = testDictionary.Values;

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            foreach (var item in testDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            #endregion

            Console.ReadKey();

        }
    }
}
