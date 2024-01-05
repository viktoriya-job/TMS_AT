namespace Generics
{
    internal class Task3
    {
        public static void Run()
        {
            var gasEngine = new GasEngine();
            var carDiesel = new Car<GasEngine>(gasEngine);

            carDiesel.Run();
        }
    }
}