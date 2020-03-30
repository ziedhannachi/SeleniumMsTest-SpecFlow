using AlissiaE2ETest.PageObjects.AuthentificationPage;
using AlissiaE2ETest.PageObjects.PageHomePages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AlissiaE2ETest.StepDefinitions.ConnecterAlissia
{
    [Binding]
    public class ConnecterAAlissiaSteps
    {
        private IWebDriver driver;


        static AuthentificationPage authentification;
        static HomePage homeP;

        public ConnecterAAlissiaSteps(IWebDriver _driver)
        {
            driver = _driver;
            authentification = new AuthentificationPage(driver);
            homeP = new HomePage(driver);
        }

        [Given(@"naviguer à l'application Alissia Formation")]
        public void GivenNaviguerALApplicationAlissiaFormation()
        {
            authentification.OuvrirLeSiteAlissiaFormation();
            Thread.Sleep(4000);
        }


        [Then(@"utilisateur connecté à l'(.*)'accueil est affichée")]
        public void ThenUtilisateurConnecteALAccueilEstAffichee(string p0)
        {
            Assert.IsTrue(homeP.AccueilLinkClass().Contains("active"));
        }

    }
}
