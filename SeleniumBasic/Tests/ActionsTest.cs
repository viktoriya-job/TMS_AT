using System.Collections.ObjectModel;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests
{
    public class ActionsTest : BaseTest
    {
        [Test]
        public void HoverTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

            var actions = new Actions(Driver);

            var targetElements = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.CssSelector(".figure"));
            actions
                .MoveToElement(targetElements[0], 10, 10)
                .Click(WaitsHelper.WaitForExists(By.CssSelector("[href='/users/1']")))
                .Build()
                .Perform();
            Thread.Sleep(2000);
            Assert.That(WaitsHelper.WaitForElementInvisible(targetElements[0]));
        }

        [Test]
        public void DrugAndDropTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");

            var actions = new Actions(Driver);

            var targetElementA = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-a"));
            var targetElementB = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-b"));

            actions
                .DragAndDrop(targetElementA, targetElementB)
                .Pause(TimeSpan.FromSeconds(2))
                .Build()
                .Perform();
        }

        [Test]
        public void CheckBoxTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var actions = new Actions(Driver);

            var targetElement = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("#checkboxes input"));

            actions
                .MoveToElement(targetElement)
                .Click()
                .Pause(TimeSpan.FromSeconds(2))
                .Build()
                .Perform();
        }

        [Test]
        public void FileUploadTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
            // Получаем путь к исполняемому файлу (exe)
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Конструируем путь к файлу внутри проекта
            string filePath = Path.Combine(assemblyPath, "Resources", "msg1205352859-4623.jpg");
            Console.WriteLine(filePath);

            fileUploadPath.SendKeys(filePath);

            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
            Thread.Sleep(5000);
        }
    }
}
