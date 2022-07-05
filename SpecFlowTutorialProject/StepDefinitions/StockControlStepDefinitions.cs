using StockApp;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTutorialProject.StepDefinitions
{
    [Binding]
    public class StockControlStepDefinitions
    {
        public StockAppClass stockApp = new StockAppClass();

        [Given(@"That i am a StockApp User")]
        public void GivenThatIAmAStockAppUser()
        {
            throw new PendingStepException();
        }

        [Given(@"My initial portfolio has a value of '([^']*)'")]
        public void GivenMyInitialPortfolioHasAValueOf(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I purchase '([^']*)' amount of '([^']*)' at the latest value")]
        public void WhenIPurchaseAmountOfAtTheLatestValue(string p0, string mSFT)
        {
            throw new PendingStepException();
        }

        [Then(@"My portfolio has increase in value")]
        public void ThenMyPortfolioHasIncreaseInValue()
        {
            throw new PendingStepException();
        }
    }
}
