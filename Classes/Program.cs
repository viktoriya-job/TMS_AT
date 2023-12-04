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
            creditCard3.TopDownAccount(0);
            creditCard2.TopUpAccount(0);

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

            PrintGreenText("Пациент 1");
            //Создадим и заполним план лечения
            TreatmentPlan treatmentPlan1 = new TreatmentPlan(1);
            treatmentPlan1.AddEntriesToTreatmentPlan(new string[] { "Исправление дефектов после ранее перенесенных операций", "Исправление состояний после травм", "Европеизация век" });

            //Создадим пациента, установив план лечения (ограниченная система, где у пациента только один план лечения)
            Patient patient1 = new Patient("Мария Барсиковна Чернохвостова", treatmentPlan1);

            Console.WriteLine($"Пациент: {patient1.Name}");
            treatmentPlan1.PrintTreatmentPlan();

            //Назначим врача
            patient1.AppointDoctor();


            PrintGreenText("Пациент 2");
            //Создадим и заполним план лечения
            TreatmentPlan treatmentPlan2 = new TreatmentPlan(2);
            treatmentPlan2.AddEntriesToTreatmentPlan(new string[] { "Лечение кариеса неосложненное", "Лечение пульпита" });

            //Создадим пациента, после установим ему план лечения
            Patient patient2 = new Patient("Марсик Барсикович Чернохвостов");
            patient2.PatientTreatmentPlan = treatmentPlan2;

            Console.WriteLine($"Пациент: {patient2.Name}");
            treatmentPlan2.PrintTreatmentPlan();

            //Назначим врача
            patient2.AppointDoctor();


            PrintGreenText("Пациент 3");
            //Создадим и заполним план лечения
            TreatmentPlan treatmentPlan3 = new TreatmentPlan(3);
            treatmentPlan3.AddEntriesToTreatmentPlan(new string[] { "Лечение ожирения первой степени" });

            //Создадим пациента
            Patient patient3 = new Patient("Кузьма Барсикович Чернохвостов", treatmentPlan3);

            Console.WriteLine($"Пациент: {patient3.Name}");
            treatmentPlan3.PrintTreatmentPlan();

            //Назначим врача
            patient3.AppointDoctor();
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
