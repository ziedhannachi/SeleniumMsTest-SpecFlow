using AlissiaE2ETest.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlissiaE2ETest.PageObjects.Dossiers
{
    class Dossiers
    {
        public IWebDriver driver;
        static CommonMethod ComM;

        public Dossiers(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.LinkText, Using = "Dossiers")]
        public IWebElement DossiersLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']/section/div[3]/div[2]")]
        public IWebElement Brevets;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseCreateNewCaseCategoryContainer']/span/span/span[1]")]
        public IWebElement PréstationList;

        [FindsBy(How = How.Id, Using = "CaseCreateNewCaseValidateButton")]
        public IWebElement SuivantButton;

        [FindsBy(How = How.LinkText, Using = "Ajouter un tiers Deposant")]
        public IWebElement AjouterTiersDeposant;

        [FindsBy(How = How.Id, Using = "ShortTitleText")]
        public IWebElement TitreAbrégé;

        [FindsBy(How = How.Id, Using = "TitleText")]
        public IWebElement TitleText;

        [FindsBy(How = How.Id, Using = "PartyShortName")]
        public IWebElement NomAbrégéInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseCreateNewCaseTitlesGrid']/div[3]/table/tbody/tr/td[2]/div")]
        public IWebElement TitreAbrégéCase;

        [FindsBy(How = How.LinkText, Using = "Ajouter un tiers Donneur d'ordre")]
        public IWebElement AjouterTiersDonneurOrdre;

        [FindsBy(How = How.Id, Using = "PartyShortName")]
        public IWebElement NomAbrégéDonneurOrdre;

        public void DossiersLinkClick()
        {
            DossiersLink.Click();
        }

        public void BrevetsClick()
        {
            Brevets.Click();
        }

        public void PréstationListClick()
        {
            PréstationList.Click();
        }

        public void BrevetFrançaisOrigineFrançaiseClick()
        {
            string xpath_1 = "/html/body/div[59]/div/ul/li[";
            string xpath_2 = "]";
            string text = "Brevet français d'origine française";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();
        }

        public void SuivantButtonClick()
        {
            SuivantButton.Click();
        }

        public void NomAbrégéInputSendKeys(string NomAbrégé)
        {
            NomAbrégéInput.SendKeys(NomAbrégé);
        }

        public void TitreAbrégéClick()
        {
            TitreAbrégéCase.Click();
        }

        public void TitreAbrégéSendKeys(string titreAbrégé)
        {
            TitreAbrégé.SendKeys(titreAbrégé);
        }

        public void TitleTextClick()
        {
            TitleText.Click();
            Thread.Sleep(3000);

            string a = TitleText.GetAttribute("value");
            while (TitleText.GetAttribute("value").Length != 0)
            {
                TitleText.SendKeys(Keys.Backspace);
                a = TitleText.GetAttribute("value");
            }
            
        }

        public void TitleTextSendKeys(string titre)
        {
            TitleText.SendKeys(titre);
        }

        public void AjouterTiersDonneurOrdreClick()
        {
            AjouterTiersDonneurOrdre.Click();
        }

        public void NomAbrégéDonneurOrdreSendKeys(string NomAbrégé)
        {
            NomAbrégéDonneurOrdre.SendKeys(NomAbrégé);
        }


    }
}
