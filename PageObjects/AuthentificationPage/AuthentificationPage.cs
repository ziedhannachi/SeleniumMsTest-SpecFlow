using AlissiaE2ETest.Utils;
using AlissiaE2ETest.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlissiaE2ETest.PageObjects.AuthentificationPage
{
    public class AuthentificationPage
    {

        public IWebDriver driver;

        public AuthentificationPage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète
        }

        [FindsBy(How = How.Id, Using = "CompanyLogin")]
        public IWebElement CompanyId;

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement UsernameId;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordName;

        [FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/form/fieldset/p/input")]
        public IWebElement BtnConnexionXpath;

        [FindsBy(How = How.ClassName, Using = "UserName")]
        public IWebElement SessionUserName;

        public void OuvrirLeSiteAlissia()
        {
            String URL = System.Configuration.ConfigurationManager.AppSettings["URL"];
            driver.Navigate().GoToUrl(URL);
        }

        public void OuvrirLeSiteAlissiaFormation()
        {
            String URL = System.Configuration.ConfigurationManager.AppSettings["URLFormation"];
            driver.Navigate().GoToUrl(URL);
        }

        public void SaisirCompanyLogin(string companyLogin)
        {
            CompanyId.SendKeys(companyLogin);
        }

        public void SaisirUsername(string username)
        {
            UsernameId.SendKeys(username);
        }

        public void SaisirMotDePass(string motdepasse)
        {
            PasswordName.SendKeys(motdepasse);
        }

        public void ClickConnexion()
        {
            BtnConnexionXpath.Click();
        }

        public string GetSessionUserName()
        {
            return SessionUserName.Text;
        }
    }
}
