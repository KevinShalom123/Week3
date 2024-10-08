class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOFPages;

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOFPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOFPages = bookNoOFPages;
    }
    

    void DisplayInfo()
    {
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"ISBN :{ISBN}");
        Console.WriteLine($"Pages :{NoOFPages}");
        Console.WriteLine();
    }

        static void Main(String[] args)
    {
        Book book = new Book("C# For Beginners", "Ramesh", "123453", 200);
        Book book2 = new Book("C# For Experts", "Reddy", "123233", 400);

        book.DisplayInfo();
        book2.DisplayInfo();

    }





}
