@Second
Feature: Navigating trough different modules

A short summary of the feature

Background: 

	Given [the User is on Home Page ]  

Scenario Outline: To check Whether it redirects to <KeyWord> Module upon clicking <KeyWord> Module from SideMenu
	When [Clicking the <KeyWord> Module from the side Menu ]
	Then [<KeyWord> Module page should be Displayed]

@Third
Examples: 
| KeyWord     |  # This is a Key word header param matches with the scenario outline
| PIM         |
| Performance | # these are the different param values for which it can be executed
| Leave       |


@Fourth
Examples: 
| KeyWord     | 
| Time        |
