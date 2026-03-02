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
- added 
```
<ContentPage.BindingContext>
        <viewmodels:BookViewModel />
    </ContentPage.BindingContext>
```
