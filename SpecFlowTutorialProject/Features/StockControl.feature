Feature: StockControl

A short summary of the feature

@tag1
Scenario: As a StockApp User I want to purchase a given amount of stock at the latest value So that I can increase the value of my portfolio
	Given That i am a StockApp User
	And My initial portfolio has a value of '<Initial Portfolio Value>'
	When I purchase '<AmountStockToBuy>' amount of '<StockCode>' at the latest value
	Then My portfolio has increase in value
	Examples: 
	| Initial Portfolio Value | AmountStockToBuy | StockCode |
	| 1500                    | 10               | MSFT      |
	| 0                       | 5                | SBUX      |
	| 100                     | 3                | AMZN      |
	| 25000                   | 8                | BA        |
