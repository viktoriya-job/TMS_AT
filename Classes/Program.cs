using Classes.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.Unicode;

            /////////////////////////////////////////////////////////////
            //Задача 1
            PrintTaskNumber(1);

            Phone phone1 = new Phone();
            Phone phone2 = new Phone("890111110011", "Redmi");
            Phone phone3 = new Phone("+7(901)11110011", "Redmi", 300);

            phone1.PrintInfo();
            phone2.PrintInfo();
            phone3.PrintInfo();

            phone1.ReceiveCall("Реклама");
            phone2.ReceiveCall("Мария Александровна КлласРук о ужас");
            phone3.ReceiveCall("Служба поддержки Сбербанка");

            Console.WriteLine();
            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine(phone2.GetNumber());
            Console.WriteLine(phone3.GetNumber());

            Console.WriteLine();
            phone1.SendMessage(
                "8 (901) 111-11-11",
                "8 (901) 111-11-12",
                "8 (901) 111-11-13",
                "8 (901) 111-11-14",
                "8 (901) 111-11-15");

            Console.WriteLine();
            phone2.SendMessage(
                "8 (901) 111-11-21",
                "8 (901) 111-11-22");


            /////////////////////////////////////////////////////////////
            //Задача 2
            PrintTaskNumber(2);

            CreditCard creditCard1 = new CreditCard("4000 0012 3456 7899", 0);
            CreditCard creditCard2 = new CreditCard("5110 0001 3456 7579", 10000);
            CreditCard creditCard3 = new CreditCard("5610591081018250", 160000);

            //Выведем информацию по картам
            creditCard1.GetInfo();
            creditCard2.GetInfo();
            creditCard3.GetInfo();

            //Проведем заданные манипуляции -
            //положить деньги на первые две карты, снять деньги с третьей карты
            creditCard1.TopUpAccount(10000);
            creditCard2.TopUpAccount(100000);
            creditCard3.TopDownAccount(120000);


            /////////////////////////////////////////////////////////////
            //Задача 3
            PrintTaskNumber(3);

            var cashMachine = new CashMachine(100, 100, 100);
            cashMachine.GetInfo();

            PrintGreenText("Успешные операции внесения наличных");
            cashMachine.DepositMoney(10, 0, 0);
            cashMachine.DepositMoney(10, 10, 10);
            cashMachine.GetInfo();

            PrintGreenText("Не успешные попытки снятия наличных");
            cashMachine.WithdrawMoney(25000);
            Console.WriteLine();
            cashMachine.WithdrawMoney(180);

            PrintGreenText("Успешное снятие наличных");
            cashMachine.WithdrawMoney(13590);
            cashMachine.GetInfo();


            /////////////////////////////////////////////////////////////
            //Задача 4
            PrintTaskNumber(4);


            TreatmentPlan treatmentPlan1 = new TreatmentPlan(1);
            TreatmentPlan treatmentPlan2 = new TreatmentPlan(2);
            TreatmentPlan treatmentPlan3 = new TreatmentPlan(3);
            Patient patient = new Patient("Алексей Александрович");
            Console.WriteLine($"Пациент: {patient.Name}");

            patient.AppointDoctor(treatmentPlan1);
            Console.WriteLine();
            patient.AppointDoctor(treatmentPlan2);
            Console.WriteLine();
            patient.AppointDoctor(treatmentPlan3);

        }

        static void PrintTaskNumber(int number)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{new string('=', 15)} Задача {number} {new string('=', 15)}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintGreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{text}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
