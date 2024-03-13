using NLogExample.Core;

namespace Task1.Tests
{
    [SetUpFixture]
    public class BaseSuite
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        [OneTimeSetUp]
        public static void SuiteSetup()
        {
            new NLogConfig().Config();
            Logger.Info("NLOG Setted Up");
        }
    }
}
