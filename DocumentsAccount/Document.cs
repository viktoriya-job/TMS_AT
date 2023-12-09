namespace DocumentsAccount
{
    public abstract class Document : IPrintable
    {
        public string Number { get; set; } = "Без номера";
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        protected Document() { }
        protected Document(string number, DateOnly date)
        {
            Number = number;
            Date = date;
        }

        public abstract void PrintInfo();
    }
}