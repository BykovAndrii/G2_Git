using System;

namespace Solution_G2
{
    class Program
    {

        public static void PrintClassInstance(ParentClass parentClass)
        {
            Console.WriteLine(parentClass.ToString());
        }
       
        static void Main(string[] args)
        {
            // Danger! Explicit types' converting
            //int a = 50;
            //byte b = 7;
            //b = (byte)a;
            //Console.WriteLine(b);

            ParentClass parentClass = new ParentClass();
            parentClass.myBool = true;
            //Console.WriteLine(parentClass.myBool);

            ChildClass childClass = new ChildClass();
            //Console.WriteLine(childClass.childInt);

            ParentClass parentClass1 = new ChildClass();

            // Impossible, follow us to exception
            //childClass = (ChildClass)parentClass;
            //Console.WriteLine(childClass.childInt);

            //childClass.TestMethod();
            parentClass1.TestMethod();

            PrintClassInstance(parentClass1);

            //int a = 5;
            //int b = 10;

            //parentClass1.PrintTwoIntegerSum(a, b);

            //var result = parentClass1.GetTwoIntegerSum(a, b);



            Console.ReadKey();

        }
    }
}
