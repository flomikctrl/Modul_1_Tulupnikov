using System;
using System.Collections.Generic;

namespace BookLibraryApp
{
    public class Library
    {
        // Свойства библиотеки
        public string Name { get; }                    
        private List<Book> Books { get; set; }        

        // Конструктор
        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        // Метод добавления книги
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" успешно добавлена в библиотеку \"{Name}\"!");
        }

        // Метод показа всех книг
        public void ShowAllBooks()
        {
            Console.WriteLine($"\n=== Библиотека: {Name} ===");
            Console.WriteLine($"Всего книг: {Books.Count}\n");

            if (Books.Count == 0)
            {
                Console.WriteLine("В библиотеке нет книг.");
                return;
            }

            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }

        // Метод показа книг по жанру
        public void ShowBooksByGenre(string genre)
        {
            Console.WriteLine($"\n=== Книги жанра \"{genre}\" в библиотеке \"{Name}\" ===");
            
            var foundBooks = Books.FindAll(b => 
                b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));

            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Книги жанра \"{genre}\" не найдены.");
                return;
            }

            foreach (var book in foundBooks)
            {
                book.DisplayInfo();
            }
        }

        // Метод удаления книги по названию
        public void RemoveBook(string title)
        {
            Book bookToRemove = Books.Find(b => 
                b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                Console.WriteLine($"Книга \"{title}\" успешно удалена из библиотеки.");
            }
            else
            {
                Console.WriteLine($"Книга \"{title}\" не найдена в библиотеке.");
            }
        }

        // Метод получения статистики
        public void ShowStatistics()
        {
            int readCount = Books.Count(b => b.IsRead);
            int unreadCount = Books.Count - readCount;

            Console.WriteLine($"\n=== Статистика библиотеки \"{Name}\" ===");
            Console.WriteLine($"Всего книг: {Books.Count}");
            Console.WriteLine($"Прочитано: {readCount}");
            Console.WriteLine($"Не прочитано: {unreadCount}");
            
            // Группировка по жанрам
            var genres = new Dictionary<string, int>();
            foreach (var book in Books)
            {
                if (genres.ContainsKey(book.Genre))
                    genres[book.Genre]++;
                else
                    genres[book.Genre] = 1;
            }

            Console.WriteLine("\nКниги по жанрам:");
            foreach (var genre in genres)
            {
                Console.WriteLine($"  {genre.Key}: {genre.Value} шт.");
            }
        }
    }
}
