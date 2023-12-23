namespace Collections.Task4
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsCheckedOut = false;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {ISBN}, {Author}, {Title}");
        }
    }
}
