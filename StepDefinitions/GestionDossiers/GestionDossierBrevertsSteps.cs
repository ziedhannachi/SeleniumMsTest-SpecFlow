using AlissiaE2ETest.PageObjects.Dossiers;
using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AlissiaE2ETest.StepDefinitions.GestionDossiers
{
    [Binding]
    public class GestionDossierBrevertsSteps
    {
        private IWebDriver driver;


        static CommonMethod comM;
        static Dossiers dossier;


        public GestionDossierBrevertsSteps(IWebDriver _driver)
        {
            driver = _driver;
            comM = new CommonMethod(driver);
            dossier = new Dossiers(driver);
        }

        [Given(@"Cliquer dans l’onglet Dossiers")]
        public void GivenCliquerDansLOngletDossiers()
        {
            Thread.Sleep(4000);
            dossier.DossiersLinkClick();
        }
        
        [Given(@"Cliquer sur dossier Breverts")]
        public void GivenCliquerSurDossierBreverts()
        {
            Thread.Sleep(3000);
            dossier.BrevetsClick();
        }
        
        [When(@"Sélectionner Brevet français d’origine française dans le champ Prestation")]
        public void WhenSelectionnerBrevetFrancaisDOrigineFrancaiseDnaLeChampPrestation()
        {
            Thread.Sleep(3000);
            dossier.PréstationListClick();

            Thread.Sleep(3000);
            dossier.BrevetFrançaisOrigineFrançaiseClick();
        }

        [When(@"Cliquer sur Suivant du popup")]
        public void WhenCliquerSurSuivantDuPopup()
        {
            Thread.Sleep(5000);
            dossier.SuivantButtonClick();
        }


        [When(@"Cliquer sur Titre abrégé de la ligne créée")]
        public void WhenCliquerSurTitreAbregeDeLaLigneCreee()
        {
            Thread.Sleep(8000);
            dossier.TitreAbrégéClick();
        }
        
        [When(@"Saisir '(.*)'")]
        public void WhenSaisir(string titreAbrégé)
        {
            Thread.Sleep(2000);
            dossier.TitreAbrégéSendKeys(titreAbrégé);
        }
        
        [When(@"Cliquer sur Titre de la ligne créée")]
        public void WhenCliquerSurTitreDeLaLigneCreee()
        {
            Thread.Sleep(2000);
            dossier.TitleTextClick();
        }
        
        [When(@"Saisir '(.*)' dand le champ Titre")]
        public void WhenSaisirDandLeChampTitre(string titre)
        {
            Thread.Sleep(2000);
            dossier.TitleTextSendKeys(titre);
        }
        
        [When(@"Cliquer sur le bouton Ajouter un tiers Donneurs d'ordre")]
        public void WhenCliquerSurLeBoutonAjouterUnTiersDonneursDOrdre()
        {
            Thread.Sleep(5000);
            dossier.AjouterTiersDonneurOrdreClick();
        }
        
        [When(@"Saisir '(.*)' dans Nom abrégé")]
        public void WhenSaisirDansNomAbrege(string nomAbrégé)
        {
            Thread.Sleep(5000);
            dossier.NomAbrégéDonneurOrdreSendKeys(nomAbrégé);
        }
        
        [When(@"Cliquer sur le bouton Ajouter un tiers inventeur")]
        public void WhenCliquerSurLeBoutonAjouterUnTiersInventeur()
        {
            
        }
    }
}
