namespace NUnitTest
{
    internal class PrePostConditionExample
    {

        protected int i = 0;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine($"{this}: OneTimeSetUp... {++i}");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine($"{this}: SetUp... {++i}");
        }

        [Test]
        public void Test()
        {
            Console.WriteLine($"{this}: Test... {++i}");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine($"{this}: TearDown... {++i}");
        }

        [OneTimeTearDown]
        public void FinishTests()
        {
            Console.WriteLine($"{this}: OneTimeTearDown... {++i}");
        }
    }
}
