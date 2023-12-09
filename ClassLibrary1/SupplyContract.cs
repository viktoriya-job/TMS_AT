namespace DocumentsAccount
{
    public class SupplyContract : Document
    {
        public string ProductsType { get; set; } = "Не определен";
        public int ProductsCount { get; set; } = 0;

        public SupplyContract() { }
        public SupplyContract(string number, DateOnly date, string productsType, int productsCount) : base(number, date)
        {
            ProductsType = productsType;
            ProductsCount = productsCount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"""
                Номер документа:    {Number}
                Тип товаров:        {ProductsType}
                Количество товаров: {ProductsCount}
                Дата документа:     {Date}
                {new string('~', 35)}
                """); ;
        }
    }
}