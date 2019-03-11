using System;
using System.Collections.Generic;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector lector1 = new Lector("lector name 1", "lector surname 1", "qa");
            List<Student> candidates = new List<Student>();

            Student student1 = new Student("name 1", "surname 1", "math", 1);
            Student student2 = new Student("name 2", "surname 2", "qa", 2);

            candidates.Add(student1);
            candidates.Add(student2);


            Console.ReadKey();
        }
    }
}
