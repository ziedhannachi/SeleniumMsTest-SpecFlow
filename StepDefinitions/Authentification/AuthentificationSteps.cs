using AlissiaE2ETest.PageObjects.AuthentificationPage;
using AlissiaE2ETest.PageObjects.PageHomePages;
using AlissiaE2ETest.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AlissiaE2ETest.StepDefinitions.Authentification
{
    [Binding]
    public class AuthentificationSteps
    {
        
        private IWebDriver driver;
        public static AuthentificationPage Authentification;

        static CommonMethod comM;
        static HomePage PgHome;

        public AuthentificationSteps(IWebDriver _driver)
        {
            driver = _driver;

            Authentification = new AuthentificationPage(driver);
            comM = new CommonMethod(driver);
            PgHome = new HomePage(driver);
        }

        [Given(@"naviguer à l'application")]
        public void GivenNaviguerALApplication()
        {
            Authentification.OuvrirLeSiteAlissia();
            Thread.Sleep(4000);
        }

        [When(@"entrer le company login '(.*)'")]
        public void WhenEntrerLeCompanyLogin(string companyLogin)
        {
            Authentification.SaisirCompanyLogin(companyLogin);
        }

        [When(@"entrer le username '(.*)'")]
        public void WhenEntrerLeUsername(string username)
        {
            Authentification.SaisirUsername(username);
        }


        [When(@"entrer le mot de passe '(.*)'")]
        public void WhenEntrerLeMotDePasse(string MotPasse)
        {
            Authentification.SaisirMotDePass(MotPasse);
        }
        
        [When(@"cliquer sur Connexion")]
        public void WhenCliquerSurConnexion()
        {
            Authentification.ClickConnexion();
        }
        
        [Then(@"utilisateur connecté à l'application")]
        public void ThenUtilisateurConnecteALApplication()
        {
            comM.ImplicitWait();

            String session = Authentification.GetSessionUserName();

            Assert.IsTrue(session.Contains("Zied Hannachi"));

            comM.ImplicitWait();
        }
    }
}
