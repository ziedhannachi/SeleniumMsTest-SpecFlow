//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Gherkin.Model;
//using OpenQA.Selenium;
//using System;
//using TechTalk.SpecFlow;
//using TechTalk.SpecFlow.Bindings;

//namespace AlissiaE2ETest.Reports
//{
//    public class ExtentReport
//    {

//        private IWebDriver driver;

//        private void CreateScenario(ExtentTest extent, StepDefinitionType stepDefinitionType)
//        {
//            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
//            //var scenarioStepContext = ScenarioStepContext.Current.StepInfo.Text;
//            if (ScenarioContext.Current.TestError != null)
//            {
//                if (stepType == "Given")
//                {
//                    extent.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
//                }

//                if (stepType == "When")
//                {
//                    extent.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
//                }

//                if (stepType == "Then")
//                {
//                    extent.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
//                }
//            else
//            {
//                if (stepType == "Given")
//                {
//                    extent.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
//                        string path = TakeScreenshot();
//                        extent.AddScreenCaptureFromPath(path);
//                    }

//                if (stepType == "When")
//                {
//                    extent.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
//                        string path = TakeScreenshot();
//                        extent.AddScreenCaptureFromPath(path);
//                    }

//                if (stepType == "Then")
//                {
//                    extent.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
//                        string path = TakeScreenshot();
//                        extent.AddScreenCaptureFromPath(path);
//                    }

//            }
//            }

//        }

//        private string TakeScreenshot()
//        {
//            String ScreeanshotFolderPath = System.Configuration.ConfigurationManager.AppSettings["FolderScreeanshotPath"] + "Alissia_Screenshot.Png";

//            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
//            return ScreeanshotFolderPath;
//        }

//        //private static void CreateScenarioFailOrError(ExtentTest extent, StepDefinitionType stepDefinitionType)
//        //{
//        //    var error = ScenarioContext.Current.TestError;

//        //    if (error.InnerException == null)
//        //    {
//        //        CreateScenario(extent, stepDefinitionType).Error(error.Message);


//        //    }
//        //    else
//        //    {
//        //        CreateScenario(extent, stepDefinitionType).Fail(error.InnerException);
//        //    }
//        //}

//        //public static void StepDefinitionGiven(this ExtentTest extent)
//        //{
//        //    if (ScenarioContext.Current.TestError == null)
//        //        CreateScenario(extent, StepDefinitionType.Given);
//        //    else
//        //        CreateScenarioFailOrError(extent, StepDefinitionType.Given);
//        //}

//        //public static void StepDefinitionWhen(this ExtentTest extent)
//        //{
//        //    if (ScenarioContext.Current.TestError == null)
//        //        CreateScenario(extent, StepDefinitionType.When);
//        //    else
//        //        CreateScenarioFailOrError(extent, StepDefinitionType.When);
//        //}

//        //public static void StepDefinitionThen(this ExtentTest extent)
//        //{
//        //    if (ScenarioContext.Current.TestError == null)
//        //        CreateScenario(extent, StepDefinitionType.Then);
//        //    else
//        //        CreateScenarioFailOrError(extent, StepDefinitionType.Then);
//        //}



//    }

//}
