namespace HW
{
    class Student : UniversityPerson
    {
        private int course;

        public Student(string name, string surname, string specialization, int course)
            : base(name, surname, specialization)
        {
            this.course = course;
        }
    }
}
