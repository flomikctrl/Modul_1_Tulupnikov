using System;

namespace BookLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Добро пожаловать в приложение BookLibraryApp ===\n");

            
            Library myLibrary = new Library("Моя домашняя библиотека");

            
            Console.WriteLine("Создаём книги...\n");

            Book book1 = new Book("Война и мир", "Роман", 1869, "Лев Толстой");
            Book book2 = new Book("Преступление и наказание", "Роман", 1866, "Фёдор Достоевский");
            Book book3 = new Book("1984", "Антиутопия", 1949, "Джордж Оруэлл");
            Book book4 = new Book("Мастер и Маргарита", "Роман", 1967, "Михаил Булгаков");
            Book book5 = new Book("Три товарища", "Роман", 1936, "Эрих Мария Ремарк");
            Book book6 = new Book("Метро 2033", "Фантастика", 2005, "Дмитрий Глуховский");
            Book book7 = new Book("Этюд в багровых тонах", "Детектив", 1887, "Артур Конан Дойл");
            Book book8 = new Book("Гарри Поттер и философский камень", "Фэнтези", 1997, "Джоан Роулинг");
            Book book9 = new Book("Анна Каренина", "Роман", 1877, "Лев Толстой");
            Book book10 = new Book("Собачье сердце", "Повесть", 1925, "Михаил Булгаков");

           
            book5.MarkAsRead(); 
            book7.MarkAsRead(); 
            book10.MarkAsRead(); 

            
            Console.WriteLine("Добавляем книги в библиотеку...\n");
            
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            myLibrary.AddBook(book4);
            myLibrary.AddBook(book5);
            myLibrary.AddBook(book6);
            myLibrary.AddBook(book7);
            myLibrary.AddBook(book8);
            myLibrary.AddBook(book9);
            myLibrary.AddBook(book10);

            Console.WriteLine("\n" + new string('=', 50));

            
            myLibrary.ShowAllBooks();

            Console.WriteLine(new string('=', 50));

            
            myLibrary.ShowBooksByGenre("Роман");

            Console.WriteLine(new string('=', 50));

            
            myLibrary.ShowStatistics();

            Console.WriteLine(new string('=', 50));

            
            Console.WriteLine("\nПробуем удалить книгу \"1984\"...");
            myLibrary.RemoveBook("1984");

            Console.WriteLine("\n" + new string('=', 50));

            
            myLibrary.ShowAllBooks();

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}