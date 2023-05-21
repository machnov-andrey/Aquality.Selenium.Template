Feature: Demo

@demo
Scenario Outline: I check filters Cian
    When I log in in Cian with email '...' and password '...'
	When I choose rent
	When I fill in filters: house type - 'Комната'
	When I set price from '10000' to '30000' and set true owner check box
	When I fill more filters: owner check box and house size: '3'
	When I choose first offer
	Then Expected owner indicator, house type 'Комната', price range '10000'-'30000' and house size '3'
	When I click to show phone
