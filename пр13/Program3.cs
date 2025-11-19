using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public abstract class LibraryItem
    {
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public int PublicationYear { get; protected set; }
        public bool IsAvailable { get; set; }
        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            IsAvailable = true;
        }
        public abstract string GetItemInfo();
    }
    public class Book : LibraryItem
    {
        public int PageCount { get; protected set; }
        public string ISBN { get; protected set; }
        public Book(string title, string author, int publicationYear, int pageCount, string isbn) : base(title, author, publicationYear)
        {
            PageCount = pageCount;
            ISBN = isbn;
        }
        public override string GetItemInfo()
        {
            return $"Книга: {Title} ({Author}, {PublicationYear}), ISBN: {ISBN}, страниц: {PageCount}, доступна: {IsAvailable}";
        }
    }
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; protected set; }
        public string Periodicity { get; protected set; }
        public Magazine(string title, string author, int publicationYear, int issueNumber, string periodicity) : base(title, author, publicationYear)
        {
            IssueNumber = issueNumber;
            Periodicity = periodicity;
        }
        public override string GetItemInfo()
        {
            return $"Журнал: {Title} ({Author}, {PublicationYear}), выпуск: {IssueNumber}, периодичность: {Periodicity}, доступен: {IsAvailable}";
        }
    }
    public class DVD : LibraryItem
    {
        public int DurationMinutes { get; protected set; }
        public string Rating { get; protected set; }
        public DVD(string title, string author, int publicationYear, int durationMinutes, string rating) : base(title, author, publicationYear)
        {
            DurationMinutes = durationMinutes;
            Rating = rating;
        }
        public override string GetItemInfo()
        {
            return $"DVD: {Title} ({Author}, {PublicationYear}), продолжительность: {DurationMinutes} мин., рейтинг: {Rating}, доступен: {IsAvailable}";
        }
    }
    public class Audiobook : LibraryItem
    {
        public int DurationMinutes { get; protected set; }
        public string Narrator { get; protected set; }

        public Audiobook(string title, string author, int publicationYear, int durationMinutes, string narrator) : base(title, author, publicationYear)
        {
            DurationMinutes = durationMinutes;
            Narrator = narrator;
        }
        public override string GetItemInfo()
        {
            return $"Аудиокнига: {Title} ({Author}, {PublicationYear}), длительность: {DurationMinutes} мин., диктор: {Narrator}, доступна: {IsAvailable}";
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var book1 = new Book("Преступление и наказание", "Ф.М. Достоевский", 1866, 600, "978-5-699-15428-7");
            var magazine1 = new Magazine("National Geographic", "National Geographic Society", 2023, 10, "Monthly");
            var dvd1 = new DVD("Interstellar", "Christopher Nolan", 2014, 169, "PG-13");
            var audiobook1 = new Audiobook("Гарри Поттер и философский камень", "Дж.К. Роулинг", 1997, 480, "Стивен Фрай");
            Console.WriteLine(book1.GetItemInfo());
            Console.WriteLine(magazine1.GetItemInfo());
            Console.WriteLine(dvd1.GetItemInfo());
            Console.WriteLine(audiobook1.GetItemInfo());
            var libraryItems = new List<LibraryItem> { book1, magazine1, dvd1, audiobook1 };
            var booksByDostoevsky = libraryItems.OfType<Book>()
                .Where(book => book.Author == "Ф.М. Достоевский")
                .ToList();
            foreach (var book in booksByDostoevsky)
            {
                Console.WriteLine("Найдена книга Достоевского: " + book.Title);
            }
        }
    }
}
