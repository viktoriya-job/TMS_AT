using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Homework
{
    internal class Phone
    {
        //Из соглашения https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/identifier-names
        //"При именовании public элементов типов, таких как поля, свойства, события, используйте регистр pascal"
        //поэтому для public полей поля имена задаю в PascalCase

        public string Number { get; set; } = "+7 (000) 000-00-00";
        public string Model { get; set; } = "X-Ray";
        public float Weight { get; set; }

        public Phone() { }

        public Phone(string number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone(string number, string model, float weight) : this(number, model)
        {
            Weight = weight;
        }


        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"Вам звонит {callerName}");
        }

        public string GetNumber() => Number;

        public void SendMessage(params string[] numbersArray)
        {
            foreach (string number in numbersArray)
                Console.WriteLine(number);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"""
                {CreditCard.lineSeparator}
                Номер телефона: {Number}
                Модель: {Model}
                Вес: {Weight}
                {CreditCard.lineSeparator}
                """);
        }
    }
}
