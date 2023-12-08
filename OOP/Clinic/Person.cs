
namespace OOP.Clinic
{
    internal class Person
    {
        public string Name { get; set; } = "Не определено";
        public int Age { get; set; } = 0;

        public Person() { }

        public Person(string name) => Name = name;

        public Person(string name, int age) : this(name) => Age = age;
    }
}
