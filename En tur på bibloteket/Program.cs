using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace En_tur_på_bibloteket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            Book.addBooks();
            while (true)
            {
                Console.WriteLine("1)Vælg en bog du vil låne");
                Console.WriteLine("2)Se bøger som er ledige");
                Console.WriteLine("3) Vis de bøger du har valgt");
                Console.WriteLine("4)Lån valgte bøger");
                int input1 = Int32.Parse(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        LendSystem();
                        break;
                    case 2:
                        Book.ShowBooks();
                        break;
                    case 3:
                        showLend();
                        break;
                    case 4:
                        LendOut();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(Environment.NewLine);

            }


        }
        static Bog Book = new Bog();


        static Stack<Bog> BookStack = new Stack<Bog>();

        // Låne system
        private static void LendSystem()
        {
            Console.WriteLine("Skriv navnet på bog");
            string bookName = Console.ReadLine();
            Bog lendTrue = Book.LendBook(bookName);
            if (lendTrue != null)
            {
                BookStack.Push(lendTrue);
                Console.WriteLine(" ");
                Console.WriteLine("Bog tilføjet");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Den bog har vi ikke");
                Console.WriteLine(" ");
            }
        }
        //Hvis hvilke bøger der er valgt
        static void showLend()
        {
            Console.WriteLine(Environment.NewLine);
            foreach (var item in BookStack)
            {
                Console.WriteLine(item.Name);
            }
        }

        // Tager bøgerne ud af systemet
        static void LendOut()
        {
            Console.WriteLine("Du har lånt bøgerne");
            Console.WriteLine(" ");
            for (int i = 0; i <= BookStack.Count; i++)
            {
                Console.WriteLine(BookStack.Peek().Name);
                BookStack.Pop();
            }
        }

    }
}
