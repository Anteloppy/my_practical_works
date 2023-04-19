using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите автора, название книги, количество страниц и год выпуска");
            string a = Console.ReadLine(), n = Console.ReadLine();
            int p = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(a,n,p,y);
            book.Print();
            Console.ReadKey();
        }
        public class Book
        {
            public Book(string Author, string Name, int pages, int year)
            { author = Author; name = Name; Pages = pages; Year = year; }
            private string name, author; private int pages, year;
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 1000 && value > 49)
                    { pages = value; }
                    else { pages = 100; }
                }
            }
            public int Year
            {
                get { return year; }
                set
                {
                    if (value < 2024 && value > 1970)
                    { year = value; }
                    else { year = 2023; }
                }
            }
            public void Print()
            {
                Console.WriteLine($"Книга авторства {author} под наванием {name} с {Pages} стр. выпущенная в {Year} году");
            }
        }
    }
}
