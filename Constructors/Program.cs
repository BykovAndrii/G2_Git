using System;

namespace Constructors
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass(5, "test");

            //BaseClass baseClass1 = new BaseClass();

            //ChildBaseClass child = new ChildBaseClass(6, "67");

            //child.Test();
            //((BaseClass)child).Test();

            //BaseClass.TestStatic();

            int staticInt = BaseClass.staticInt;

            BaseClass baseClass1 = new BaseClass(5, "test");
            BaseClass baseClass2 = new BaseClass(4, "test1");

            Console.WriteLine(baseClass1.instanceInt);
            Console.WriteLine(baseClass2.instanceInt);

            baseClass1.instanceInt = 100;
            BaseClass.staticInt = 56;

            Console.WriteLine(baseClass1. instanceInt);
            Console.WriteLine(baseClass2.instanceInt);

            baseClass1.Test();
            baseClass2.Test();

            // Error
            //StaticClass staticClass = new StaticClass();

            Console.ReadKey();
        }
    }
}
