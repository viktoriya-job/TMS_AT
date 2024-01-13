namespace Delegate
{
    internal class Task1
    {
        public delegate int GetRandom();

        public void Run()
        {
            GetRandom getRandom = Random10;
            Console.WriteLine(getRandom());
        }

        private int Random10()
        {
            Random random = new Random();
            return random.Next(10);
        }
    }
}