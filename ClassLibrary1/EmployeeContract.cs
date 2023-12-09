namespace DocumentsAccount
{
    public class EmployeeContract : Document
    {
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string EmployeeName { get; set; } = "Не определено";
        public EmployeeContract() { }

        public EmployeeContract(string number, DateOnly date, DateOnly endDate, string employeeName) : base(number, date)
        {
            EndDate = endDate;
            EmployeeName = employeeName;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
                Номер документа:            {Number}
                Дата документа:             {Date}
                Дата окончания контракта:   {EndDate}
                Имя сотрудника:             {EmployeeName}
                {new string('~', 35)}
                """);
        }
    }
}