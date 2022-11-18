using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2_ypr36
{
    [TestFixture]//создание теста
    public class Class2
    {
        IWebDriver webDriver = new ChromeDriver(); //создание и инициализации на браузер

        [TestCase]//Тестовый случай
        public void yaru_reguest()
        {
            webDriver.Url = "https://odisseya-tur.com/"; //установка адреса и переход в браузер
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"text\"]"));
            search.SendKeys("Туры по России");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/table/tbody/tr[3]/td[1]/table[1]/tbody/tr[4]/td/a "));
            button.Click();
        }
    }
}
