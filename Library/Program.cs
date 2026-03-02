namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Guid ISBN { get; set; }
        public bool Availability = true;
        public Book(string title, string author, Guid iSBN, bool availability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = availability;
        }
    }

    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            
        }
        public bool SearchBook(string serach)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (serach == books[i].Title || serach == books[i].Author)
                {
                    Console.WriteLine($"The Book Is Found and The Autor is: {books[i].Author} and Tiltle is: {books[i].Title} ");
                    return true;
                }
            }
            Console.WriteLine($"This Book {serach} Not Found ");
            return false;

        }
        public void BorrowBook(string bookName)
        {
            bool isFound = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (bookName == books[i].Title)
                {
                    if (books[i].Availability == true)
                    {
                        books[i].Availability = false;
                        isFound = true;
                        Console.WriteLine($"You Borrowed This Book '{bookName}' Now");
                     
                    }
                    else 
                    {
                        Console.WriteLine($"Sorry, This Book '{bookName}' is already borrowed by someone else.");
                        isFound = false;
                    }
                    return;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Sorry, This Book '{bookName}' is not in our library.");
            }
        }

        public void ReturnBook(string bookName)
        {
            bool isFound = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (bookName == books[i].Title)
                {
                    isFound = true;
                    if (books[i].Availability == false)
                    {
                        books[i].Availability =true;
                        Console.WriteLine($"The Book retuned to library {bookName}");
                    }

                    else
                    {
                        Console.WriteLine($"This book {bookName} Available for Borrow");
                    }
                    return;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Sorry, This Book '{bookName}' is not in our library.");
            }
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("C# Basics","Abdurahman",Guid.NewGuid(),true));
            library.AddBook(new Book("java# Basics","Abdurahman",Guid.NewGuid(),true));
            library.SearchBook("C# Basics");
            library.BorrowBook("C# Basics");
            library.BorrowBook("n# Basics");
            library.ReturnBook("java# Basics");
        }
    }
}
