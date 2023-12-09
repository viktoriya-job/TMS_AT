namespace DocumentsAccount
{
    public class FinancialInvoice : Document
    {
        public float TotalAmount { get; set; } = 0;
        public string DepartmentCode { get; set; } = "Не определен";

        public FinancialInvoice() { }

        public FinancialInvoice(string number, DateOnly date, float totalAmount, string departmentCode) : base(number, date)
        {
            TotalAmount = totalAmount;
            DepartmentCode = departmentCode;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
                Итоговая сумма за месяц:    {TotalAmount}
                Дата документа:             {Date}
                Номер документа:            {Number}
                Код департамента:           {DepartmentCode}
                {new string('~', 35)}
                """);
        }
    }
}