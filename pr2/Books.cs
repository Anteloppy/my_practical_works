using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Books
    {
        private int _pages, _year; private Names _name; private Author _author;
        public int Pages
        { get => _pages; }
        private Author Author
        { get => _author; }
        public string author
        { get { return Author != null ? Author.Surname : "Отсутствует"; } }
        private Names Name
        { get => _name; }
        public string name
        { get { return Name != null ? Name.Name : "Отсутствует"; } }
        public int Year
        { get => _year; }
        public Books(int Pages, Author Author, Names Name, int Year)
        { _pages = Pages; _author = Author;_name = Name; _year = Year; }
    }
}
