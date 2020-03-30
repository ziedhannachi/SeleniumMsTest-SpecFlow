using AlissiaE2ETest.PageObjects.PageHomePages;
using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlissiaE2ETest.PageObjects.RechercheAvancée;
using OpenQA.Selenium.Support.UI;
using AlissiaE2ETest.PageObjects.AuthentificationPage;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace AlissiaE2ETest.StepDefinitions.Recherche
{
    [Binding]
    public class RechercheSteps
    {

        private IWebDriver driver;
        public static AuthentificationPage Authentification;

        static CommonMethod comM;
        static HomePage homePage;
        static RechercheAvancéePage rechercheAvancée;

        public RechercheSteps(IWebDriver _driver)
        {
            driver = _driver;

            Authentification = new AuthentificationPage(driver);
            comM = new CommonMethod(driver);
            homePage = new HomePage(driver);
            rechercheAvancée = new RechercheAvancéePage(driver);
        }



        [When(@"Saisir un nom du dossier inexistant '(.*)'")]
        public void WhenSaisirUnNomDuDossierInexistant(string folderName)
        {
            homePage.SaisirNomDossier(folderName);
        }

        [When(@"cliquer Entrer")]
        public void WhenCliquerEntrer()
        {
            homePage.ClickEntrer();

            comM.ImplicitWait();

            Thread.Sleep(5000);
        }

        [Then(@"La page Home reste affichée")]
        public void ThenLaPageHomeResteAffichee()
        {
            Assert.IsTrue(homePage.AlertTest().Contains("Aucun résultat trouvé"));
            Thread.Sleep(5000);

        }


        [When(@"Cliquer sur le bouton recherche avancée")]
        public void WhenCliquerSurLeBoutonRechercheAvancee()
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            homePage.ClickSearchButton();
        }

        [When(@"Cliquer sur Tiers")]
        public void WhenCliquerSurTiers()
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            rechercheAvancée.TuersButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur Donneur d'ordre")]
        public void WhenCliquerSurDonneurDOrdre()
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            rechercheAvancée.DonneurOrdreButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur le bouton Donneur D'ordre")]
        public void WhenCliquerSurLeBoutonDonneurDOrdre()
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            rechercheAvancée.DonneurOrdreClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur le bouton égale à")]
        public void WhenCliquerSurLeBoutonEgaleA()
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            rechercheAvancée.EgaleButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Saisir la valeur '(.*)'")]
        public void WhenSaisirLaValeur(string valeur)
        {
            Thread.Sleep(5000);
            comM.ImplicitWait();
            rechercheAvancée.ValeurInputSendKey(valeur);
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur le bouton Valider")]
        public void WhenCliquerSurLeBoutonValider()
        {
            comM.ImplicitWait();
            rechercheAvancée.ValiderButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur le bouton Recherche")]
        public void WhenCliquerSurLeBoutonRecherche()
        {
            comM.ImplicitWait();
            rechercheAvancée.RechercheButtonClick();            
        }

        [Then(@"Vérification du temps d'affichage du résultat et La liste des informations est affiché")]
        public void ThenVerificationDuTempsDAffichageDuResultatEtLaListeDesInformationsEstAffiche()
        {
            var time1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Assert.IsTrue(rechercheAvancée.ListInformationDisplayed());
            var time2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long time = time2 - time1;
            Hooks._scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Log(Status.Info, MarkupHelper.CreateLabel(time.ToString() + " millisecond", ExtentColor.Black));
        }

        [When(@"Cliquer sur le bouton Paramétrage des colonnes")]
        public void WhenCliquerSurLeBoutonParametrageDesColonnes()
        {
            Thread.Sleep(1000);
            rechercheAvancée.ParametrageButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Glisser Statut dans la colonne Colonnes sélectionnées")]
        public void WhenGlisserStatutDansLaColonneColonnesSelectionnees()
        {
            Thread.Sleep(1000);
            rechercheAvancée.StatutDragAndDrop();
            Thread.Sleep(1000);
            Thread.Sleep(1000);

        }

        [When(@"Cliquer sur le bouton Sauvegarder")]
        public void WhenCliquerSurLeBoutonSauvegarder()
        {

            rechercheAvancée.SauvegarderButtonClick();
            Thread.Sleep(1000);

        }

        [Then(@"La colone Statut doit être affichée dans le tableau")]
        public void ThenLaColoneStatutDoitEtreAfficheeDansLeTableau()
        {
            Assert.IsTrue(rechercheAvancée.ColonneStatutTest().Contains("Statut"));
            Thread.Sleep(1000);
            rechercheAvancée.ParametrageButtonClick();
            Thread.Sleep(1000);
            rechercheAvancée.StatutDragAndDropInverse();
            rechercheAvancée.SauvegarderButtonClick();

        }

        [When(@"Cliquer sur le bouton Sauvegarder la requête")]
        public void WhenCliquerSurLeBoutonSauvegarderLaRequete()
        {
            Thread.Sleep(2000);
            rechercheAvancée.SauvegardRequetButtonClick();
        }

        [When(@"Cliquer sur Sauvegarder")]
        public void WhenCliquerSurSauvegarder()
        {
            Thread.Sleep(2000);
            rechercheAvancée.SauvegardButtonClick();
        }

        [When(@"Cliquer sur le bouton Fermer")]
        public void WhenCliquerSurLeBoutonFermer()
        {
            Thread.Sleep(2000);
            rechercheAvancée.FermerButtonClick();
            rechercheAvancée.FermerButtonClick();
        }

        [When(@"Accéder à la page dossier")]
        public void WhenAccederALaPageDossier()
        {
            Thread.Sleep(2000);
            rechercheAvancée.DossierClick();
        }

        [Then(@"La requête est affiché dans la la partie Mes requêtes")]
        public void ThenLaRequeteEstAfficheDansLaLaPartieMesRequetes()
        {
            Assert.IsTrue(rechercheAvancée.RequeteText().Contains("Donneur d'ordre égal à P & L"));

        }

        [Then(@"Execution scénarion numéro ""(.*)""")]
        public void ThenExecutionScenarionNumero(int id)
        {
            
        }




    }
}
