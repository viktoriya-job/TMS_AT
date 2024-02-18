using Wrappers.Pages.Heroku;

namespace Wrappers.Tests.HerokuTests
{
    public class TestTest : BaseTest
    {
        [Test]
        public void testtest()
        {
            AddRemovePage addRemovePage = new AddRemovePage(Driver, true);

            Console.WriteLine(addRemovePage.AddButton);
            Console.WriteLine(addRemovePage.AddButton1);

        }
    }
}
