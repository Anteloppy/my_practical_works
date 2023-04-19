using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Exists
    {
        private Random _random = new Random();
        private int rPage
        { get => _random.Next(50, 1000); }
        private int rInt
        { get => _random.Next(1970, 2023); }
        internal List<Books> Books { get; private set; }
        public void Initialize()
        {
            Books = new List<Books>
            {
                new Books(rPage, new Author("Соколов В.М."), new Names ("Фрагменты прошлого в настоящем"), rInt),
                new Books(rPage, new Author("Шестаков М.Н."), new Names ("Герой туманной долины"), rInt),
                new Books(rPage, new Author("Петров В.П."), new Names ("Чёрная роза"), rInt),
                new Books(rPage, new Author("Кудрявцева Л.Г."), new Names ("Там где нас нет"), rInt),
                new Books(rPage, new Author("Селезнёва К.П."), new Names ("Мысль во тьме"), rInt),
                new Books(rPage, new Author("Куликова К.Н."), new Names ("Предел мечты"), rInt)
            };
        } 
    }
}
