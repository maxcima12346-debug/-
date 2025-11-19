using System;
using System.Collections.Generic;
using System.Linq;
 namespace EducationPlatform
    {
        public abstract class Course
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Author { get; set; }
            public decimal Price { get; set; }

            public Course(string title, string description, string author, decimal price)
            {
                Title = title;
                Description = description;
                Author = author;
                Price = price;
            }
            public virtual string GetCourseInfo()
            {
                return $"Название: {Title}\nАвтор: {Author}\nОписание: {Description}\nЦена: {Price:C}";
            }
            public abstract void StartLearning();
        }
        public class VideoCourse : Course
        {
            public int NumberOfVideos { get; set; }
            public int TotalDurationMinutes { get; set; }
            public VideoCourse(string title, string description, string author, decimal price, int numberOfVideos, int totalDurationMinutes)
                : base(title, description, author, price)
            {
                NumberOfVideos = numberOfVideos;
                TotalDurationMinutes = totalDurationMinutes;
            }
            public override string GetCourseInfo()
            {
                return base.GetCourseInfo() + $"\nКоличество видео: {NumberOfVideos}\nОбщая продолжительность: {TotalDurationMinutes} минут";
            }
            public override void StartLearning()
            {
                Console.WriteLine($"Запуск видеокурса: {Title}.  Приготовьтесь к просмотру {NumberOfVideos} видео.");
            }
            public void DownloadVideos()
            {
                Console.WriteLine("Загрузка видеоконтента...");
            }
        }
        public class TextCourse : Course
        {
            public int NumberOfChapters { get; set; }
            public int TotalTextLength { get; set; } 
            public TextCourse(string title, string description, string author, decimal price, int numberOfChapters, int totalTextLength)
                : base(title, description, author, price)
            {
                NumberOfChapters = numberOfChapters;
                TotalTextLength = totalTextLength;
            }
            public override string GetCourseInfo()
            {
                return base.GetCourseInfo() + $"\nКоличество глав: {NumberOfChapters}\nОбщий объем текста: {TotalTextLength} символов";
            }
            public override void StartLearning()
            {
                Console.WriteLine($"Запуск текстового курса: {Title}. Начинаем изучение с главы 1.");
            }
            public void PrintCourse()
            {
                Console.WriteLine("Печать конспекта...");
            }
        }
        public class InteractiveCourse : Course
        {
            public int NumberOfExercises { get; set; }
            public string GradingSystem { get; set; }
            public InteractiveCourse(string title, string description, string author, decimal price, int numberOfExercises, string gradingSystem)
                : base(title, description, author, price)
            {
                NumberOfExercises = numberOfExercises;
                GradingSystem = gradingSystem;
            }
            public override string GetCourseInfo()
            {
                return base.GetCourseInfo() + $"\nКоличество упражнений: {NumberOfExercises}\nСистема оценивания: {GradingSystem}";
            }
            public override void StartLearning()
            {
                Console.WriteLine($"Запуск интерактивного курса: {Title}.  Приготовьтесь к выполнению упражнений.");
            }
            public void GradeExercise(int exerciseNumber)
            {
                Console.WriteLine($"Проверка упражнения №{exerciseNumber}...");
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                var videoCourse = new VideoCourse("C# для начинающих", "Основы программирования на C#", "Иванов И.И.", 99.99m, 20, 120);
                var textCourse = new TextCourse("Математика для программистов", "Линейная алгебра и дискретная математика", "Петров П.П.", 79.99m, 15, 50000);
                var interactiveCourse = new InteractiveCourse("Web-разработка с нуля", "HTML, CSS, JavaScript", "Сидоров С.С.", 129.99m, 30, "Автоматическая");
                Console.WriteLine(videoCourse.GetCourseInfo());
                videoCourse.StartLearning();
                videoCourse.DownloadVideos();
                Console.WriteLine("\n" + textCourse.GetCourseInfo());
                textCourse.StartLearning();
                textCourse.PrintCourse();
                Console.WriteLine("\n" + interactiveCourse.GetCourseInfo());
                interactiveCourse.StartLearning();
                interactiveCourse.GradeExercise(1);
            }
        }
    }
