using System.Text.RegularExpressions;

namespace BookLibraryApp
{
    class Book
    {
        public string Title;
        public string Genre;
        public int Year;
        public string Platform;
        public bool IsCompleted = false;
        public Game(string genre, string title, int year, string platform, bool iscompleted)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Platform = platform;
            IsCompleted = iscompleted;
        }
        public void ShowInfo()
        {
            if (IsCompleted == false)
            {
                System.Console.WriteLine($"название игры {Title}, Жанр: {Genre}, Год{Year}, Платформа {Platform}, Статус : не пройдена.");
            }
            else
            {
                System.Console.WriteLine($"название игры {Title}, Жанр: {Genre}, Год{Year}, Платформа {Platform}, Статус: пройдена.");
            }


        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            System.Console.WriteLine($"✓ Игра {Title} отмечена как пройденная");
        }
        public void Play()
        {
            System.Console.WriteLine($"Запуск игры {Title}");
        }
    }
}