class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOFPages;

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
        Book book = new Book();
        book.Title = "C# For Beginners";
        book.Author = "Ramesh & Sumesh";
        book.ISBN = "14261625";
        book.NoOFPages=200;


        Book book2 = new Book();
        book2.Title = "C# FOR LOSERS";
        book2.Author = "NITISH KUMAR REDDY";
        book2.ISBN = "142836273637";
        book2.NoOFPages = 300;

        book.DisplayInfo();
        book2.DisplayInfo();

    }





}
