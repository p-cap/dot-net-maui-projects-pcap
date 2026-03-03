### Events and Code-Behind


#### SYNOPSIS
To get a better understanding on how events and code-behinds render data onto UI

#### FILES
- WeatherService.cs
	- created a `WeatherService` class
	- declared 3 attributes
	- `Location` -> is set to unknown with a getter and setter
	- `Humidity` -> getter and private setter and is initially set to 0
	- `Refresh()` -> generates a random humidity based random number from 30 to 95
- MainPage.xaml.cs
	- `RefreshWeatherButton_Clicked` function does 2 things
		- `WeatherService.Location = PostalCode.Text;` -> takes data from UI and sends to service
		- `WeatherService.Refresh();` -> tells service to update `Humidity`
		- ` Humidity.Text = $"Humidity: {WeatherService.Humidity}";` -> manually push back to the UI
- In this one event handler, three controls are tightly coupled to each other and the data through the code-behind.
- Per Microsoft learn, "This design works great for small UIs, but as soon as the UI becomes complex, maintaining a tightly coupled code-behind can become troublesome. If you delete or change a control, you must clean up any code using those UI controls, which could include the event handler. If you decide to redesign the UI, you'll have lots of code to refactor, too. And when the backing data structure changes, you have to dive into the code of each UI to stay in sync."

Reference:
https://learn.microsoft.com/en-us/training/modules/separate-ui-and-logic-with-data-binding/2-compare-event-and-data-driven
