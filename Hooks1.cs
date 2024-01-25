using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;

namespace SpecFlowProject1
{
    [Binding]
    public sealed class Hooks1
    {

        private static ExtentReports Extent;
        private static ExtentTest featureName;
        private static ExtentTest scenarioName;
        [BeforeTestRun]
        public static void Initial()
        {
            var HtmlReporter = new ExtentSparkReporter("C:\\Users\\BALAJI\\OneDrive\\Desktop\\New folder\\Report\\Report.html");
            HtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
            Extent = new ExtentReports();
            Extent.AttachReporter(HtmlReporter);
        }
        [BeforeScenario] public static void scenario() {
            Extent.CreateTest<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        
        }
        [BeforeFeature] public static void feature() {
            Extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenarioAttribute(Order =3)]
        
            public static void start()
        {
           
                

            Console.WriteLine("As this is Before scenario this will run before every scenario");
            Console.WriteLine("This is will Second Because its order is 2");
        }
        [BeforeScenarioAttribute(Order =1)]
        public static void start1()
        {
            Console.WriteLine("As this is Before scenario this will run before every scenario");
            Console.WriteLine("This is will Second Because its order is 1");
        }

        [ AfterTestRun]
       public static void teardown()
        {
            Extent.Flush();           
        }
    }
}