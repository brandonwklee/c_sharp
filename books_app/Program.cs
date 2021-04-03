using System;
using System.Collections.Generic;

namespace books_app
{
    class Program
    {
        public static List<book> readingList = new List<book>();
        public static List<book> finishedBook = new List<book>();

        static void Main(string[] args)
        {
           // var sd = new book("sdsds", "sdsds", "333", 4567, "qwer");
            var qw = new book("sdsds", "sdsds", "333", 4567, "qwer");

            //readingList.Add(sd);
            finishedBook.Add(qw);

            while (true)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine($"|{"Reading App and monitoring reading progress", -30}|");
            Console.WriteLine($"|{"-",-30}|");
            Console.WriteLine($"|{"1. Show reading list", -30}|");
            Console.WriteLine($"|{"2. Show finished books", -30}|");
            Console.WriteLine($"|{"3. Add book to reading list", -30}|");
            Console.WriteLine("Press 4 to Quit");
            Console.WriteLine();
            String userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    if (readingList == null)
                    {
                        Console.WriteLine("There are no books in reading list!");
                        Console.WriteLine();
                    }
                    Console.WriteLine($"|{"Book Title", -5}|{"Author", -5}|{"Genre", -5}|{"Publish_date", -5}|{ "Description",-5}|");
                    foreach (book books in readingList)
                    {
                        Console.WriteLine($"|{books.Name, -15}|{books.Author, -15}|{books.Genre, -15}|{books.Publish_Date, -15}|{books.Description, -15}|");
                    }
                    Console.WriteLine();
                    break;

                case "2":
                    if (finishedBook == null)
                    {
                        Console.WriteLine("There are no books in reading list!");
                        Console.WriteLine();
                    }
                    Console.WriteLine($"|{"Book Title",-5}|{"Author",-5}|{"Genre",-5}|{"Publish_date",-5}|{ "Description",-5}|");
                    foreach (book books in finishedBook)
                    {
                        Console.WriteLine($"|{books.Name,-15}|{books.Author,-15}|{books.Genre,-15}|{books.Publish_Date,-15}|{books.Description,-15}|");
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("Enter book details [title, writer, genre, publish date, description]: ");
                    Console.WriteLine();
                    String bookInfo = Console.ReadLine();
                    String[] information = bookInfo.Split(",");
                    int date = Int16.Parse(information[3]);
                    var newBook = new book(information[0], information[1], information[2], date, information[4]);
                    readingList.Add(newBook);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}