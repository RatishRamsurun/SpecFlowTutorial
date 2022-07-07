using System;

namespace StockApp
{
    public class StockAppClass
    {
        public string? User { get; set; }
        public int PortfolioVaule { get; set; }

        public void SetPortfolioValue(int value)
        {
            PortfolioVaule = value;
        }

        public void PurchaseStock(string amount, string stockCode)
        {
            int latestPrice = GetLatestPrice(stockCode);
            int netSumToAdd =int.Parse( amount) * latestPrice;
            PortfolioVaule += netSumToAdd;
        }

        private int GetLatestPrice(string code)
        {
            switch (code)
            {
                case "MSFT":
                    return 287;

                case "SBUX":
                    return 93;

                case "AMZN":
                    return 3052;

                case "BA":
                    return 209;

                default:
                    return 0;
            }
        }
    }
}