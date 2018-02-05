using System;
using TechTalk.SpecFlow;

//Automatic Test for Ticket 12345, 123456, 1234567 fixes
namespace SpecflowOnConsole.Steps
{
    [Binding]
    public class UnknownSteps
    {
        [Given(@"I have open my iOS App ABC")]
        public void GivenIHaveOpenMyIOSAppABC()
        {
            //Call out App
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have open my iOS App ABC and there is up-to-date content loaded")]
        public void GivenIHaveOpenMyIOSAppABCAndThereIsUp_To_DateContentLoaded()
        {
            //Call object and load out all content
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press download data")]
        public void WhenIPressDownloadData()
        {
            //Call download data function
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The screen lock is on")]
        public void WhenTheScreenLockIsOn()
        {
            //Call iOS screen lock 
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The automatic sync starts by default")]
        public void WhenTheAutomaticSyncStartsByDefault()
        {
            //Call automatic sync
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Broswer thought contents between folders")]
        public void WhenBroswerThoughtContentsBetweenFolders()
        {
            //Switching folder context
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The download should be complete next time the user login")]
        public void ThenTheDownloadShouldBeCompleteNextTimeTheUserLogin()
        {
            //Check and verify if all the sync context is available
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"All the data should should be sync locally on my device")]
        public void ThenAllTheDataShouldShouldBeSyncLocallyOnMyDevice()
        {
            //Check and verify all the sync data is locally store to device
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The actual data should reflect and show on right side of the screen")]
        public void ThenTheActualDataShouldReflectAndShowOnRightSideOfTheScreen()
        {
            //Check is the expected objects available on DOM
            ScenarioContext.Current.Pending();
        }
    }
}
