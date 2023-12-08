
namespace OOP.Clinic
{
    internal class TreatmentPlan
    {
        public int TreatmentPlanCode { get; set; } = 0;
        public List<string> TreatmentPlanList = new List<string>(16);

        public TreatmentPlan(int treatmentPlanCode) => TreatmentPlanCode = treatmentPlanCode;

        public List<string> AddEntriesToTreatmentPlan(params string[] entries)
        {
            foreach (string entry in entries)
                TreatmentPlanList.Add(entry);

            return TreatmentPlanList;
        }

        public void PrintTreatmentPlan()
        {
            Console.WriteLine("\nПлан лечения:");
            foreach (string entry in TreatmentPlanList)
                Console.WriteLine(entry);
        }
    }
}
