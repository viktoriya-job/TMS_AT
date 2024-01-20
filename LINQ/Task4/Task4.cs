namespace LINQ
{
    internal class Task4
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(Surname.Чернохвостов, "Точильщик когтей"),
                new Employee(Surname.Мурко,"Смотритель снов"),
                new Employee(Surname.Котейкин, "Охотник на тапочки"),
                new Employee(Surname.Голубоглазова, "Дегустатор кошачьих кормов"),
                new Employee(Surname.Нагломордов, "Смотритель снов"),
                new Employee(Surname.Неглаженый, "Точильщик когтей"),
                new Employee(Surname.Длинноусов, "Дегустатор кошачьих кормов"),
                new Employee(Surname.Белоус, "Охотник на тапочки"),
                new Employee(Surname.Мяукин, "Смотритель снов")
            };

            List<Payroll> payroll = new List<Payroll>()
            {
                new Payroll(Surname.Нагломордов, 20000),
                new Payroll(Surname.Котейкин, 25000),
                new Payroll(Surname.Мяукин, 15000),
                new Payroll(Surname.Длинноусов, 17000),
                new Payroll(Surname.Голубоглазова, 21000),
                new Payroll(Surname.Чернохвостов, 14000),
                new Payroll(Surname.Мурко, 18000),
                new Payroll(Surname.Белоус, 23000),
                new Payroll(Surname.Неглаженый, 16000)
            };

            var result = employees.Join(payroll,
                e => e.Surname,
                p => p.Surname,
                (e, p) => new { e.Speciality, p.Salary })
                .GroupBy(s => s.Speciality)
                .Select(res =>
                new
                {
                    Speciality = res.Key,
                    SalaryAmount = res.Sum(sal => sal.Salary)
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Speciality}, {item.SalaryAmount}");
            }
        }
    }
}