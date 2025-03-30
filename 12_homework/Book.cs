using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_homework
{
    internal class Book
    {
        private string _bookTitles;
        private string _authorFullName;
        private string _genreBooks;
        private int _yearOfPublication;

        public string BookTitles
        {
            get { return _bookTitles; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _bookTitles = value;
                }
                else
                {
                    throw new Exception($"Invalid Book Title: {value}");
                }
            }
        }

        public string AuthorFullName
        {
            get { return _authorFullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _authorFullName = value;
                }
                else
                {
                    throw new Exception($"Invalid Author Full Name: {value}");
                }
            }
        }

        public string GenreBooks
        {
            get { return _genreBooks; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _genreBooks = value;
                }
                else
                {
                    throw new Exception($"Invalid Genre: {value}");
                }
            }
        }

        public int YearOfPublication
        {
            get { return _yearOfPublication; }
            set
            {
                if (value > 0)
                {
                    _yearOfPublication = value;
                }
                else
                {
                    throw new Exception($"Invalid Year of Publication: {value}. The year must be in the past.");
                }
            }
        }

        public Book(string bookTitle, string authorFullName, string genre, int yearOfPublication)
        {
            BookTitles = bookTitle;
            AuthorFullName = authorFullName;
            GenreBooks = genre;
            YearOfPublication = yearOfPublication;
        }

        public override string ToString()
        {
            return $"Title: {BookTitles}, " +
                   $"Author: {AuthorFullName}, " +
                   $"Genre: {GenreBooks}, " +
                   $"Year: {YearOfPublication}";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
