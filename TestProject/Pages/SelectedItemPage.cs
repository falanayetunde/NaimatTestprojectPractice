using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProject.Pages
{
    public class SelectedItemPage
    {
        private Context context;

        public SelectedItemPage(Context _context)
        {
            context = _context;
        }

        private By womenLink = By.XPath("//*[@id='block_top_menu']/ul/li[1]/a");
        private By topTab = By.XPath("//*[@id='categories_block_left']/h2");
        private By Tshirt = By.XPath("//*[@id='categories_block_left']/div/ul/li[1]/a");
        private By fadedShortSleeveTshirts = By.XPath("//*[@id='center_column']/ul/li/div/div[2]/h5/a");

        private By dressesTab = By.XPath("//*[@id='block_top_menu']/ul/li[2]/a");
        private By tshirtTab = By.XPath("//*[@id='block_top_menu']/ul/li[3]");
        private By casualDresses = By.XPath("//*[@id='categories_block_left']/div/ul/li[1]/a");
        private By printedDress = By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/h5/a");
        private By addToCart = By.Id("add_to_cart");
        private By productMessage = By.CssSelector("h2:nth-child(2)");
        private By shortSleeve = By.CssSelector(".product-container, .product-image");
        private By quantityWanted = By.Id("quantity_wanted");
        private By shirtSize = By.Id("group_1");
        private By shirtColour = By.Id("color_14");

        private By proceedtocheckout = By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span");
        private By proceedTocheckout = By.XPath("//*[@id='center_column']/p[2]/a[1]/span");
        private By fillInemailaddress = By.XPath("//*[@id='email_create']");
        private By createAnAccount = By.XPath("//*[@id='email_create']");
        private By yourPersonalInformation = By.XPath("//*[@id='account - creation_form']/div[1]/h3");

        private By signIn = By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a");
        private By fillInEmailAddress = By.XPath("//*[@id='email']");
        private By fillInpassword = By.XPath("//*[@id='passwd']");
        private By signInButton = By.XPath("//*[@id='SubmitLogin']/span");
        private By returnHomeButton = By.XPath("//*[@id='columns']/div[1]/a");


        public void ClickOnWomen()

        {
            context.driver.FindElement(womenLink).Click();
        }

        public void ClickOnTop()
        {
            Thread.Sleep(1000);
            context.driver.FindElement(topTab).Click();

        }


        public void ClickOnTshirt()
        {
            Thread.Sleep(200);
            context.driver.FindElement(Tshirt).Click();
        }


        public string FadedShortSleeveTshirtsIsDisplayed()
        {
            Thread.Sleep(1000);
            return context.driver.FindElement(fadedShortSleeveTshirts).Text;
        }


        public void ClicksOnDresses()
        {
            context.driver.FindElement(dressesTab).Click();
        }

        public void ClicksOnTshirtTab()
        {
            context.driver.FindElement(tshirtTab);
        }

        public void ClickOnShortSleeveTshirts()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(shortSleeve).Click();
        }

        public void EnterTheQuantity(string number)
        {
            IWebElement enterNumber = context.driver.FindElement(quantityWanted);
            enterNumber.Clear();
            enterNumber.SendKeys(number);

        }

        public void SelectSize(string sizeOption)
        {

            new SelectElement(context.driver.FindElement(shirtSize)).SelectByIndex(1);
        }


       public void ClicksOnColour()
        {
            context.driver.FindElement(shirtColour).Click();
        }

        public void ClicksOnAddToCart()
        {
            Thread.Sleep(500);
            context.driver.FindElement(addToCart).Click();
        }

        public string ProductMessageDisplayed()
        {
            Thread.Sleep(1000);
            return context.driver.FindElement(productMessage).Text.Trim();
        }

        public void ClickOnProceedtoCheckOut() 
        {
            context.driver.FindElement(proceedtocheckout).Click();
        }

        public void ClickOnProceedToCheckOut() 
        {
            context.driver.FindElement(proceedTocheckout).Click();
        }

        public void FillInEmailField(string emailData)
        {
            IWebElement emailTxtField = context.driver.FindElement(emailField);
            emailTxtField.Clear();
            emailTxtField.SendKeys(emailData);
        }

        public void ClickOnCreateAnAccount() 
        {
            context.driver.FindElement(createAnAccount).Click();
        }

        public string YourPersonalInforationIsDisplayed() 
        
        {
            return context.driver.FindElement(yourPersonalInformation).Text;
        }



    }
}
