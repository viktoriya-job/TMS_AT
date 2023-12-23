using Collections.Helper;

namespace Collections
{
    internal class Task2
    {
        public static void Run()
        {
            var catalogue = new ProductCatalogue();
            catalogue.AddProduct("Purina One для кошек, с лососем", "1200", "6");
            catalogue.AddProduct("Purina One для кошек, с индейкой", "1360", "20");
            catalogue.AddProduct("Purina One для кошек, с говядиной", "1120", "10");

            bool state = true;

            while (state)
            {
                Console.Clear();
                Console.WriteLine("""
                Выберите пункт  меню:

                1 -  Добавить товар
                2 -  Просмотреть список товаров
                3 -  Найти товар по идентификатору
                4 -  Обновить информацию о товаре 
                5 -  Удалить товар
                0 -  Выйти
                """);

                if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
                {
                    Console.Clear();

                    switch (task)
                    {
                        case 1:
                            Console.WriteLine("Введите название товара, его цену и количество");
                            catalogue.AddProduct(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 2:
                            catalogue.PrintProducts(0);
                            ClearHelper.Exit();
                            break;

                        case 3:
                            Console.WriteLine("Введите ID товара для поиска");
                            catalogue.FindProductByID(Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 4:
                            Console.WriteLine("Введите ID товара, информацию по которому требуется обновить:");
                            catalogue.PrintProducts(1);
                            catalogue.UpdateProduct(Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 5:
                            Console.WriteLine("Введите ID товара, который требуется удалить:");
                            catalogue.PrintProducts(1);
                            catalogue.RemoveByID(Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 0:
                            state = false;
                            break;

                        default:
                            Console.WriteLine("Вы ввели неправильный номер");
                            ClearHelper.Exit();
                            break;
                    }
                }
            }
        }
    }
}
