using System;
using System.Collections.Generic;
using System.Text;

namespace En_tur_på_bibloteket
{
    class Bog
    {
        string name;

        static List<Bog> Books = new List<Bog>();
        public string Name { get => name; set => name = value; }

        public Bog()
        {

        }

          public Bog(string theName)
        {
            this.name = theName;
        }

        public void addBooks()
        {
            Books.Add(new Bog("Iron Man"));
            Books.Add(new Bog("Spider Man"));
            Books.Add(new Bog("Super Man"));
            Books.Add(new Bog("Olsen Banden"));
            Books.Add(new Bog("TinTin"));

        }


        public void ShowBooks()
        {
            foreach (var item in Books)
            {
                
                Console.WriteLine("{0}", item.name);
            }
        }


        public Bog LendBook(string bookName)
        {

            foreach (var item in Books)
            {
                if (item.name == bookName)
                {
                    Books.Remove(item);
                    return item;
                }
            }

            return null;
        }

    }





}
