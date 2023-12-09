
namespace DocumentsAccount
{
    public class Registr : IPrintable
    {
        private static int _length = 10;
        public Document[] Documents { get; set; } = new Document[_length];

        public void AddDocument(Document document)
        {
            bool isAdded = false;

            for (int i = 0; i < _length; i++)
                if (Documents[i] == null)
                {
                    Documents[i] = document;
                    isAdded = true;
                    break;
                }
            if (!isAdded)
                Console.WriteLine("Невозможно добавить документ. Регистр заполнен");
        }

        public void PrintInfo(Document document)
        {
            if (Array.IndexOf(Documents, document) >= 0)
                document.PrintInfo();
            else
                Console.WriteLine("Документ отсутствует в регистре");
        }

        public void PrintInfo()
        {
            Console.WriteLine("Перечень документов:");
            for (int i = 0; i < _length; i++)
            {
                if (Documents[i] != null)
                    Documents[i].PrintInfo();
                else
                    break;
            }
        }
    }
}