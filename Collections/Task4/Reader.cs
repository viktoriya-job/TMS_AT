using System.Collections.Generic;

namespace Collections.Task4
{
    internal class Reader
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }

        public Reader(string name, string libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
        }
    }
}
