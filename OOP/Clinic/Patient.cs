
namespace OOP.Clinic
{
    internal class Patient : Person
    {
        public TreatmentPlan PatientTreatmentPlan { get; set; } = new TreatmentPlan(0);

        public Patient(string name) : base(name) { }

        public Patient(string name, TreatmentPlan patientTreatmentPlan) : base(name) => PatientTreatmentPlan = patientTreatmentPlan;

        public void AppointDoctor()
        {
            switch (PatientTreatmentPlan.TreatmentPlanCode)
            {
                case 1:
                    DoctorSurgeon surgeon = new DoctorSurgeon("Котовский Е.А.", "Врач высшей категории");
                    Console.WriteLine($"\nЛечение проводит хирург {surgeon.Name} {surgeon.QualificationCategory}");
                    surgeon.Treat();
                    break;

                case 2:
                    DoctorDentist dentist = new DoctorDentist("Манулов К.И.", "Врач первой категории");
                    Console.WriteLine($"\nЛечение проводит дантист {dentist.Name} {dentist.QualificationCategory}");
                    dentist.Treat();
                    break;

                default:
                    DoctorTherapist therapist = new DoctorTherapist("Фыркова К.Б.", "Врач высшей категории");
                    Console.WriteLine($"\nЛечение проводит терапевт {therapist.Name} {therapist.QualificationCategory}");
                    therapist.Treat("Витамин D", "Экстракт валерианы");
                    break;
            }
        }
    }
}
