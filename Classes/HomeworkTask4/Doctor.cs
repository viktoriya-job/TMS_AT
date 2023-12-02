using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Classes.Homework
{
    internal class Doctor : Person
    {
        public string QualificationCategory {get; set;}


        public Doctor(string name, string qualificationCategory) : base(name)
        {
            QualificationCategory = qualificationCategory;
        }


        public virtual void Treat()
        {
            ExaminePatient();
        }

        private void ExaminePatient()
        {
            Console.WriteLine("Проведен осмотр");
        }
    }


    internal class DoctorTherapist : Doctor
    {
        public DoctorTherapist(string name, string qualificationCategory) : base(name, qualificationCategory)
        {
        }

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
        public DoctorSurgeon(string name, string qualificationCategory) : base(name, qualificationCategory)
        {
        }

        public override void Treat()
        {
            base.Treat();
            PerformSurgery();
        }

        private void PerformSurgery()
        {
            Console.WriteLine("Проведена операция");
        }
    }


    internal class DoctorDentist : Doctor
    {
        public DoctorDentist(string name, string qualificationCategory) : base(name, qualificationCategory)
        {
        }

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
