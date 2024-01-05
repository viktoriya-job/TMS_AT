using System.Collections;
using Collections.Helper;

namespace Collections
{
    internal class Task1
    {
        public static void Run()
        {
            BookLibrary library = new BookLibrary(new List<Book>
            {
                new Book( new ArrayList { "Тестирование DOT COM", "Роман Савин", 2007 }),
                new Book( new ArrayList { "A Practitioner's Guide to Software Test Design", "Lee Copeland", 2004}),
                new Book( new ArrayList { "Паттерны проектирования на платформе .NET", "Сергей Тепляков", 2015})
            });

            bool state = true;

            while (state)
            {
                Console.Clear();
                Console.WriteLine("""
                Добро пожаловать в библиотеку
                Выберите пункт  меню:

                1 -  Добавить книгу
                2 -  Просмотреть список книг
                3 -  Найти книги автора
                4 -  Удалить книгу
                0 -  Выйти
                """);

                if (CheckInputHelper.IsCorrectInt32(Console.ReadLine(), out int task))
                {
                    Console.Clear();

                    switch (task)
                    {
                        case 1:
                            Console.WriteLine("Введите название книги, автора и год издания");
                            library.AddBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 2:
                            library.PrintBooksList();
                            ClearHelper.Exit();
                            break;

                        case 3:
                            Console.WriteLine("Книги какого автора нужно найти?");
                            library.FindByAuthor(Console.ReadLine());
                            ClearHelper.Exit();
                            break;

                        case 4:
                            Console.WriteLine("Введите ID книги, которую требуется удалить:");
                            library.PrintBooksList();
                            library.RemoveByID(Console.ReadLine());
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