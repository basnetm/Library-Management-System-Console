using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoOop
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added to library.");
        }

        public void ShowAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            for (int i = 0; i < books.Count; i++)
            {
                books[i].DisplayBook();
            }
        }


        private Book FindBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.BookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }


        public void IssueBookByTitle(string title)
        {
            var found = FindBookByTitle(title);

            if (found == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            found.IssueBook();
        }

        public void ReturnBookByTitle(string title)
        {
            var found = FindBookByTitle(title);

            if (found == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            found.ReturnBook();
        }

        


    }
}
