using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlissiaE2ETest.PageObjects.Facturation
{
    class FacturationPage
    {
        public IWebDriver driver;
        static CommonMethod ComM;

        public FacturationPage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[2]/div[1]/span")]
        public IWebElement DropDown;

        [FindsBy(How = How.Id, Using = "EditCaseFloStepLaunchableTreeViewSpan100028758")]
        public IWebElement AvisDepot;

        [FindsBy(How = How.Id, Using = "EditCaseFloStepLaunchableTreeViewSpan100028758¤100026754")]
        public IWebElement ValorisationDépôtEtape;

        [FindsBy(How = How.Id, Using = "EditCaseWorkflowTiming")]
        public IWebElement ProcedureCheckBox;

        [FindsBy(How = How.XPath, Using = "//*[@id='CasesMainTabStrip']/ul/li[8]/a")]
        public IWebElement Val_Fac;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[1]/div/div/div/ul/li[5]/ul/li/ul/li[1]/div/span")]
        public IWebElement ValorisationDépôt;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvStateId_listbox']/li[6]")]
        public IWebElement NonFacturable;

        [FindsBy(How = How.Id, Using = "WorkedOfficialFees")] 
        public IWebElement TaxeForfaitAdministratifValorisationInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[1]/div/label[1]/input")]
        public IWebElement FacturationCheckBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[1]/div/label[2]/input")]
        public IWebElement ValorisationCheckBox;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarSaveButton")]
        public IWebElement SauvegarderButton;

        [FindsBy(How = How.Id, Using = "InvoicedOfficialFees")]
        public IWebElement TaxeForfaitAdministratifFacturationInput;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarReportButton")]
        public IWebElement ExportCognosButton;

        [FindsBy(How = How.Id, Using = "CognosReportDownloadButton")]
        public IWebElement TéléchargerFileButton;

        [FindsBy(How = How.Id, Using = "CognosReportDownloadButton")]
        public IWebElement CaseWorkMadeDetailToolBarEditWorkMadeButton;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeInvoicePartySelectValidateButton")]
        public IWebElement FacturationButton;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarEditWorkMadeButton")]
        public IWebElement FacturationIcon;

        [FindsBy(How = How.XPath, Using = "//html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[2]")]
        public IWebElement Tiers;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/div[1]/div[2]")]
        public IWebElement FraisHonoraires;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailModifyLinesButton")]
        public IWebElement ModifierButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailBodyLines']/div[2]/span")]
        public IWebElement FraisHonorairesBragAndDropButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailBodyLines']/div[1]/span")]
        public IWebElement TaxesOfficiellesBragAndDropButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/div[1]")]
        public IWebElement TaxesOfficielles;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailToolBarMailButton")]
        public IWebElement CourrierButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailMailGrid']/div[2]/table/tbody/tr/td[1]")]
        public IWebElement FactureAvoir;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailMailValidateButton")]
        public IWebElement SuivantButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='DocGenerationGrdTemplates']/table/tbody/tr[2]/td[1]")]
        public IWebElement FrançaisLangue;

        [FindsBy(How = How.Id, Using = "DocGenerationBtnNext")]
        public IWebElement NextButton;

        [FindsBy(How = How.Id, Using = "DocGenerationBtnGenerate")]
        public IWebElement GénérerDocumentButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='DocGenerationGrdTemplateDetails']/table/tbody/tr/td[8]/a/span")]
        public IWebElement WordButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailBodyContainer']/div[1]/div[3]")]
        public IWebElement ValiderButton;


        public void ProcedureCheckBoxClick()
        {
            ProcedureCheckBox.Click();
        }

        public void AvisDepotClick()
        {

            Actions action = new Actions(driver);
            action.DoubleClick(AvisDepot).Perform();
        }

        public void ValorisationDépôtClick()
        {

            Actions action = new Actions(driver);
            action.DoubleClick(ValorisationDépôtEtape).Perform();
        }

        public void Val_FacClick()
        {
            Val_Fac.Click();
        }

        public string ValorisationDépôtText()
        {
            return ValorisationDépôt.Text;
        }

        public void ValorisationDépôtEtapeClick()
        {
            ValorisationDépôt.Click();
        }

        public string DépôtEnLigneTotal()
        {

            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]";
            string text = "Dépôt en ligne";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);

            Console.WriteLine(driver.FindElement(By.XPath(xpath_1 + i + "]/td[15]")).Text);

            return driver.FindElement(By.XPath(xpath_1 + i + "]/td[15]")).Text;
        }

        public void EtatEnvoirecommandéClick()
        {

            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]";
            string text = "Envoi recommandé";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[4]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(xpath_1 + i + "]/td[4]")).Click();
        }

        public void NonFacturableClick()
        {
            NonFacturable.Click();
        }

        public void TaxeForfaitValorisationAdministratif()
        {

            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";                 
            string xpath_2 = "]/td[2]";
            string text = "Forfait administratif du dépôt d'une demande de brevet";


            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            Console.WriteLine(i);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[7]")).Click();
        }

        public void SauvegarderButtonClick()
        {
            SauvegarderButton.Click();
        }

        public void TaxeForfaitAdministratifValorisationInputSendKeys(string taxe)
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]";
            string text = "Forfait administratif du dépôt d'une demande de brevet";


            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            driver.FindElement(By.XPath("/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/div/div[2]/table/tbody/tr[" + i+ "]/td[7]/span[1]/span/input[1]")).Click();
            Thread.Sleep(2000);
            TaxeForfaitAdministratifValorisationInput.SendKeys(taxe);
        }

        public void TaxeForfaitFactorationAdministratif()
        {

            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]";
            string text = "Forfait administratif du dépôt d'une demande de brevet";


            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            Console.WriteLine(i);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[12]")).Click();
        }
        public void FacturationCheckBoxClick()
        {
            FacturationCheckBox.Click();
        }

        public void TaxeForfaitAdministratifFacturationInputSendKeys(string taxe)
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]";
            string text = "Forfait administratif du dépôt d'une demande de brevet";


            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            driver.FindElement(By.XPath("/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/div/div[2]/table/tbody/tr[" + i + "]/td[12]/span[1]/span/input[1]")).Click();
            Thread.Sleep(2000);
            TaxeForfaitAdministratifFacturationInput.SendKeys(taxe);
        }

        public string BoldText()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[6]/td[2]/div"));
            String fontWeight = (String)js.
                    ExecuteScript(
                            "return getComputedStyle(arguments[0]).getPropertyValue('font-weight');",
                            element);

            return fontWeight;

        }

        public int ExistFile()
        {
            String path = System.Configuration.ConfigurationManager.AppSettings["DownloadsPathFolder"];

            string[] filePaths = Directory.GetFiles(@path, "Valorisation par étape_*.pdf", SearchOption.AllDirectories);

            return filePaths.Length;


        }

        public void DeleteFile()
        {
            String path = System.Configuration.ConfigurationManager.AppSettings["DownloadsPathFolder"];

            string[] filePaths = Directory.GetFiles(@path, "Valorisation par étape_*.pdf", SearchOption.AllDirectories);
            foreach (string file in filePaths)
            {
                File.Delete(file);
            }
        }

        public void ExportCognosButtonClick()
        {
            ExportCognosButton.Click();
        }

        public void TéléchargerFileButtonClick()
        {
            TéléchargerFileButton.Click();
        }

        public void FacturationButtonClick()
        {
            FacturationButton.Click();
        }

        public void FacturationIconClick()
        {
            FacturationIcon.Click();
        }

        public string TiersText()
        {
            return Tiers.Text;
        }

        public string FraisHonorairesText()
        {
            return FraisHonoraires.Text;
        }

        public void ModifierButtonClick()
        {
            ModifierButton.Click();
        }

        public void DragAndDrop()
        {
            Actions action = new Actions(driver);

            action.DragAndDrop(FraisHonorairesBragAndDropButton , TaxesOfficiellesBragAndDropButton).Build().Perform();
        }

        public string TaxesOfficiellesText()
        {
            return TaxesOfficielles.Text;
        }

        public void CourrierButtonClick()
        {
            CourrierButton.Click();
        }

        public void FactureAvoirClick()
        {
            FactureAvoir.Click();
        }

        public void SuivantButtonClick()
        {
            SuivantButton.Click();
        }

        public void FrançaisLangueClick()
        {
            FrançaisLangue.Click();
        }

        public void NextButtonClick()
        {
            NextButton.Click();
        }

        public void GénérerDocumentButtonClick()
        {
            GénérerDocumentButton.Click();
        }

        public void WordButtonClick()
        {
            WordButton.Click();

            Thread.Sleep(10000);



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();

        }
    }
}
