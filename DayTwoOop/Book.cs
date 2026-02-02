using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoOop
{
    public class Book
    {

        public string BookTitle;
        public string Author;
        public bool IsIssued;

        public static int TotalBooks = 0;

           public Book(string title, string author)
        {
            this.BookTitle = title;
            this.Author = author;
            this.IsIssued = false;
            TotalBooks++;//becasue toal book is already a static so we dont use a this hee

        }

        public Book(string title)
        {
        }

        public void IssueBook()
        {
            if (IsIssued == false)
            {
                IsIssued = true;
                Console.WriteLine("Book issued successfully");
            }
            else
            {
                Console.WriteLine("Sorry, you can't issue this book right now");
            }
        }
        public void ReturnBook()
        {
            if (IsIssued==true)
            {
                IsIssued = false;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book was not issued.");
            }
        }
        public void DisplayBook()
        {
            Console.WriteLine($"Title : {BookTitle}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Issued: {(IsIssued ? "Yes" : "No")}");
            Console.WriteLine("----------------------------");
        }






    }
}
