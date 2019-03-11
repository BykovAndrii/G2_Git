using System;

namespace Solution_G2
{
    public class ParentClass
    {
        public int myInt = 2345678;
        public byte myByte = 123;
        public bool myBool = false;
        public char myChar = 'A';
        public string myString = "Test string";

        public float myFloat = 3.14f;
        public double myDouble = 4.56;
        public decimal myDecimal = 345m;
        public long myLong = 34832L;
        public uint unsignedInt;

        public virtual void TestMethod()
        {
            Console.WriteLine("Parent class");
        }

        public int GetTwoIntegerSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void PrintTwoIntegerSum(int firstNumber, int secondNumber)
        {
            Console.WriteLine(GetTwoIntegerSum(firstNumber, secondNumber));
        }
    }
}
