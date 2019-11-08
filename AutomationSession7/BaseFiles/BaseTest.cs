using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSession7.BaseFiles
{
    class BaseTest
    {
        //VARIABLES
        /*Webdriver Instance*/
        public static IWebDriver driver;

        /*URL for Webdriver*/
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");

        //METHODS
        /*Initialize the driver and indicates the url*/
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserName;

        }

        /*Clear and Send Text to a specific field*/
      public static void FnSendKeyAndClear(By by, string pstrText )
        {

            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
            


        }

        /*Close the browser and Quit the selenium instance*/
        public static void AfterTest()
        {

            driver.Close();
            driver.Quit();

        }




    }
}
