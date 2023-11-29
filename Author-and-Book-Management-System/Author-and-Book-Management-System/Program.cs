namespace Author_and_Book_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to the Author and Book Management System!\n ");

            // Create an instance of the Author class
            Console.WriteLine("Author Information: ");
            Author author = new Author("J.K. Rowling", 1965, "British");

            Console.WriteLine(author.displayAuthorInfo());



            
            // Add books for J.K. Rowling
            Console.WriteLine("Adding Books for J.K. Rowling:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}. Enter Book Title:");
                string title = Console.ReadLine();
                Console.WriteLine(" Enter Publication Year:");
                int publicationYear = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Genre: ");
                string genre = Console.ReadLine();

                author.AddBook(title, publicationYear, genre);
            }

            // Display author information and books
            author.displayAuthorInfo();
            author.displayBooks();
           




            /*
            Console.WriteLine("Author Information: ");
            Console.WriteLine("Name: ");
            string authorName = Console.ReadLine();

            Console.WriteLine("Birth Year: ");
            int birthYear;
            int.TryParse(Console.ReadLine(), out birthYear);

            Console.WriteLine("Nationality: ");
            string nationality = Console.ReadLine();

            Author author = new Author(authorName, birthYear, nationality);
            Console.WriteLine(author.displayAuthorInfo());
            */

            //Console.WriteLine("Author Information: \n");
            //Author author = new Author("J.K. Rowling", 1965, "British");
            //Console.WriteLine(author.displayAuthorInfo());

        }
    }
}