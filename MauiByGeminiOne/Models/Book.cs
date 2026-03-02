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
