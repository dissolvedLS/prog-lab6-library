using System;

namespace prog_lab6_zad2
{

    class Program
    {
        static void Main(string[] args)
        {
            Books newbooks = new Books();
            newbooks.OutputAllBooks();

            while (true)
            {
                Console.WriteLine("------------------ Выберите действие. --------------------");
                Console.WriteLine("1 - добавить книгу, 2 - поиск книги, 3 - сравнить книги, \n4 - показать книгу, " +
                    "5 - показать ВСЕ книги, 6 - выход.\n");

                int checkAction = int.Parse(Console.ReadLine());

                switch (checkAction)
                {
                    case 1:
                        newbooks.AddBook();
                        break;
                    case 2:
                        newbooks.SearchByCode();
                        break;
                    case 3:
                        newbooks.CompareTwoBooks();
                        break;
                    case 4:
                        newbooks.OutputBook();
                        break;
                    case 5:
                        newbooks.OutputAllBooks();
                        break;
                    case 6:
                        Environment.FailFast("");
                        break;
                    default:
                        Console.WriteLine("Введите цифру от 1 до 6!");
                        break;
                }
            }

        }
    }
}
