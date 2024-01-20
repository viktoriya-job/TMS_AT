
namespace LINQ
{
    internal class Client
    {
        public int Code { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TrainingDuration { get; set; }

        public Client(int code, int year, int month, int trainingDuration)
        {
            Code = code;
            Year = year;
            Month = month;
            TrainingDuration = trainingDuration;
        }
    }
}
