
namespace Exceptions
{
    internal class Task2
    {
        public static void Run()
        {
            try
            {
                Order order = new Order(999, new List<string> { "Пряничный домик", "Гирлянда \"Домики\"", "Набор ёлочных украшений" }, "Краснодар, филиал ТК КИТ");
                //Order order = new Order(-1, new List<string> { "Пряничный домик", "Гирлянда \"Домики\"", "Набор ёлочных украшений" }, "Краснодар, филиал ТК КИТ");
                //Order order = new Order(12, new List<string>(), "Краснодар, филиал ТК КИТ");
                //Order order = new Order(123, new List<string> { "Пряничный домик", "Гирлянда \"Домики\"", "Набор ёлочных украшений" }, "");

                Console.WriteLine("Успешное создание заказа");
                order.PrintInfo();
            }
            catch (InvalidOrderNumberException exOrder)
            {
                Console.WriteLine($"{exOrder.Message}: {exOrder.Value}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}