using Collections.Helper;
using System.Collections.Generic;
namespace Collections.Task4
{
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>(16);
        public Dictionary<Reader, ISet<Book>> ReadersBooks { get; set; } = new Dictionary<Reader, ISet<Book>>(16);

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void CheckOutBook(Reader reader, Book book)
        {
            if (!book.IsCheckedOut)
            {
                book.IsCheckedOut = true;

                if (ReadersBooks.ContainsKey(reader))
                    ReadersBooks[reader].Add(book);
                else
                    ReadersBooks.Add(reader, new HashSet<Book> { book });

                Console.WriteLine($"Книга [{book.Author}, {book.Title}] успешно выдана читателю [{reader.LibraryCardNumber}, {reader.Name}]");
            }
            else
                Console.WriteLine($"Невозможно выдать книгу [{book.Author}, {book.Title}], так как она уже выдана");
        }

        public void ReturnBook(Reader reader, Book book)
        {
            if (ReadersBooks.ContainsKey(reader))
                if (ReadersBooks[reader].Contains(book))
                {
                    book.IsCheckedOut = false;

                    if (ReadersBooks.ContainsKey(reader))
                        if (ReadersBooks[reader].Contains(book))
                            ReadersBooks[reader].Remove(book);
                    Console.WriteLine($"Книга [{book.Author}, {book.Title}] успешно возвращена в библиотеку");
                }
                else
                    Console.WriteLine($"Проверьте информацию - книга [{book.Author}, {book.Title}] не была выдана читателю [{reader.LibraryCardNumber}, {reader.Name}]"); ;
        }

        public void PrintBooksList()
        {
            if (Books.Count > 0)
            {
                Console.WriteLine("Список книг:");
                foreach (Book book in Books)
                    book.PrintInfo();
            }
            else
                Console.WriteLine("Список книг пуст");
        }

        public void PrintReadersBooks()
        {
            if (ReadersBooks.Count > 0)
            {
                Console.WriteLine("Список выданных читателям книг:");
                foreach (var item in ReadersBooks)
                {
                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine($"\nЧитатель: {item.Key.Name}, Книги:");
                        foreach (var book in item.Value)
                            book.PrintInfo();
                    }
                }
            }
        }
    }
}
