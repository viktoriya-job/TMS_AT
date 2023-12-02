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

            //Задача 1
            Console.WriteLine($"\n{new string('=', 15)} Задача 1 {new string('=', 15)}\n");

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

            Console.WriteLine($"\n{new string('=', 15)} Задача 1 {new string('=', 15)}\n");



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
    }
}
