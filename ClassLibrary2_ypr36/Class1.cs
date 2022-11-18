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
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver(); //создание и инициализации на браузер

        [TestCase]//Тестовый случай
        public void maintTitle()
        {
            webDriver.Url = "https://odisseya-tur.com/"; //установка адреса и переход в браузер
            Assert.AreEqual("Турагентство Одиссея Рязань - туристическое агентство, турфирма", webDriver.Title);// Предположение,что заловок сайта равен указанной строки
            webDriver.Close(); //закрытие окна браузера
        }

        [TearDown]//метод, который вызывают после всех тестов
        public void testEnd()
        { //освобождение ссылки на браузер
            webDriver.Quit();
        }
    }
}
