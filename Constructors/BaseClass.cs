namespace Constructors
{
    class BaseClass
    {
        public static readonly int t = 67;

        public static int staticInt = 7;
        public int instanceInt = 21;

        protected int testInt = 7;
        private string testString = "default";

        public BaseClass(int testInt, string testString)
        {
            this.testInt = testInt;
            this.testString = testString;
        }

        //public BaseClass()
        //{
        //}

        public int GetPrivateInt()
        {
            return testInt;
        }

        public void Test()
        {
            System.Console.WriteLine(staticInt);
        }

        public static void TestStatic()
        {
            System.Console.WriteLine("Test static");
        }
    }
}
