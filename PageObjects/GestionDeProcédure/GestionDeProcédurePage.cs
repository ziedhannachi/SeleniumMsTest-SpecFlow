using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlissiaE2ETest.PageObjects.GestionDeProcédure
{
    class GestionDeProcédurePage
    {

        public IWebDriver driver;
        static CommonMethod ComM;

        public GestionDeProcédurePage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[2]/div[1]/span")]
        public IWebElement DropDown;

        [FindsBy(How = How.Id, Using = "CaseVM_ReferenceText")]
        public IWebElement ReferenceInput;

        [FindsBy(How = How.Name, Using = "QuickSearchValueField_input")]
        public IWebElement SearchInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='CasesMainTabStrip']/ul/li[6]/a")]
        public IWebElement Procedure;

        [FindsBy(How = How.LinkText, Using = "Ajouter une date Priorité")]
        public IWebElement AjoutDatePrioriteButton;

        [FindsBy(How = How.Id, Using = "CaseDateEditDPDate")]
        public IWebElement DateprioriteInput;

        [FindsBy(How = How.Id, Using = "CaseDateEditDDCountry")]
        public IWebElement PaysInput;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderCaseDateEditDDCountryLOVListLabelCode")]
        public IWebElement CodeInput;
        
        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonCaseDateEditDDCountryLOVList")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "CaseDateEditACNumber")]
        public IWebElement NumeroInput;

        [FindsBy(How = How.Id, Using = "CatStepActionPopupNextButton")]
        public IWebElement SuivantButton;

        [FindsBy(How = How.Id, Using = "CaseDateEditDPDate")]
        public IWebElement DateDepôtInput;

        [FindsBy(How = How.Id, Using = "CaseDateEditACNumber")]
        public IWebElement NumeroDepôtInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='CasePartyEditMultipleCasParties']/div[3]/table/tbody/tr/td[6]/a[1]")]
        public IWebElement EditButton;

        [FindsBy(How = How.Id, Using = "PartyShortName")]
        public IWebElement NomAbregeInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='CasePartyEditMultipleCasParties']/div[3]/table/tbody/tr/td[6]/a[1]")]
        public IWebElement EditConfirmButton;

        [FindsBy(How = How.Id, Using = "CasePartyEditSingleParty")]
        public IWebElement NomAbregeCorrespondantFournisseurInput;

        [FindsBy(How = How.XPath, Using = "/div/div/div/table/tbody/tr/td[2]/h3[2]")]
        public IWebElement NotificationError;

        [FindsBy(How = How.Id, Using = "CasePartyEditSingleParty")]
        public IWebElement NomAbregeCorrespAnnuit;

        [FindsBy(How = How.XPath, Using = "//*[@id='DOSGENGeneralitiesGrid']/div[3]/table/tbody/tr[1]/td[2]/div")]
        public IWebElement NBPageRevendication;

        [FindsBy(How = How.XPath, Using = "//*[@id='DOSGENGeneralitiesGrid']/div[3]/table/tbody/tr[3]/td[2]/div")]
        public IWebElement NBMotsDescription;

        [FindsBy(How = How.Id, Using = "CasGeneralitiesNumericEditor")]
        public IWebElement NBMotsDescriptionInput;

        [FindsBy(How = How.Id, Using = "FloHistoryFormLaunchNextAction")]
        public IWebElement CheckBoxEtapeSuiv;

        [FindsBy(How = How.XPath, Using = "//*[@id='CatStepOperationDetailHistoryStepGrid']/div[2]/table/tbody/tr/td[1]/div")]
        public IWebElement Etape;

        [FindsBy(How = How.LinkText, Using = "Dossier")]
        public IWebElement Dossier;


        public void DropDownClick()
        {
            DropDown.Click();
        }

        public void TypeClick(string brevets)
        {

            string xpath_1 = "//*[@id='QuickSearchObject_listbox']/li[";
            string xpath_2 = "]/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, brevets);
            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();
        }

        public void SaisirNomDossier(string folderName)
        {
            SearchInput.SendKeys(folderName);
        }

        public string ReferenceInputText()
        {
            Console.WriteLine(ReferenceInput.GetAttribute("value"));
            return ReferenceInput.GetAttribute("value");
        }

        public void ProcedureClick()
        {
            Procedure.Click();
        }

        public void AvisDepotClick()
        {
            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[6]/div[2]/div[1]/div/div/ul/li/ul/li[";
            string xpath_2 = "]/div/span[2]";
            string text = "Avis de dépôt";

            int i = ComM.ParcourList(4, xpath_1, xpath_2, text);

            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath(xpath_1 + i + xpath_2))).Perform();
        }

        public void MAJDateAndNdepotClick()
        {
            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[6]/div[2]/div[1]/div/div/ul/li/ul/li[5]/ul/li[";
            string xpath_2 = "]/div/span";
            string text = "MAJ Date & N° dépôt ETR/NAT";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);

            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath(xpath_1 + i + xpath_2))).Perform();
        }

        public void AjoutDatePrioriteButtonClick()
        {
            AjoutDatePrioriteButton.Click();
        }

        public void DateInputSendKey(String date)
        {
            DateprioriteInput.Click();
            Thread.Sleep(3000);
            DateprioriteInput.SendKeys(date);
        }

        public void PaysInputClick()
        {
            PaysInput.Click();
        }

        public void CodeInputSendKey(String code)
        {
            CodeInput.SendKeys(code);
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void NumeroInputSendKey(String numero)
        {
            NumeroInput.SendKeys(numero);
        }

        public void SuivantButtonClick()
        {
            SuivantButton.Click();
            Thread.Sleep(5000);

        }

        public void DateDepôtSendKey(String date)
        {
            DateDepôtInput.Clear();
            DateprioriteInput.Click();
            Thread.Sleep(3000);
            DateDepôtInput.SendKeys(date);
        }

        public void NumeroDepôtSendKey(String numero)
        {
            NumeroDepôtInput.Clear();
            Thread.Sleep(3000);
            NumeroDepôtInput.SendKeys(numero);
        }

        public void EditButtonClick()
        {
            EditButton.Click();
        }

        public void NomAbregeInputSendKey(String NomAbrege)
        {
            string a = NomAbregeInput.GetAttribute("value");
            while (NomAbregeInput.GetAttribute("value").Length != 0)
            { NomAbregeInput.SendKeys(Keys.Backspace);
                a = NomAbregeInput.GetAttribute("value");
            }
            NomAbregeInput.SendKeys(NomAbrege);
            NomAbregeInput.SendKeys(Keys.Enter);
        }

        public void EditConfirmButtonClick()
        {
            Thread.Sleep(2000);
            EditConfirmButton.Click();
            
        }

        public void NomAbregeCorrespondantFournisseurInputSendKey(String NomAbrege)
        {
            //string a = NomAbregeCorrespondantFournisseurInput.GetAttribute("value");
            //while (NomAbregeCorrespondantFournisseurInput.GetAttribute("value").Length != 0)
            //{
            //    NomAbregeCorrespondantFournisseurInput.SendKeys(Keys.Backspace);
            //    a = NomAbregeCorrespondantFournisseurInput.GetAttribute("value");
            //}

            NomAbregeCorrespondantFournisseurInput.Clear();
        }

        public Boolean NotificationErrorDisplayed()
        {
            Console.WriteLine(NotificationError.Text);
            return NotificationError.Displayed;
        }

        public string NomAbregeCorrespAnnuitText()
        {
            return NomAbregeCorrespAnnuit.GetAttribute("value");
        }

        public string NBPageRevendicationText()
        {
            return NBPageRevendication.Text;
        }

        public void NBMotsDescriptionClick()
        {
            NBMotsDescription.Click();
        }

        public void NBMotsDescriptionInputSendKeys(string nb)
        {
            NBMotsDescriptionInput.SendKeys(nb);
        }

        public void CheckBoxEtapeSuivClick()
        {
            CheckBoxEtapeSuiv.Click();
        }

        public string EtapeHistoriqueText()
        {
            return Etape.Text;
        }

        public void DossierClick()
        {
            Dossier.Click();
        }

        public string EtapeText()
        {
            return Etape.Text;
        }

        public IList<string> ListeInfoPriorité()
        {
            IList<string> ListInfoPriorité = new List<string>();

            string xpath_td1 = "//*[@id='casesDatesGrid']/div[3]/table/tbody/tr[";
            string xpath_td2 = "]/td[";
            string xpath_td3 = "]/div";

            ListInfoPriorité = ComM.Listinfo(xpath_td1, xpath_td2, xpath_td3, 1);

            return ListInfoPriorité;

        }

        public IList<string> ListeInfoDépôt()
        {
            IList<string> ListInfoDépôt = new List<string>();


            string xpath_td1 = "//*[@id='casesDatesGrid']/div[3]/table/tbody/tr[";
            string xpath_td2 = "]/td[";
            string xpath_td3 = "]/div";

            ListInfoDépôt = ComM.Listinfo(xpath_td1, xpath_td2, xpath_td3, 2);
            return ListInfoDépôt;

        }

        public IList<string> ListeNomTiers()
        {
            IList<string> ListTiers = new List<string>();


            string xpath_td1 = "//*[@id='casesPartiesGrid']/div[3]/table/tbody/tr[";
            string xpath_td2 = "]/td[3]";

            ListTiers = ComM.Listinfo(xpath_td1, xpath_td2);
            return ListTiers;

        }


    }
}
