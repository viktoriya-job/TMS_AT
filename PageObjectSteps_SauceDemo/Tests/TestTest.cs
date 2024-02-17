using PageObjectStepsSauceDemo.Steps;
using PageObjectStepsSauceDemo.Pages;

namespace PageObjectStepsSauceDemo.Tests
{
    public class TestTest: BaseTest
    {
        [Test]
        public void CreateInventoryPage()
        {
            InventoryPage inventoryPage = LoginSteps.SuccessLogin();
            Console.WriteLine(inventoryPage.ItemsSmall[0].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[0].AddButton.GetAttribute("name"));
            Console.WriteLine(inventoryPage.ItemsSmall[0].IsItemNotAddedToCart());

            inventoryPage.ItemsSmall[0].AddItem();

            Console.WriteLine(inventoryPage.ItemsSmall[0].IsItemAddedToCart());

            Console.WriteLine();
            Console.WriteLine(inventoryPage.ItemsSmall[1].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[1].AddButton.GetAttribute("name")); 
            Console.WriteLine();
            Console.WriteLine(inventoryPage.ItemsSmall[2].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[2].AddButton.GetAttribute("name")); 
            Console.WriteLine();
            Console.WriteLine(inventoryPage.ItemsSmall[3].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[3].AddButton.GetAttribute("name")); 
            Console.WriteLine();
            Console.WriteLine(inventoryPage.ItemsSmall[4].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[4].AddButton.GetAttribute("name")); 
            Console.WriteLine();
            Console.WriteLine(inventoryPage.ItemsSmall[5].ItemTitle.Text); 
            Console.WriteLine(inventoryPage.ItemsSmall[5].AddButton.GetAttribute("name")); 
        }
    }
}
