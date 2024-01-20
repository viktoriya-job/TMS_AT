namespace LINQ
{
    internal class Employee
    {
        public Surname Surname {  get; set; }
        public string Speciality { get; set; }

        public Employee(Surname surname, string speciality)
        {
            Surname = surname;
            Speciality = speciality;
        }
    }
}
