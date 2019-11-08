using AutomationSession7.BaseFiles;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSession7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {

          
            SetUp();

            FnSendKeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendKeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

            /*Xpath Version*/


            driver.FindElement(By.Name("login")).Click();

            AfterTest();
           
            Console.ReadKey();
           
        }
    }
}
