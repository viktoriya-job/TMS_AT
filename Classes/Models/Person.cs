namespace Classes.Models;

public class Person
{
    // Блок полей (переменных)
    public string Name = "Undefined";   // имя
    public int Age;                     // возраст

    // Блок конструктора
    public Person() { }
    public Person(string name)
    {
        Name = name;
    }
    
    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
    }
}