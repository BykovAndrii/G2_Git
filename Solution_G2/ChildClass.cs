using System;

namespace Solution_G2
{
    public class ChildClass : ParentClass
    {
        public int childInt = 67;

        public new void TestMethod()
        {
            Console.WriteLine("Child class");
        }
    }
}
