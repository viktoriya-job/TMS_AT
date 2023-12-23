
namespace Collections.Task2
{
    internal class Product
    {
        public string Name { get; }
        public float Price { get; set; }
        public int Count { get; set; }

        public Product(string name, float price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, {String.Format("{0:C2}", Price)}, {Count} шт");
        }
    }
}
