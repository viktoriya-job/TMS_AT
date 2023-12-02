using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;

namespace Classes.Homework
{
    internal class Patient: Person
    {
        public Patient(string name) : base(name) {}

        public void AppointDoctor(TreatmentPlan patientTreatmentPlan)
        {
            switch (patientTreatmentPlan.TreatmentPlanCode)
            {
                case 1:
                    DoctorSurgeon surgeon = new DoctorSurgeon();
                    surgeon.Treat();
                    Console.WriteLine("Лечение проводит хирург");
                    break;

                case 2:
                    DoctorDentist dentist = new DoctorDentist();
                    dentist.Treat("А");
                    Console.WriteLine("Лечение проводит дантист");
                    break;

                default:
                    DoctorTherapist therapist = new DoctorTherapist();
                    therapist.Treat();
                    Console.WriteLine("Лечение проводит терапевт");
                    break;

            }
        }
    }
}
