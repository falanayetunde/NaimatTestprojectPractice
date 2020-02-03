using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProject.Pages;
using TestProject.Hooks;
using NUnit.Framework;



namespace TestProject.StepDefinitions
{

    [Binding]
    public class SelectedItemStepDefinitions
    {
        private SelectedItemPage selectedItemPage;
        private Context context;
        public SelectedItemStepDefinitions(SelectedItemPage _selectedItemPage, Context _context)
        {
            selectedItemPage = _selectedItemPage;
            context = _context;
        }

        [Given(@"that automation application has been successfully loaded")]
        public void GivenThatAutomationApplicationHasBeenSuccessfullyLoaded()

        {
            context.LaunchAnApplication();

        }


        [When(@"a user click on Woman tab")]
        public void WhenAUserClickOnWomanTab()
        {
            selectedItemPage.ClickOnWomen();
        }

        [When(@"a user click on Top")]
        public void WhenAUserClickOnTop()

        {
            selectedItemPage.ClickOnTop();
        }

        [When(@"a user click on Tshirt")]
        public void WhenAUserClickOnTshirt()

        {
            selectedItemPage.ClickOnTshirt();
        }

        [Then(@"'(.*)' is displayed")]
        public void FadedshortSleeveTshirtIsDisplayed(string expectedResult)
        {
            Assert.AreEqual(expectedResult, selectedItemPage.FadedShortSleeveTshirtsIsDisplayed());
        }


        [When(@"a user clicks on Tshirt tab")]
        public void WhenAUserClicksOnTshirtTab()
        {
            selectedItemPage.ClicksOnTshirtTab();
        }

        [When(@"a user clicks on Faded Short Sleeve Tshirts")]
        public void WhenAUserClicksOnFadedShortSleeveTshirts()
        {
            selectedItemPage.ClickOnShortSleeveTshirts();
        }

        [When(@"a user enters (.*) on the quantity field")]
        public void WhenAUserEnterOnTheQuantityField(string number)
        {
            selectedItemPage.EnterTheQuantity(number);
        }

        [When(@"a user select '(.*)' on the size field")]
        public void WhenAUserSelectOnTheSizeField(string sizeOption)
        {
            selectedItemPage.SelectSize(sizeOption);
        }

        [When(@"a user clicks on colour blue")]
        public void WhenAUserClicksOnColourBlue()
        {
            selectedItemPage.ClicksOnColour();
        }


        [When(@"a user clicks on add to cart")]
        public void WhenAUserClicksOnAddToCart()
        {
            selectedItemPage.ClicksOnAddToCart();
        }

        [Then(@"the '(.*)' message is displayed")]
        public void ThenTheMessageIsDisplayed(string expectedResult)
        {
            Assert.AreEqual(expectedResult, selectedItemPage.ProductMessageDisplayed());
        }


        [When(@"a user clicks on proceed to checkout")]
        public void WhenAUserClicksOnProceedToCheckout()
        {
            selectedItemPage.ClickOnProceedtoCheckOut();
        }

        [When(@"a user clicks on proceed To checkout")]
        public void WhenAUserClicksOnProceedtoCheckout()
        {
            selectedItemPage.ClickOnProceedtoCheckOut();
        }

        [When(@"a user fill-in email field addres '(.*)'")]
        public void WhenAUserFill_InEmailFieldAddres(string email)
        {
            selectedItemPage.FillInEmailField(email);
        }

        [When(@"a user clicks on create an account")]
        public void WhenAUserClicksOnCreateAnAccount()
        {
            selectedItemPage.ClickOnCreateAnAccount();
        }

        [Then(@"Your Personel Information is displayed")]
        public void ThenYourPersonelInformationIsDisplayed(string expectedResult)
        {
            Assert.AreEqual(expectedResult, selectedItemPage.YourPersonalInforationIsDisplayed());
        }

        //[When(@"a user clicks on sign in")]
        //public void WhenAUserClicksOnSignIn()
        //{
        //    selectedItemPage.ClicksOnsignIn();
        //}





        [AfterScenario]
        public void CloseAnApplication()
        {
            context.CloseAnApplication();
        }
    }
}
