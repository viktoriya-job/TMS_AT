namespace LINQ
{
    internal class Payroll
    {
        public Surname Surname { get; set; }
        public int Salary { get; set; }

        public Payroll(Surname surname, int salary)
        {
            Surname = surname;
            Salary = salary;
        }
    }
}