using _12_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "Fantasy", 1997);
        Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937);
        Book book3 = new Book("1984", "George Orwell", "Dystopian", 1949);
        Book book4 = new Book("The Catcher in the Rye", "J.D. Salinger", "Fiction", 1951);
        Book book5 = new Book("To Kill a Mockingbird", "Harper Lee", "Classic", 1960);
        Book book6 = new Book("Pride and Prejudice", "Jane Austen", "Romance", 1813);
        Book book7 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925);


        Console.WriteLine(book1);
        book2.Print();
        Library lib = new Library(book3);

        lib.PrintLibrary();

        lib.Add_(book4);
        lib.Pop_();

        lib.PrintLibrary();


        lib.AddToBeginning_(book5);
        lib.AddToEnd_(book6);
        lib.AddByPosition_(0, book7);

        lib.PrintLibrary();

        lib.DeleteToBeginning_();
        lib.DeleteToEnd_();
        lib.DeleteByPosition_(0);

        lib.PrintLibrary();

        lib.ChangeBookInformation_("The Catcher in the Rye");

        lib.PrintLibrary();


        List<Book> lib2 = lib.BookSearch_("J.D. Salinger");
        foreach (Book book in lib2)
        {
            Console.WriteLine(book);
        }
    }
}