using SpecFlowTestProject2.Driver;

namespace SpecFlowTestProject2.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly Browser _browser;

        public Hooks(Browser browser)
        {
            _browser = browser;
        }

        [AfterScenario]
        public void CloseDriver()
        {
            _browser.Driver.Quit();
        }
    }
}
