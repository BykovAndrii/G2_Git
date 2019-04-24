using System;

namespace Db
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnect dbConnect = new DbConnect();

            dbConnect.SelectList();
            //dbConnect.Count();

            Console.ReadKey();
        }
    }
}
