using System.Collections;
using Collections.Helper;


namespace Collections.Task1
{
    internal class Task1
    {
        public static void Run()
        {
            ArrayList array = new ArrayList{ "123","456",2000};
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
                Добро пожаловать в библиотеку!
                Выберите пункт  меню:

                1 -  Задача 1: Добавить книгу
                2 -  Задача 2: Просмотреть список книг
                3 -  Задача 3: Найти книги автора
                4 -  Задача 4: Удалить книгу
                0 -  Задача 0: Выйти
                """);

                if (Int32.TryParse(Console.ReadLine(), out int task))
                    if (task < 0 || task > 4)
                    {
                        Console.WriteLine("Вы ввели неправильный номер");
                        ClearHelper.Clear();
                    }
                    else
                        switch (task)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Введите название книги, автора и год издания");
                                
                                if (library.AddBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()))
                                    Console.WriteLine("Книга успешно добавлена!");
                                
                                ClearHelper.Clear();
                                break;

                            case 2:
                                Console.Clear();
                                library.PrintBooksList();
                                ClearHelper.Clear();
                                break;

                            case 3: 
                                Console.WriteLine("Книги какого автора нужно найти?");
                                if(!library.FindByAuthor(Console.ReadLine()))
                                    Console.WriteLine("Ничего не найдено"); ;
                                ClearHelper.Clear();
                                break;

                            case 4: Console.WriteLine("Введите ID книги, которую требуется удалить:");
                                if(library.RemoveByID(Console.ReadLine()))
                                    Console.WriteLine("Книга успешно удалена");
                                ClearHelper.Clear();
                                break;

                            case 0: 
                                state = false; 
                                break;
                        }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                    ClearHelper.Clear();
                }
            }
        }
    }
}
