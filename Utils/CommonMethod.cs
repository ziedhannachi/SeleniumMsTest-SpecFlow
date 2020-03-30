﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlissiaE2ETest.Utils
{
    public class CommonMethod
    {

        private IWebDriver driver;

        public CommonMethod(IWebDriver _driver)
        {
            driver = _driver;
        }

        //Switch back to the main window
        public void SwitchBackIFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        //switch command
        public void SwitchCommandIFrame()
        {
            driver.SwitchTo().Frame(0);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void ExplicitWait()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("elementId")));
        }

        public void scroll(int x, int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // This  will scroll down the page by  1000 pixel vertical		
            js.ExecuteScript("window.scrollBy(100,500)");
        }

        public void MoseMove(IWebElement Element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var lement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='SearchEngineTreeView']/ul/li[1]")));
            Actions action = new Actions(driver);

            action.MoveToElement(Element).Build().Perform();
        }

        public int ParcourList(int i, string xpathGauche, string xpathDroite, string text)
        {
            int trouve = 0;
            while ((IsElementPresent(By.XPath(xpathGauche + i + xpathDroite)) == true) && (trouve == 0))
            {
                if (driver.FindElement(By.XPath(xpathGauche + i + xpathDroite)).Text.Contains(text))
                {
                    trouve = 1;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }

        public IList<string> Listinfo(string xpath1, string xpath2, string xpath3, int tr)
        {
            IList<string> List = new List<string>();

            for (int i = 2; i < 5; i++)
            {
              List.Add(driver.FindElement(By.XPath(xpath1 + tr + xpath2 + i + xpath3)).Text);
            }


            return List;
        }

        public IList<string> Listinfo(string xpath1, string xpath2)
        {
            IList<string> List = new List<string>();

            for (int i = 1; i < 10; i++)
            {
                List.Add(driver.FindElement(By.XPath(xpath1 + i + xpath2)).Text);
            }


            return List;
        }

        public IList<string> ContactListInfo(string xpath1, string xpath2)
        {
            IList<string> List = new List<string>();

            for (int i = 1; i < 4; i++)
            {
                List.Add(driver.FindElement(By.XPath(xpath1 + i + xpath2)).Text);
            }


            return List;
        }

        public int ParcourListWithEquals(int i, string xpathGauche, string xpathDroite, string text)
        {
            int trouve = 0;
            while ((IsElementPresent(By.XPath(xpathGauche + i + xpathDroite)) == true) && (trouve == 0))
            {
                if (driver.FindElement(By.XPath(xpathGauche + i + xpathDroite)).Text.Equals(text))
                {
                    trouve = 1;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }


        public int ParcourListNomComplet(int i, string xpathGauche, string xpathDroite, string text)
        {
            int Result = 0;
            while ((IsElementPresent(By.XPath(xpathGauche + i + xpathDroite)) == true) && (Result == 0))
            {
                if (driver.FindElement(By.XPath(xpathGauche + i + xpathDroite)).Text.Contains(text))
                {
                    i++;
                }
                else
                {
                    Result = 1;
                }
            }

            return Result;
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    }
}
