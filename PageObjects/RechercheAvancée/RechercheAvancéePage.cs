using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlissiaE2ETest.PageObjects.RechercheAvancée
{
    class RechercheAvancéePage
    {

        private IWebDriver driver;

        static CommonMethod ComM;

        public RechercheAvancéePage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420000114")]
        public IWebElement TiersButton;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewDiv420000116")]
        public IWebElement DonneurOrdreButton;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420001116")]
        public IWebElement DonneurOrdre;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000075")]
        public IWebElement EgaleButton;

        [FindsBy(How = How.Id, Using = "DisplayedValueObjectId")]
        public IWebElement ValeurInput;

        [FindsBy(How = How.Id, Using = "SearchEngineValueFormValidateButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "SearchEngineExecuteQueryButton")]
        public IWebElement RechercheButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='ResultGrid']/div[4]/table/tbody")]
        public IWebElement ListInformation;

        [FindsBy(How = How.Id, Using = "ColumnSettingsButton")]
        public IWebElement ParametrageButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']/ul/li[2]")]
        public IWebElement Objet;

        [FindsBy(How = How.Id, Using = "ValidateUserPrefButton")]
        public IWebElement SauvegarderButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='ResultGrid']/div[3]/div/table/thead/tr/th[2]")]
        public IWebElement ColonneStatut;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']/ul/li[2]/div/span")]
        public IWebElement statut;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']/ul/li[2]")]
        public IWebElement SousStatut;

        [FindsBy(How = How.Id, Using = "SearchEngineResultGridSaveQueryButton")]
        public IWebElement SauvegardRequetButton;

        [FindsBy(How = How.Id, Using = "SearchEngineSaveQueryValidateButton")]
        public IWebElement SauvegardButton;

        [FindsBy(How = How.XPath, Using = "//a[@href='/Cases']")]
        public IWebElement Dossier;

        [FindsBy(How = How.XPath, Using = "//*[@id='divCaseQuery100188078']/a[1]")]
        public IWebElement Requete;

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div[1]/div/a[2]")]
        public IWebElement FermerButton;


        public void TuersButtonClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(TiersButton).Perform();
        }

        public void DonneurOrdreButtonClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(DonneurOrdreButton).Perform();
        }

        public void DonneurOrdreClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(DonneurOrdre).Perform();
        }

        public void EgaleButtonClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(EgaleButton).Perform();
        }

        public void ValeurInputSendKey(string valeur)
        {
            ValeurInput.SendKeys(valeur);

        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void RechercheButtonClick()
        {
            RechercheButton.Click();
        }

        public Boolean ListInformationDisplayed()
        {
            return ListInformation.Displayed;
        }

        public void ParametrageButtonClick()
        {
            ParametrageButton.Click();
        }

        public void StatutDragAndDrop()
        {

            string xpath_1 = "//*[@id='AvailableColumnsTree']/ul/li[";
            string xpath_2 = "]/div/span";
            string text = "Statut";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);

            Actions action = new Actions(driver);

            action.DragAndDrop(driver.FindElement(By.XPath(xpath_1 + i + xpath_2)), Objet).Build().Perform();
        }

        public void SauvegarderButtonClick()
        {
            SauvegarderButton.Click();
        }

        public string ColonneStatutTest()
        {
            Console.Write(ColonneStatut.Text);
            return ColonneStatut.Text;
        }

        public void StatutDragAndDropInverse()
        {
            Actions action = new Actions(driver);

            action.DragAndDrop(statut, SousStatut).Build().Perform();
        }

        public void SauvegardRequetButtonClick()
        {
            SauvegardRequetButton.Click();
        }

        public void SauvegardButtonClick()
        {
            SauvegardButton.Click();
        }

        public void DossierClick()
        {
            Dossier.Click();
        }

        public String RequeteText()
        {
            return Requete.Text;
        }

        public void FermerButtonClick()
        {
            FermerButton.Click();
        }

    }
}
