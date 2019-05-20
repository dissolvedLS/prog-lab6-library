using System;

namespace prog_lab6_zad2
{
    struct SingleBook : IComparable
    {
        public string author;
        public string bookName;
        public int idCode;
        public int yearPublished;
        public int amountOfPages;
        public string genre;

        public int CompareTo(object o)
        {
            SingleBook one = (SingleBook)o;
            return author.CompareTo(one.author);
        }

        public override string ToString()
        {
            return "Автор : " + author + "\nНазвание : " + bookName + "\nКод книги : " + idCode + "\nГод публикации : " + 
                yearPublished + "\nКоличество страниц : " + amountOfPages + "\nЖанр : " + genre + "\n";
        }
    }
}
