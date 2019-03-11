namespace Constructors
{
    class ChildBaseClass : BaseClass
    {
        private char myChar;

        public ChildBaseClass(int a, string b) : base(a, b)
        {
            //myChar = c;
            //testInt
        }

        public void Test()
        {
            System.Console.WriteLine("Child");
        }
    }
}
