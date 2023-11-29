using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_and_Book_Management_System
{
    internal class Book
    {
       private string title;
        private int publicationYear;
        private string genre;

        public Book()
        {

        }

        public Book(string title, int publicationYear, string genre)
        {
            this.title = title;
            this.publicationYear = publicationYear;
            this.genre = genre;
        }

        public string displayBookInfo() => $"Book Information: \n" 
            + $"Title: {this.title}\n" 
            + $"Publication Year: {this.publicationYear}\n" 
            + $"Genre: {this.genre}";


    }
}
