using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    [TestFixture]
    class travelTestcase
    {
        [SetUp]
        public static void Main(String[] args)
        {
            Console.WriteLine("first test");
        }
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jt-dev.azurewebsites.net/#/SignUp");
            WebElement selectElement =(WebElement)driver.FindElement(By.XPath("//*[@id='language']/input[1]"));
            SelectElement select = new SelectElement(selectElement);
            List<WebElement> allOptions = (List<WebElement>) select.Options;
            List<String> str = new List<string>();
            List<String> str1 = new List<string>();
            str1.Add("English");
            str1.Add("Dutch");

            foreach (WebElement option in allOptions)
               str.Add(option.Text);
            str.Sort();
            str1.Sort();
            Assert.Equals(str, str1);

            driver.FindElement(By.Id("name")).SendKeys("Gayatri Deshpande");
            driver.FindElement(By.Id("orgName")).SendKeys("Mindbody");
            driver.FindElement(By.Id("singUpEmail")).SendKeys("deshpandeg6352gmail.com");

            driver.FindElement(By.XPath("//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[4]/label/input")).Click();

            driver.FindElement(By.XPath("//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[5]/button")).Click();
        }
    }
}
