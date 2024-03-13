using NLog;

namespace Task1.Tests
{
    [TestFixture]
    public class NLogTest
    {
        protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        [Test]
        public void LevelsTest()
        {
            Logger.Log(LogLevel.Info, "Some info");

            Logger.Trace("message Trace");
            Logger.Debug("message Debug");
            Logger.Info("message Info");
            Logger.Warn("message Warn");
            Logger.Error("message Error");
            Logger.Fatal("message Fatal");
        }

        [Test]
        public void ExceptionLogTest()
        {
            try
            {
                throw new AssertionException("Какая-то ошибка..");
            }
            catch (Exception e)
            {
                Logger.Error(e, "Логируем ошибку....");
            }
        }
    }
}
