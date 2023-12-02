using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Classes.Homework
{
    internal class Doctor: Person
    {
        public virtual void Treat()
        {
            ExaminePatient();
            OrderTest(new string[] { "ОАК", "ОАМ" });
            PerformTreatment();
        }
        public void ExaminePatient()
        {
            Console.WriteLine("Проведен осмотр");
        }
        
        public void OrderTest(params string[] tests)
        {
            Console.Write("Назначены анализы: ");
            foreach (string test in tests)
                Console.Write($"{test} ");
            Console.WriteLine();
        }


        public void PerformTreatment()
        {
            Console.WriteLine("Выполнено лечение");
        }
    }

    internal class DoctorTherapist : Doctor
    {
        public override void Treat()
        {
            base.Treat();
            PrescribeMedications(new string[] { "Витамин D" });
        }

        void PrescribeMedications(params string[] drugs)
        {
            Console.Write("Назначены препараты: ");
            foreach (string drug in drugs)
                Console.Write($"{drug} ");
            Console.WriteLine();
        }
    }

    internal class DoctorSurgeon : Doctor
    {
        public override void Treat()
        {
            base.Treat();
            OrderXRay();
        }

        public void OrderXRay()
        {
            Console.WriteLine("Назначена рентгенография");
        }
    }

    internal class DoctorDentist : Doctor
    {
        public void Treat(string xRayProjection)
        {
            base.Treat();
            OrderXRay(xRayProjection);
        }

        public void OrderXRay(string projection)
        {
            Console.WriteLine($"Назначена рентгенография челюсти в проекции: {projection}");
        }
    }

}
