using StockApp;

namespace SpecFlowTutorialProject.StepDefinitions
{
    [Binding]
    public class StockControlStepDefinitions
    {
        public StockAppClass stockApp = new StockAppClass();

        [Given(@"That i am a StockApp User")]
        public void GivenThatIAmAStockAppUser()
        {
            stockApp.User = "DemoUser";
            //throw new PendingStepException();
        }

        [Given(@"My initial portfolio has a value of '([^']*)'")]
        public void GivenMyInitialPortfolioHasAValueOf(string portfolioValue)
        {
            stockApp.SetPortfolioValue(int.Parse(portfolioValue));
            //throw new PendingStepException();
        }

        [When(@"I purchase '([^']*)' amount of '([^']*)' at the latest value")]
        public void WhenIPurchaseAmountOfAtTheLatestValue(string amount, string stockCode)
        {
            stockApp.PurchaseStock(amount, stockCode);
            //throw new PendingStepException();
        }

        [Then(@"My portfolio has increase in value '([^']*)'")]
        public void ThenMyPortfolioHasIncreaseInValue(string portfolioValue)
        {
            int initialPortfolioValue = int.Parse(portfolioValue);
            int newPortfolioValue = stockApp.PortfolioVaule;

            newPortfolioValue.Should().BeGreaterThan(initialPortfolioValue);
            //throw new PendingStepException();
        }
    }
}