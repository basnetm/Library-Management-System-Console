// See https://aka.ms/new-console-template for more information
using DayTwoOop;

Console.WriteLine("Hello, World!");


            Library library = new Library();
            bool running = true;

while (running)
{
    Console.WriteLine("\n--- LIBRARY MENU ---");
    Console.WriteLine("1. Add Book");
    Console.WriteLine("2. Issue Book");
    Console.WriteLine("3. Return Book");
    Console.WriteLine("4. Show All Books");
    Console.WriteLine("5. Show Total Books");
    Console.WriteLine("6. Exit");

    Console.Write("Choose an option: ");
    int choice = int.Parse(Console.ReadLine()); 


    if (choice == 1)
                {
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter author  ");
                    string author = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(author))
                        library.AddBook(new Book(title));            
                    else
                        library.AddBook(new Book(title, author));    
                }
                else if (choice == 2)
                {
                    Console.Write("Enter book title to issue: ");
                    string title = Console.ReadLine();
                    library.IssueBookByTitle(title);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter book title to return: ");
                    string title = Console.ReadLine();
                    library.ReturnBookByTitle(title);
                }
                else if (choice == 4)
                {
                    library.ShowAllBooks();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Total Books Created: " + Book.TotalBooks);
                }
                else if (choice == 6)
                {
                    running = false;
                    Console.WriteLine("Exiting... Bye!");
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        
    

