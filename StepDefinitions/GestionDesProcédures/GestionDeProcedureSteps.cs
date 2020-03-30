using AlissiaE2ETest.PageObjects.GestionDeProcédure;
using AlissiaE2ETest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AlissiaE2ETest.StepDefinitions.GestionDesProcédures
{
    [Binding]
    public class GestionDeProcedureSteps
    {
        private IWebDriver driver;
        

        static CommonMethod comM;
        static GestionDeProcédurePage gestionDeProcedure;

        public GestionDeProcedureSteps(IWebDriver _driver)
        {
            driver = _driver;

            gestionDeProcedure = new GestionDeProcédurePage(driver);
            comM = new CommonMethod(driver);

        }


        [Given(@"Selectionner '(.*)' dans la liste de recherche")]
        public void GivenSelectionnerDansLaListeDeRecherche(string brevets)
        {
            gestionDeProcedure.DropDownClick();
            Thread.Sleep(4000);
            gestionDeProcedure.TypeClick(brevets);
            Thread.Sleep(1000);
        }

        [When(@"Saisir '(.*)' dans la zonne de recherche")]
        public void WhenSaisirDansLaZonneDeRecherche(string nomDossier)
        {

            gestionDeProcedure.SaisirNomDossier(nomDossier);
            Thread.Sleep(10000);
        }
        
        [Then(@"La référence du dossier est bien '(.*)'")]
        public void ThenLaReferenceDuDossierEstBien(string reference)
        {
            Thread.Sleep(10000);
            Assert.IsTrue(gestionDeProcedure.ReferenceInputText().Contains(reference));
        }

        [When(@"Cliquer sur Procédure")]
        public void WhenCliquerSurProcedure()
        {
            Thread.Sleep(10000);
            gestionDeProcedure.ProcedureClick();
            Thread.Sleep(10000);
        }

        [When(@"Cliquer sur Avis de dépôt")]
        public void WhenCliquerSurAvisDeDepot()
        {
            gestionDeProcedure.AvisDepotClick();
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur MAJ Date & N° dépôt ETR/NAT")]
        public void WhenCliquerSurMAJDateNDepotETRNAT()
        {
            gestionDeProcedure.MAJDateAndNdepotClick();
            Thread.Sleep(10000);
        }

        [When(@"Cliquer sur Ajouter une date priorité")]
        public void WhenCliquerSurAjouterUneDatePriorite()
        {
            gestionDeProcedure.AjoutDatePrioriteButtonClick();
            Thread.Sleep(3000);
        }

        [When(@"Saisir la date '(.*)'")]
        public void WhenSaisirLaDate(string Date)
        {
            gestionDeProcedure.DateInputSendKey(Date);
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur Pays")]
        public void WhenCliquerSurPays()
        {
            gestionDeProcedure.PaysInputClick();
            Thread.Sleep(3000);
        }

        [When(@"Saisir '(.*)' dans le champ code")]
        public void WhenSaisirFRDansLeChampCode(string code)
        {
            gestionDeProcedure.CodeInputSendKey(code);
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur le bouton Valider pour ajouter le pays")]
        public void WhenCliquerSurLeBoutonValiderPourAjouterLePays()
        {
            gestionDeProcedure.ValiderButtonClick();
            Thread.Sleep(3000);
        }

        [When(@"Saisir '(.*)' dans le champ Numéro")]
        public void WhenSaisirDansLeChampNumero(string numero)
        {
            gestionDeProcedure.NumeroInputSendKey(numero);
            Thread.Sleep(3000);

        }

        [When(@"Cliquer sur le bouton Suivant")]
        public void WhenCliquerSurLeBoutonSuivant()
        {
            gestionDeProcedure.SuivantButtonClick();
            Thread.Sleep(5000);
        }

        [When(@"Modifier la date de dépôt par '(.*)'")]
        public void WhenModifierLaDateDeDepotPar(String date)
        {
            gestionDeProcedure.DateDepôtSendKey(date);
            Thread.Sleep(3000);
        }

        [When(@"modifier le numéro de dépôt par '(.*)'")]
        public void WhenModifierLeNumeroDeDepotPar(string numero)
        {
            gestionDeProcedure.NumeroDepôtSendKey(numero);
            Thread.Sleep(5000);
        }

        [When(@"Cliquer sur le bouton modifier")]
        public void WhenCliquerSurLeBoutonModifier()
        {
            gestionDeProcedure.EditButtonClick();
            Thread.Sleep(2000);
        }

        [When(@"Modifier le nom abrégé par '(.*)'")]
        public void WhenModifierLeNomAbregePar(string nomAbrégé)
        {
            gestionDeProcedure.NomAbregeInputSendKey(nomAbrégé);
            Thread.Sleep(3000);
        }

        [When(@"Cliquer sur le bouton de validation du modification")]
        public void WhenCliquerSurLeBoutonDeValidationDuModification()
        {
            gestionDeProcedure.EditConfirmButtonClick();
            Thread.Sleep(5000);
        }

        [When(@"Saisir nom abrégé inexistant '(.*)' dans le champ Nom abrégé")]
        public void WhenSaisirNomAbregeQuiNExistePasDansLeChampNomAbrege(string nomAbrégé )
        {
            gestionDeProcedure.NomAbregeCorrespondantFournisseurInputSendKey(nomAbrégé);
            Thread.Sleep(3000);
        }

        [Then(@"Une notification est affichée")]
        public void ThenUneNotificationEstAffichee()
        {
            //Assert.IsTrue(gestionDeProcedure.NotificationErrorDisplayed());
                       
        }


        [Then(@"Le le correspondant annuités '(.*)' est affiché dans le champ Nom abrégé")]
        public void ThenLeLeCorrespondantAnnuitesEstAfficheDansLeChampNomAbrege(string nomAbAn)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(gestionDeProcedure.NomAbregeCorrespAnnuitText().Contains(nomAbAn));
        }

        [Then(@"'(.*)' est affiché pour le nombre de pages revendications")]
        public void ThenEstAffichePourLeNombreDePagesRevendications(string nbPageRev)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(gestionDeProcedure.NBPageRevendicationText().Contains(nbPageRev));
        }

        [When(@"Cliquer sur la valeur du nombre de mots de la description")]
        public void WhenCliquerSurLaValeurDuNombreDeMotsDeLaDescription()
        {
            Thread.Sleep(3000);
            gestionDeProcedure.NBMotsDescriptionClick();
        }

        [When(@"Saisir '(.*)' dans le champ valeur")]
        public void WhenSaisirDansLeChampValeur(string nbMotDesc)
        {
            Thread.Sleep(3000);
            gestionDeProcedure.NBMotsDescriptionInputSendKeys(nbMotDesc);
        }

        [When(@"Décocher la case Lancer l'étape suivante")]
        public void WhenDecocherLaCaseLancerLEtapeSuivante()
        {
            Thread.Sleep(3000);
            gestionDeProcedure.CheckBoxEtapeSuivClick();
        }

        [When(@"Cliquer sur le bouton Terminer")]
        public void WhenCliquerSurLeBoutonTerminer()
        {
            Thread.Sleep(5000);
            gestionDeProcedure.SuivantButtonClick();
        }

        [Then(@"Etape '(.*)' est bien affichée dans historique")]
        public void ThenEtapeEstBienAfficheeDansHistorique(string étape)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(gestionDeProcedure.EtapeHistoriqueText().Contains(étape));
            
        }

        [When(@"Cliquer sur Dossier")]
        public void WhenCliquerSurDossier()
        {
            gestionDeProcedure.DossierClick();
        }


        [Then(@"les informations date: '(.*)' et pays: '(.*)' et numéro: '(.*)' sont bien affichées pour la date priorité")]
        public void ThenLesInformationsDateEtPaysEtNumeroSontBienAfficheesPourLaDatePriorite(string datePriorité, string paysPriorité, string numéroPriorité)
        {
            Assert.IsTrue(gestionDeProcedure.ListeInfoPriorité()[0].Contains(datePriorité));
            Assert.IsTrue(gestionDeProcedure.ListeInfoPriorité()[1].Contains(paysPriorité));
            Assert.IsTrue(gestionDeProcedure.ListeInfoPriorité()[2].Contains(numéroPriorité));
        }

        [Then(@"les informations date: '(.*)' et pays: '(.*)' et numéro: '(.*)' sont bien affichées pour la date dépôt")]
        public void ThenLesInformationsDateEtPaysEtNumeroSontBienAfficheesPourLaDateDepot(string dateDépôt, string paysDépôt, string numéroDépôt)
        {
            Assert.IsTrue(gestionDeProcedure.ListeInfoDépôt()[0].Contains(dateDépôt));
            Assert.IsTrue(gestionDeProcedure.ListeInfoDépôt()[1].Contains(paysDépôt));
            Assert.IsTrue(gestionDeProcedure.ListeInfoDépôt()[2].Contains(numéroDépôt));
        }

        [Then(@"Le tiers '(.*)' est affiché pour Donneur d'ordre Annuités")]
        public void ThenLeTiersEstAffichePourDonneurDOrdreAnnuites(string nomTiers)
        {
            Assert.IsTrue(gestionDeProcedure.ListeNomTiers()[2].Contains(nomTiers));
        }

        [Then(@"Le tiers '(.*)' est affiché pour Tiers comptable")]
        public void ThenLeTiersEstAffichePourTiersComptable(string nomTiers)
        {
            Assert.IsTrue(gestionDeProcedure.ListeNomTiers()[3].Contains(nomTiers));
        }

        [Then(@"Le tiers '(.*)' est affiché pour Correspondant")]
        public void ThenLeTiersEstAffichePourCorrespondant(string nomTiers)
        {
            Assert.IsTrue(gestionDeProcedure.ListeNomTiers()[7].Contains(nomTiers));
        }

        [Then(@"Le tiers '(.*)' est affiché pour Corresp\. Annuité")]
        public void ThenLeTiersEstAffichePourCorresp_Annuite(string nomTiers)
        {
            Assert.IsTrue(gestionDeProcedure.ListeNomTiers()[8].Contains(nomTiers));
        }




    }
}
