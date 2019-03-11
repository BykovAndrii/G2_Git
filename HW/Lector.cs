using System;
using System.Collections.Generic;

namespace HW
{
    class Lector : UniversityPerson
    {
        private List<Student> group = new List<Student>();

        public Lector(string name, string surname, string specialization) 
            : base(name, surname, specialization)
        {
        }

        public void GetStudentIntoGroup(List<Student> candidates)
        {
            if (candidates.Count != 5)
            {
                Console.WriteLine("Count of candidates' group is not equal 5 as expected.");
                return;
            }
            foreach (var student in candidates)
            {
                if (student.specialization == specialization)
                {
                    group.Add(student);
                }
                else
                {
                    Console.WriteLine($"Specialization of {student.name} {student.surname} is not valid");
                }
            }
        }
    }
}
