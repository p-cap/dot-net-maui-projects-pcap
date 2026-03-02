## Data Binding With .Net MAUI

### Book.cs
- we create the model
- the model is simple
- the model holds data
```
// Book.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace MauiByGeminiOne.Models
{
    internal class Book
    {
        // Model just holds data
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string CoverColor { get; set; }
        
    }
}
```
- Added `required` keyword to the model attributes to ensure their non-nullable
- The non-nullable issue was raised by the IDS

### ViewModels/BookViewModel.cs
- We create a `ViewModels` folder
- Inside the ViewModels folder, we create `BookViewModels.cs`
- The `BookViewModel` class implements `INotifyPropertyChanged`
- `CurrentBook` attribute gets the current book and sets it
- the CurrentBook set method also calls the `OnPropertyChanged()` function
- `BookViewModel` constructor sets the `CurrentBook` attribute to static values
- When implementing `INotifyPropertyChanged`, we agreed to include:
  - The Event: `public event PropertyChangedEventHandler PropertyChanged;`
  - The Trigger: A way to invoke that event (which we named `OnPropertyChanged`).

### MinPage.xaml.cs
- make sure to reference the ViewModel
```
xmlns:viewmodels="clr-namespace:MyAwesomeApp.ViewModels"
```
- added the `ContentPage.BindingContext`
```
    <ContentPage.BindingContext>
            <viewmodels:BookViewModel />
    </ContentPage.BindingContext>
```
- `{Binding}` keyword in XAML is the "hook" that connects the visual elements to the data source


### The 3-way handshake
- `Text = {Binding CurrentBook.Title}`The Binding markup extension -> tell the XAML compiler don't treat the string as literal text. Instead, look into the `BindingContext` and find the property path called `CurrentBook.Title`
  - The `BindingContext` -> exists on every MAUI control. It tells the control, "This is the object where you will find the data."
  - The `PropertyChanged Signal`
    - The View says: "I am bound to Title."
    - The ViewModel changes the Title and fires the PropertyChanged event.
    - The Binding Engine hears the event and tells the View: "Hey, the data changed! Update your text now."
    