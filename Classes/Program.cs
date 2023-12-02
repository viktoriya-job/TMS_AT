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
            Console.OutputEncoding = Encoding.GetEncoding("utf-8");

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
