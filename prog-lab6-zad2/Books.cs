using System;

namespace prog_lab6_zad2
{
    class Books
    {
        SingleBook[] database;
        int N;
        public Books()
        {
            N = 0;
            database = new SingleBook[N];
            AutomaticlyCreate3Books();
        }

        public void AddBook()
        {
            N++;
            Array.Resize(ref database, N);

            Console.WriteLine("Введите информацию о книге.");
            Console.Write("Автор книги : ");
            database[N - 1].author = Console.ReadLine();
            Console.Write("Названиие : ");
            database[N - 1].bookName = Console.ReadLine();
            Console.Write("Код книги : ");
            database[N - 1].idCode = int.Parse(Console.ReadLine());
            Console.Write("Год публикации : ");
            database[N - 1].yearPublished = int.Parse(Console.ReadLine());
            Console.Write("Количество страниц : ");
            database[N - 1].amountOfPages = int.Parse(Console.ReadLine());
            Console.Write("Жанр : ");
            database[N - 1].genre = Console.ReadLine();
        }

        public void SearchByCode()
        {
            Console.WriteLine("Введите код книги для поиска.");
            int codeToFind = int.Parse(Console.ReadLine());

            foreach (SingleBook a in database)
                if (a.idCode == codeToFind)
                    Console.WriteLine(a.bookName);
        }
        
        public void CompareTwoBooks()
        {
            Console.WriteLine("Введите ID книг для сравнения. ( от 1 до " + N + " ) ");
            int idFirst = int.Parse(Console.ReadLine());
            int idSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Сравнить по : \n 1 - автор, 2 - название, 3 - код, 4 - год публикации, /n 5 - количество страниц, 6 - жанр (введите цифру от 1 до 6)");
            SBComparer a = new SBComparer();
            a.action = int.Parse(Console.ReadLine());

            if (a.Compare(database[idFirst - 1], database[idSecond - 1]) == 0)
                Console.WriteLine("Книга {0} == Книга {1}", idFirst, idSecond);
            else if (a.Compare(database[idFirst - 1], database[idSecond - 1]) == -1)
                Console.WriteLine("Книга {0} > Книга {1}", idFirst, idSecond);
            else if (a.Compare(database[idFirst - 1], database[idSecond - 1]) == 1)
                Console.WriteLine("Книга {0} < Книга {1}", idFirst, idSecond);
            else
                Console.WriteLine("Введите цифру от 1 до 6!");
        }
        
        public void OutputBook()
        {
            Console.WriteLine("Введите номер книги. (от 1 до " + N + " )");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Книга " + id + "\n" + database[id - 1]);
        }

        public void OutputAllBooks()
        {
            for (int i = 0; i < N; i++)
                Console.WriteLine("Книга " + (i + 1) + "\n" + database[i] + "\n");
        }

        public void AutomaticlyCreate3Books()
        {
            N++;
            Array.Resize(ref database, N);
            database[N - 1].author = "Гоголь Н.В.";
            database[N - 1].bookName = "Вий";
            database[N - 1].idCode = 30557;
            database[N - 1].yearPublished = 1895;
            database[N - 1].amountOfPages = 301;
            database[N - 1].genre = "Роман";

            N++;
            Array.Resize(ref database, N);
            database[N - 1].author = "Роулинг Джоан";
            database[N - 1].bookName = "Гарри Поттер и философский камень";
            database[N - 1].idCode = 41451;
            database[N - 1].yearPublished = 2001;
            database[N - 1].amountOfPages = 218;
            database[N - 1].genre = "Приключения";

            N++;
            Array.Resize(ref database, N);
            database[N - 1].author = "Толкин Руэл";
            database[N - 1].bookName = "Сильмариллион";
            database[N - 1].idCode = 74521;
            database[N - 1].yearPublished = 1977;
            database[N - 1].amountOfPages = 365;
            database[N - 1].genre = "Фэнтези";
        }
    }
}
