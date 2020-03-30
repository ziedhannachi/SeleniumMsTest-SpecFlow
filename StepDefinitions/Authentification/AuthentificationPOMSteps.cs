using AlissiaE2ETest.PageObjects.AuthentificationPage;
//using AlissiaE2ETest.PageObjects.PageHomePages;
using AlissiaE2ETest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AlissiaE2ETest.StepDefinitions
{
    [Binding]
    public class AuthentificationPOMSteps
    {
        private IWebDriver driver;
        public static AuthentificationPage Authentification;

        static CommonMethod comM;

        public AuthentificationPOMSteps(IWebDriver _driver)
        {
            driver = _driver;

           Authentification = new AuthentificationPage(driver);
           comM = new CommonMethod(driver);
        }

        
        //HomePage PgHome = new HomePage(driver);

        [Given(@"Ouvrir le Site Alissia")]
        public void GivenOuvrirLeSiteAlissia()
        {

            Authentification.OuvrirLeSiteAlissia();
            Thread.Sleep(4000);
            
        }

        [When(@"Saisir le Company Login '(.*)'")]
        public void WhenSaisirLeCompanyLogin(string loginCompany)
        {
            Authentification.SaisirCompanyLogin(loginCompany);
        }

        [When(@"Saisir le Username '(.*)'")]
        public void WhenSaisirLeUsername(string username)
        {
            Authentification.SaisirUsername(username);
        }

        [When(@"Saisir Mot de passe '(.*)'")]
        public void WhenSaisirMotDePasse(string motdepasse)
        {
            Authentification.SaisirMotDePass(motdepasse);
        }


        [When(@"Appuyer sur le bouton Connexion")]
        public void WhenAppuyerSurLeBoutonConnexion()
        {
            Authentification.ClickConnexion();
        }

        [Then(@"Redirection à la page Home")]
        public void ThenRedirectionALaPageHome()
        {
            comM.ImplicitWait();

            String session = Authentification.GetSessionUserName();

            Assert.IsTrue(session.Contains("Zied Hannachi"));

            comM.ImplicitWait();
        }

    }
}
