using System.Collections.Generic;

namespace prog_lab6_zad2
{
    class SBComparer : IComparer<SingleBook>
    {
        public int action;
        public int Compare(SingleBook x, SingleBook y)
        {
            switch (action)
            {
                case 1:
                    return (x.author).CompareTo(y.author);
                case 2:
                    return (x.bookName).CompareTo(y.bookName);
                case 3:
                    return (x.idCode).CompareTo(y.idCode);
                case 4:
                    return (x.yearPublished).CompareTo(y.yearPublished);
                case 5:
                    return (x.amountOfPages).CompareTo(y.amountOfPages);
                case 6:
                    return (x.genre).CompareTo(y.genre);
                default:
                    return 100;
            }
        }
    }
}
