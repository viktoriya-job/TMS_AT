using System.Collections;
using System.Collections.Generic;

namespace Collections.Task1
{
    internal class BookLibrary
    {
        private List<Book> Books { get; set; } = new List<Book>(16);

        public BookLibrary() { }

        public BookLibrary(List<Book> books) => Books = books;

        public bool AddBook(string? title, string? author, string? publishingYear)
        {
            if (Int32.TryParse(publishingYear, out int year))
            {
                Books.Add(new Book(new ArrayList { title, author, year }));
                return true;
            }
            Console.WriteLine("Введен некорректный год издания");
            return false;
        }

        public void PrintBooksList()
        {
            foreach (var book in Books)
                book.PrintInfo();
        }

        public bool FindByAuthor(string? author)
        {
            bool found = false;

            foreach (var book in Books)
                if (book.BookInfo.Contains(author))
                {
                    book.PrintInfo();
                    found = true;
                }
            return found;
        }

        public bool RemoveByID(string? idInput)
        {
            if (Int32.TryParse(idInput, out int id))
            {
                int index = Books.FindIndex(item => item.ID == id);

                if (index >= 0)
                {
                    Books.Remove(Books[index]);
                    return true;
                }
                else
                    Console.WriteLine($"Книга с ID [{id}] не найдена");
            }
            else
                Console.WriteLine("Введен некорректный идентификатор");
            return false;
        }
    }
}
