using AutomationSession7.BaseFiles;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSession7.TestCases
{
    class Prueba1 : BaseTest
    {

        [Test]
        public void TestLogin1()
        {

            FnSendKeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendKeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

        }


        [Test]
        public void TestLogin2()
        {

            /*Xpath Version*/
            FnSendKeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendKeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));

        }


        [Test]
        public void GetElementHrefList()
        {

            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));
            foreach (IWebElement el in ElementList)
            {

                el.GetAttribute("href");
                Assert.Fail();
            }


        }
    }
}
