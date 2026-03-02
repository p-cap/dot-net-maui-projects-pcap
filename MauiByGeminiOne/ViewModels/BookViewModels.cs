using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MauiByGeminiOne.Models;
using System.Runtime.CompilerServices;

namespace MauiByGeminiOne.ViewModels
{
    internal class BookViewModels : INotifyPropertyChanged
    {
        private Book _currentBook;

        public Book CurrentBook
        {
            get => _currentBook;
            set
            {
                _currentBook = value;
                OnPropertyChanged();
            }
        }

        public BookViewModels() { 
            CurrentBook = new Book
            {
                Title = "Learning Data Binding",
                Author = "DotNet Expert",
                CoverColor = "#512BD4"
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
