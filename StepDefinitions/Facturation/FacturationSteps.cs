using AlissiaE2ETest.PageObjects.Facturation;
using AlissiaE2ETest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace AlissiaE2ETest.StepDefinitions
{
    [Binding]
    public class FacturationSteps
    {
        private IWebDriver driver;


        static CommonMethod comM;
        static FacturationPage facturation;

        public FacturationSteps(IWebDriver _driver)
        {
            driver = _driver;

            facturation = new FacturationPage(driver);
            comM = new CommonMethod(driver);

        }

        [When(@"Cliquer sur le checkBox procédure")]
        public void WhenCliquerSurLeCheckBoxProcedure()
        {
            facturation.ProcedureCheckBoxClick();
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur l'étape Avis de dépôts")]
        public void WhenCliquerSurLEtapeAvisDeDepots()
        {
            facturation.AvisDepotClick();
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur Valorisation DEPOT")]
        public void WhenCliquerSurValorisationDEPOT()
        {
            Thread.Sleep(10000);
            facturation.ValorisationDépôtClick();
        }

        [When(@"Cliquer sur Val/Fac")]
        public void WhenCliquerSurValFac()
        {
            Thread.Sleep(5000);
            facturation.Val_FacClick();
            
        }

        [Then(@"La valorisation est bien présente dans En cours")]
        public void ThenLaValorisationEstBienPresenteDansEnCours()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(facturation.ValorisationDépôtText().Contains("Valorisation DEPOT"));
        }

        [When(@"Cliquer sur la Valorisation DEPOT")]
        public void WhenCliquerSurLaValorisationDEPOT()
        {
            facturation.ValorisationDépôtEtapeClick();
        }

        [Then(@"'(.*)' est affiché pour le total du libellé dépôt en ligne")]
        public void ThenEstAffichePourLeTotalDuLibelleDepotEnLigne(string totalDépôtEnLigne)
        {
            Thread.Sleep(8000);
            Assert.IsTrue(facturation.DépôtEnLigneTotal().Contains(totalDépôtEnLigne));
        }

        [When(@"Cliquer sur l'état du libellé Envoi recommandé")]
        public void WhenCliquerSurLEtatDuLibelleEnvoiRecommande()
        {
            Thread.Sleep(2000);
            facturation.EtatEnvoirecommandéClick();
        }

        [When(@"Modifier l'état à non facturable")]
        public void WhenModifierLEtatANonFacturable()
        {
            Thread.Sleep(2000);
            facturation.NonFacturableClick();
        }

        [When(@"Modifier la taxe du libellé Forfait administratif du dépôt à '(.*)' EUR pour valorisation")]
        public void WhenModifierLaTaxeDuLibelleForfaitAdministratifDuDepotAEURPourValorisation(string taxe)
        {
            Thread.Sleep(2000);
            facturation.TaxeForfaitValorisationAdministratif();

            Thread.Sleep(2000);
            facturation.TaxeForfaitAdministratifValorisationInputSendKeys(taxe);
        }

        [When(@"Cliquer sur bouton Sauvegarder")]
        public void WhenCliquerSurBoutonSauvegarder()
        {
            facturation.SauvegarderButtonClick();
            Thread.Sleep(7000);
        }

        [When(@"Cliquer sur le checkBox Facturation")]
        public void WhenCliquerSurLeCheckBoxFacturation()
        {
            Thread.Sleep(2000);
            facturation.FacturationCheckBoxClick();

            Thread.Sleep(10000);
        }

        [When(@"Modifier la taxe du libellé Forfait administratif du dépôt à '(.*)' EUR pour Facturation")]
        public void WhenModifierLaTaxeDuLibelleForfaitAdministratifDuDepotAEURPourFacturation(string taxe)
        {

            facturation.TaxeForfaitFactorationAdministratif();
            Thread.Sleep(2000);

            facturation.TaxeForfaitAdministratifFacturationInputSendKeys(taxe);
        }

        [Then(@"La ligne Forfait administratif du dépôt est en gras")]
        public void ThenLaLigneForfaitAdministratifDuDepotEstEnGras()
        {
            Assert.AreEqual(facturation.BoldText(), "700");
            Thread.Sleep(2000);
        }

        [When(@"Cliquer sur le bouton Export cognos")]
        public void WhenCliquerSurLeBoutonExportCognos()
        {
            facturation.ExportCognosButtonClick();
            Thread.Sleep(5000);
        }

        [When(@"Cliquer sur le bouton télécharger le fichier")]
        public void WhenCliquerSurLeBoutonTelechargerLeFichier()
        {
            facturation.TéléchargerFileButtonClick();
            Thread.Sleep(30000);
        }

        [Then(@"Le fichier doit être téléchargé")]
        public void ThenLeFichierDoitEtreTelecharge()
        {
            Assert.IsFalse(facturation.ExistFile().Equals(0));
            facturation.DeleteFile();
        }

        [When(@"Cliquer sur l'icone Facturation")]
        public void WhenCliquerSurLIconeFacturation()
        {
            Thread.Sleep(8000);
            facturation.FacturationIconClick();
        }

        [When(@"Cliquer sur le bouton Facturation")]
        public void WhenCliquerSurLeBoutonFacturation()
        {
            Thread.Sleep(5000);
            facturation.FacturationButtonClick();
        }

        [Then(@"'(.*)' euros est le total des frais et honoraires pour le tiers '(.*)'")]
        public void ThenEurosEstLeTotalDesFraisEtHonorairesPourLeTiers(string FraisH, string Tiers)
        {
            Thread.Sleep(10000);

            Assert.IsTrue(facturation.FraisHonorairesText().Contains(FraisH));
            Assert.IsTrue(facturation.TiersText().Contains(Tiers));
        }

        [When(@"Cliquer sur le bouton Modifier")]
        public void WhenCliquerSurLeBoutonModifier()
        {
            Thread.Sleep(5000);
            facturation.ModifierButtonClick();
        }

        [When(@"Déplacer la section Taxes officielles")]
        public void WhenDeplacerLaSectionTaxesOfficielles()
        {
            Thread.Sleep(5000);
            facturation.DragAndDrop();
        }

        [When(@"Cliquer sur le bouton valider")]
        public void WhenCliquerSurLeBoutonValider()
        {
            Thread.Sleep(5000);
            facturation.ValiderButtonClick();
        }


        [Then(@"La section Taxes officielles est bien déplacé")]
        public void ThenLaSectionTaxesOfficiellesEstBienDeplace()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(facturation.TaxesOfficiellesText().Contains("Taxes officielles"));
        }

        [When(@"Cliquer sur Générer un courrier")]
        public void WhenCliquerSurGenererUnCourrier()
        {
            Thread.Sleep(5000);
            facturation.CourrierButtonClick();
        }

        [When(@"Cliquer sur Facture/Débit - Avoir/Crédit")]
        public void WhenCliquerSurFactureDebit_AvoirCredit()
        {
            Thread.Sleep(5000);
            facturation.FactureAvoirClick();
        }

        [When(@"Cliquer sur le bouton Suivant du pop up Générer un courrier")]
        public void WhenCliquerSurLeBoutonSuivantDuPopUpGenererUnCourrier()
        {
            Thread.Sleep(5000);
            facturation.SuivantButtonClick();
        }

        [When(@"Sélectionner la langue Français")]
        public void WhenSelectionnerLaLangueFrancais()
        {
            Thread.Sleep(15000);
            facturation.FrançaisLangueClick();
        }

        [When(@"Cliquer suivant")]
        public void WhenCliquerSuivant()
        {
            Thread.Sleep(5000);
            facturation.NextButtonClick();
        }

        [When(@"Cliquer sur Générer le document")]
        public void WhenCliquerSurGenererLeDocument()
        {
            Thread.Sleep(5000);
            facturation.GénérerDocumentButtonClick();
        }

        [When(@"Cliquer sur l'icone Word")]
        public void WhenCliquerSurLIconeWord()
        {
            Thread.Sleep(25000);
            facturation.WordButtonClick();
        }

        [Then(@"Le document word s'ouvre")]
        public void ThenLeDocumentWordSOuvre()
        {
            
        }



    }
}
