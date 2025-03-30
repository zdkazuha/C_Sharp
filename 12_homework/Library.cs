using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_homework
{
    internal class Library
    {
        private int size = 0;  
        private List<Book> lib = new List<Book>(); 

        public Library(Book book)
        {
            Add_(book);
        }

        public void Add_(Book book)
        {
            lib.Add(book);
            size++;
        }

        public void Pop_()
        {
            PrintLibrary();
            Console.WriteLine();
            Console.Write("Enter index to remove book :: ");

            int index;
            bool success = int.TryParse(Console.ReadLine(), out index);

            if (success && index >= 0 && index < size)
            {
                DeleteByPosition_(index);
            }
            else
            {
                Console.WriteLine("Invalid index input!!!");
            }
            Console.WriteLine();
            PrintLibrary();
        }

        public void DeleteByPosition_(int index)
        {
            if (index >= 0 && index < size)
            {
                lib.RemoveAt(index);
                size--;
            }
            else
            {
                Console.WriteLine("Index out of range!");
            }
        }

        public void AddToBeginning_(Book book)
        {
            lib.Insert(0, book);
            size++;
        }

        public void AddToEnd_(Book book)
        {
            Add_(book);
        }

        public void AddByPosition_(int index, Book book)
        {
            if (index >= 0 && index <= size)
            {
                lib.Insert(index, book);
                size++;
            }
            else
            {
                Console.WriteLine("Index out of range for insertion!");
            }
        }

        public void DeleteToBeginning_()
        {
            if (size > 0)
            {
                lib.RemoveAt(0);
                size--;
            }
            else
            {
                Console.WriteLine("Library is empty!");
            }
        }

        public void DeleteToEnd_()
        {
            if (size > 0)
            {
                lib.RemoveAt(size - 1);
                size--;
            }
            else
            {
                Console.WriteLine("Library is empty!");
            }
        }

        public void PrintLibrary()
        {
            Console.WriteLine();
            Console.WriteLine("Library book:");
            int index = 0;
            foreach (var book in lib)
                Console.WriteLine($"Index [{index++}] {book}");
            Console.WriteLine();

        }


        public void ChangeBookInformation_(string nameBook)
        {
            List<Book> foundBooks = new List<Book>();
            bool bookFound = false; 

            foreach (var book in lib)
            {
                if (book.BookTitles == nameBook)
                {
                    Console.WriteLine($"Changing information for the book: {book.BookTitles}");

                    Console.Write("Enter new book name           :: ");
                    book.BookTitles = Console.ReadLine()!;

                    Console.Write("Enter new author full name    :: ");
                    book.AuthorFullName = Console.ReadLine()!;

                    Console.Write("Enter new genre books         :: ");
                    book.GenreBooks = Console.ReadLine()!;

                    Console.Write("Enter new year of publication :: ");
                    book.YearOfPublication = int.Parse(Console.ReadLine()!);

                }
            }

            if (!bookFound)
            {
                Console.WriteLine("No book found with the given name.");
            }
        }


        public List<Book> BookSearch_(string nameAuthor)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (var book in lib)
            {
                if (book.AuthorFullName == nameAuthor)
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }
    }
}
