using System.Collections;
using Collections.Helper;

namespace Collections
{
    internal class Book
    {
        private static int _id = 0;
        public int ID { get; set; }
        public ArrayList BookInfo { get; set; } = new ArrayList(3);

        public Book(ArrayList bookInfo)
        {
            ID = _id++;
            BookInfo = bookInfo;
        }

        public void PrintInfo()
        {
            Console.Write($"ID: {ID}, ");
            PrintHelper.PrintCollection(BookInfo);
            Console.WriteLine();
        }
    }
}