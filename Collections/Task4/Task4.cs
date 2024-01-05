using Collections.Helper;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Task4
{
    internal class Task4
    {
        public static void Run()
        {
            var library = new Library();

            library.AddBook(new Book("Тестирование DOT COM", "Роман Савин", "000-5-699-12014-7"));
            library.AddBook(new Book("A Practitioner's Guide to Software Test Design", "Lee Copeland", "111-5-699-12014-7"));
            library.AddBook(new Book("Паттерны проектирования на платформе .NET", "Сергей Тепляков", "222-5-699-12014-7"));
            library.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков", "333-5-699-12014-7"));
            library.AddBook(new Book("Фауст", "И.О.Гёте", "444-5-699-12014-7"));

            PrintHelper.PrintRedText("\nВыведем информацию о книгах в библиотеке");
            library.PrintBooksList();

            var reader1 = new Reader("Коровин Фагот", "84P1");
            var reader2 = new Reader("Бегемот", "54t4");

            PrintHelper.PrintRedText("\nВыдадим книги читателям");
            library.CheckOutBook(reader1, library.Books[library.Books.Count - 1]);
            library.CheckOutBook(reader2, library.Books[library.Books.Count - 2]);
            library.CheckOutBook(reader2, library.Books[library.Books.Count - 3]);

            PrintHelper.PrintRedText("\nПопытаемся выдать уже выданную книгу");
            library.CheckOutBook(reader2, library.Books[library.Books.Count - 1]);

            PrintHelper.PrintRedText("\nВыведем информацию о том, какие книги взяты у каждого читателя");
            library.PrintReadersBooks();

            PrintHelper.PrintRedText("\nВернем одну из книг в библиотеку");
            library.ReturnBook(reader1, library.Books[library.Books.Count - 1]);

            PrintHelper.PrintRedText("\nПопытаемся вернуть книгу от другого читателя");
            library.ReturnBook(reader1, library.Books[library.Books.Count - 2]);

            PrintHelper.PrintRedText("\nСнова выведем информацию о том, какие книги взяты у каждого читателя");
            library.PrintReadersBooks();

            PrintHelper.PrintRedText("\nУбедимся, что возвращенную книгу можно снова выдать читателю");
            library.CheckOutBook(reader2, library.Books[library.Books.Count - 1]);
        }
    }
}
