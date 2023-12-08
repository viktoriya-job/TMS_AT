
namespace OOP.Clinic
{
    internal class Doctor : Person
    {
        public string QualificationCategory { get; set; } = "Не определено";

        public Doctor(string name, string qualificationCategory) : base(name) => QualificationCategory = qualificationCategory;

        public virtual void Treat() => ExaminePatient();

        private void ExaminePatient()
        {
            Console.WriteLine("Проведен осмотр");
        }
    }


    internal class DoctorTherapist : Doctor
    {
        public DoctorTherapist(string name, string qualificationCategory) : base(name, qualificationCategory) { }

        public override void Treat()
        {
            base.Treat();
            HoldConsultation();
        }

        public void Treat(params string[] drugs)
        {
            base.Treat();
            HoldConsultation();
            PrescribeMedications(drugs);
        }

        private void HoldConsultation()
        {
            Console.WriteLine("Проведена консультация");
        }

        private void PrescribeMedications(params string[] drugs)
        {
            Console.WriteLine("Назначены препараты: ");
            foreach (string drug in drugs)
                Console.WriteLine($"    {drug}");
            Console.WriteLine();
        }
    }


    internal class DoctorSurgeon : Doctor
    {
        public DoctorSurgeon(string name, string qualificationCategory) : base(name, qualificationCategory) { }

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
        public DoctorDentist(string name, string qualificationCategory) : base(name, qualificationCategory) { }

        public override void Treat()
        {
            base.Treat();
            PerformeXRay();
            CarryOutTreatment();
            PerformeProsthetics();
        }

        private void PerformeXRay()
        {
            Console.WriteLine("Проведена рентгенография челюсти");
        }

        private void PerformeProsthetics()
        {
            Console.WriteLine("Проведено протезирование");
        }

        private void CarryOutTreatment()
        {
            Console.WriteLine("Проведено лечение кариеса и пульпита");
        }
    }
}
