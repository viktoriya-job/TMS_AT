namespace Delegate
{
    internal class Task1
    {
        public delegate int Random10Delegate();

        public void Run()
        {
            Random10Delegate random10Delegate = Random10;
            Console.WriteLine(random10Delegate());
        }

        private int Random10()
        {
            Random random = new Random();
            return random.Next(10);
        }
    }
}