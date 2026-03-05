using System.Text.RegularExpressions;

namespace BookLibraryApp
{
    class Book
    {
        public string Title;
        public string Genre;
        public int Year;
        public string Author;
        public bool IsCompleted = false;
        public Book(string genre, string title, int year, string author, bool iscompleted)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Author = author;
            IsCompleted = iscompleted;
        }
        public void DisplayInfo()
        {
            if (IsCompleted == false)
            {
                System.Console.WriteLine($"название книги {Title}, Жанр: {Genre}, Год{Year}, Автор {Author}, Статус : не прочитана.");
            }
            else
            {
                System.Console.WriteLine($"название книги {Title}, Жанр: {Genre}, Год{Year}, Автор {Author}, Статус: прочитана.");
            }


        }
        public void MarkAsRead()
        {
            IsCompleted = true;
            System.Console.WriteLine($"✓ Книга {Title} отмечена как прочитанная");
        }
    }
}
