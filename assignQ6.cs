using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment1
{
    internal class assignQ6
    {
        public struct Book
        {
            int bookID;
            string _title;
            float _price;
            int booktype;
            public int Id
            {
                get { return bookID; }
                set { bookID = value; }
            }
            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            public float Price
            {
                get { return _price; }
                set { _price = value; }
            }
            public Type BookType
            {
                get { return (Type)booktype; }
                set { booktype = (int)value; }
            }
            public void print()
            {
                Console.WriteLine("your Book Id={0} Title={1} Price={2} Type={3}", Id, Title, Price, BookType);
            }
            public void Print()
            {
                Console.WriteLine("your book Id={0} Title={1} Price={2} Type={3}", Id, Title, Price);
            }
        }
        public enum Type
        {
            Magazine,
            Novel,
            Referencebook,
            Miscelleous
        }
        class BookCall
        {
            public static void Main()
            {
                try
                {
                    Book b1 = new Book();
                    b1.Id = 1;
                    b1.Title = "java";
                    b1.Price = 105.52F;
                    b1.BookType = Type.Referencebook;
                    b1.print();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                }
                finally
                {
                    Console.WriteLine("its final");
                }
            }

        }
    }

}

