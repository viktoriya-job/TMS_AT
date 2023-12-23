using Collections.Helper;

namespace Collections
{
    internal class ProductCatalogue
    {
        private static int _id = 0;
        public Dictionary<int, Product> Products { get; set; } = new Dictionary<int, Product>();

        public void AddProduct(string? name, string? priceInput, string? countInput)
        {
            if (CheckInputHelper.IsCorrectString(name)
                && CheckInputHelper.IsCorrectSingle(priceInput, out float price)
                && CheckInputHelper.IsCorrectInt32(countInput, out int count))
            {
                Products.Add(_id++, new Product(name, price, count));
                Console.WriteLine("Товар успешно добавлен");
            }
        }

        public void PrintProducts(int mode)
        {
            if (Products.Count > 0)
                // mode: 0 - только значения, 1 - ключ и значение
                switch (mode)
                {
                    case 0:
                        foreach (var product in Products)
                            product.Value.PrintInfo();
                        break;

                    case 1:
                        foreach (var product in Products)
                        {
                            Console.Write($"ID: {product.Key}, Товар: ");
                            product.Value.PrintInfo();
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректное значение mode - выберите 0 - \"вывод только значения\", 1 - \"вывод ключа и значения\"");
                        break;
                }
            else
                Console.WriteLine("В каталоге нет товаров");
        }

        public void FindProductByID(string? idInput)
        {
            if (CheckInputHelper.IsCorrectInt32(idInput, out int id))
                if (Products.ContainsKey(id))
                    Products[id].PrintInfo();
                else
                    Console.WriteLine($"Товар с ID {id} не найден"); ;
        }

        public void UpdateProduct(string? idInput)
        {
            if (CheckInputHelper.IsCorrectInt32(idInput, out int id))
                if (Products.ContainsKey(id))
                {
                    bool state = true;

                    while (state)
                    {
                        Products[id].PrintInfo();
                        Console.WriteLine($"""

                        Выберите действие:

                        1 - Обновить цену товара
                        2 - Обновить количество товара на складе
                        0 - Выйти
                        """);

                        if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int mode))
                            switch (mode)
                            {
                                case 1:
                                    Console.Write("Введите цену: ");
                                    UpdatePrice(id, Console.ReadLine());
                                    break;

                                case 2:
                                    Console.Write("Введите количество: ");
                                    UpdateCount(id, Console.ReadLine());
                                    break;

                                case 0:
                                    state = false;
                                    break;

                                default:
                                    Console.WriteLine("Вы ввели неправильный номер");
                                    break;
                            }
                    }
                }
                else
                    Console.WriteLine($"Товар с ID {id} не найден");
        }

        public void UpdatePrice(int id, string? priceInput)
        {
            if (CheckInputHelper.IsCorrectSingle(priceInput, out float price))
            {
                Products[id].Price = price;
                Console.WriteLine("Цена успешно обновлена \n");
            }
        }

        public void UpdateCount(int id, string? countInput)
        {
            if (CheckInputHelper.IsCorrectInt32(countInput, out int count))
            {
                Products[id].Count = count;
                Console.WriteLine("Количество успешно обновлено \n");
            }
        }

        public void RemoveByID(string? idInput)
        {
            if (CheckInputHelper.IsCorrectInt32(idInput, out int id))
            {
                if (Products.ContainsKey(id))
                {
                    Products.Remove(id);
                    Console.WriteLine("Товар успешно удален");
                }
                else
                    Console.WriteLine($"Товар с ID {id} не найден");
            }
        }
    }
}
