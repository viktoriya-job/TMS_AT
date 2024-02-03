using LINQ.Helper;

namespace LINQ
{
    internal class Task2
    {
        public static void Run()
        {
            List<Client> _clientsList = new List<Client>()
            {
                new Client(0,2024,1,12),
                new Client(0,2024,2,14),
                new Client(1,2024,1,24),
                new Client(1,2024,2,8),
                new Client(2,2024,1,18),
                new Client(2,2024,2,18),
                new Client(3,2024,1,8),
                new Client(3,2024,2,10),
                new Client(4,2024,1,14),
                new Client(4,2024,2,16),
            };

            var minTrainingDuration = _clientsList.Where(client => client.TrainingDuration == _clientsList.Min(client => client.TrainingDuration)).Last();
            
            Console.WriteLine($"TrainingDuration: {minTrainingDuration.TrainingDuration}" +
                $", Year: {minTrainingDuration.Year}" +
                $", Month: {minTrainingDuration.Month}");
        }
    }
}