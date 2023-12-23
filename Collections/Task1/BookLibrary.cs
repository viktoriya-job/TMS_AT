using Collections.Helper;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class BookLibrary
    {
        private List<Book> Books { get; set; } = new List<Book>(16);
        public BookLibrary() { }
        public BookLibrary(List<Book> books) => Books = books;

        public void AddBook(string? title, string? author, string? publishingYear)
        {
            if (Int32.TryParse(publishingYear, out int year))
            {
                Books.Add(new Book(new ArrayList { title, author, year }));
                Console.WriteLine("Книга успешно добавлена");
            }
            else
                Console.WriteLine("Введен некорректный год издания");
        }

        public void PrintBooksList()
        {
            foreach (var book in Books)
                book.PrintInfo();
        }

        public void FindByAuthor(string? author)
        {
            if (CheckInputHelper.IsCorrectString(author))
            {
                bool found = false;

                foreach (var book in Books)
                    if (book.BookInfo.Contains(author))
                    {
                        book.PrintInfo();
                        found = true;
                    }
                if (!found)
                    Console.WriteLine($"Книги автора {author} не найдены");
            }
        }

        public void RemoveByID(string? idInput)
        {
            if (Int32.TryParse(idInput, out int id))
            {
                int index = Books.FindIndex(item => item.ID == id);

                if (index >= 0)
                {
                    Books.Remove(Books[index]);
                    Console.WriteLine("Книга успешно удалена");
                }
                else
                    Console.WriteLine($"Книга с ID [{id}] не найдена");
            }
        }
    }
}
