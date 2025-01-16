namespace Тумаков___Лабораторная_12_главы.Classes
{
    public delegate void DelegateSorted(int criteria);
    public class Library
    {
        public Book[] books = new Book[]
        {new Book{Name = "Кладбище домашних животных", Author = "Стивен Кинг", Publication = "Голос"},
         new Book{Name = "Война и мир", Author = "Толстой", Publication = "Ромашка"},
         new Book{Name = "Мастер и Маргарита", Author = "Булгаков", Publication = "Звездочёт"}};
        public void SortingLibrary(DelegateSorted book, int i)
        {
            book.Invoke(i);
        }

        public void Sort(int criteria)
        {
            switch (criteria)
            {
                case 1:
                    {
                        Console.Write("По названию:\n");
                        books = books.OrderBy(e => e.Name).ToArray();
                        break;
                    }
                case 2:
                    {
                        Console.Write("По автору:\n");
                        books = books.OrderBy(e => e.Author).ToArray();
                        break;
                    }
                case 3:
                    {
                        Console.Write("По издательству:\n ");
                        books = books.OrderBy(e => e.Publication).ToArray();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введите число 1-3");
                        break;
                    }
            }
            foreach (var item in books)
            {
                Console.WriteLine($"Название - {item.Name}, автор - {item.Author}, издательство - {item.Publication}");
            }
        }
    }
}
