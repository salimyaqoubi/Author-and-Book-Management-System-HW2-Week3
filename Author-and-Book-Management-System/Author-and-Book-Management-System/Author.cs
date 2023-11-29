using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Author_and_Book_Management_System
{
    internal class Author
    {
        private string authorName;
        private int birthYear;
        private string nationality;
        private List<Book> books = new List<Book> { };



        public Author(string authorName, int birthYear, string nationality)
        {
            this.authorName = authorName;
            this.birthYear = birthYear;
            this.nationality = nationality;
            books = new List<Book>();
            
        }

        public void AddBook(string title, int publicationYear, string genre) 
        {
            Book newBook = new Book(title, publicationYear, genre);
            books.Add(newBook);

        }

        public string displayAuthorInfo() => $"Name: {this.authorName}" +
            $"\nBirth Year: {this.birthYear}" +
            $"\nNationality: {this.nationality}\n";



        public void displayBooks()
        {
            Console.WriteLine("Displaying Books for J.K. Rowling: \n");
            Console.WriteLine($"Books Authored by {this.authorName}:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i].displayBookInfo()}");
            }
        }



    }
}
