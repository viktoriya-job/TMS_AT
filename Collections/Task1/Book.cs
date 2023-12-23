
using System.Collections;

namespace Collections.Task1
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
            foreach (var item in BookInfo)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
    }
}