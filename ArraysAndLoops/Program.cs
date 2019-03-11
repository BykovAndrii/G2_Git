using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //string[] array = new string[5];

            //array[0] = 45;
            //array[1] = "string";
            //array[2] = 'c';

            int[] intArray = { 23, 54, 2, 9 };

            //string str = "srgr";
            //Array test = Array.CreateInstance(str.GetType(), 6);
            //test.SetValue("sdfsd", 0);

            #endregion

            #region While

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //int counter = 1;

            //while (counter < 6)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            #endregion

            #region Do-While

            //int counter1 = 1005;

            //do
            //{
            //    Console.WriteLine(counter1);
            //    counter1++;

            //} while (counter1 < 6);

            #endregion

            #region For

            //for (int i = 1; i < 6; i++)
            //{
            //    //if (i == 3)
            //    //{
            //    //    break;
            //    //}

            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);             
            //}

            #endregion

            #region Foreach

            int[] array2 = { 3, 4, 5, 8 };

            foreach (var number in array2)
            {
                //number += 5;
                Console.WriteLine(number);
            }

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] += 5;
            //}

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.WriteLine(array2[i]);
            //}

            #endregion

            Console.ReadKey();

        }
    }
}
