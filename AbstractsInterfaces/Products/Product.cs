
namespace AbstractsInterfaces.Products
{
    internal abstract class Product
    {
        public string Title { get; set; }
        protected float Price { get; set; }

        protected Product(string title, float price)
        {
            Title = title;
            Price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"""
                {new string('~', 35)}
                Наименование:       {Title}
                Цена:               {String.Format("{0:C2}", Price)}
                """);
        }
        public abstract bool IsNotExpired();
    }
}
